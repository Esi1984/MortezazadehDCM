using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MagicManager
{
    public static class GeneralStatic
    {


        public static DataTable ToPivotTable<T, TColumn, TRow, TData>(
                                            this IEnumerable<T> source,
                                            Func<T, TColumn> columnSelector,
                                            Expression<Func<T, TRow>> rowSelector,
                                            Func<IEnumerable<T>, TData> dataSelector)
        {


            // //"Esi"+col.FieldID.ToString();


            DataTable table = new DataTable();
          //  var rowName = ((MemberExpression)rowSelector.Body).Member.Name;
            // table.Columns.Add(new DataColumn("alhvi"));

            table.Columns.Add(new DataColumn("ID"));

            var columns = source.Select(columnSelector).Distinct();

            foreach (var column in columns)
                table.Columns.Add(new DataColumn("Esi"+column.ToString()));

            var rows = source.GroupBy(rowSelector.Compile())
                             .Select(rowGroup => new
                             {
                                 Key = rowGroup.Key,
                                 Values = columns.GroupJoin(
                                     rowGroup,
                                     c => c,
                                     r => columnSelector(r),
                                     (c, columnGroup) => dataSelector(columnGroup))
                             });

            foreach (var row in rows)
            {
                var dataRow = table.NewRow();
                var items = row.Values.Cast<object>().ToList();
                items.Insert(0, row.Key);
                dataRow.ItemArray = items.ToArray();
                table.Rows.Add(dataRow);
            }
            return table;
        }

        public static dynamic[] ToPivotArray<T, TColumn, TRow, TData>(
                                            this IEnumerable<T> source,
                                            Func<T, TColumn> columnSelector,
                                            Expression<Func<T, TRow>> rowSelector,
                                            Func<IEnumerable<T>, TData> dataSelector)
        {

            var arr = new List<object>();
            var cols = new List<string>();
            String rowName = ((MemberExpression)rowSelector.Body).Member.Name;
            var columns = source.Select(columnSelector).Distinct();

            cols = (new[] { rowName }).Concat(columns.Select(x => x.ToString())).ToList();


            var rows = source.GroupBy(rowSelector.Compile())
                             .Select(rowGroup => new
                             {
                                 Key = rowGroup.Key,
                                 Values = columns.GroupJoin(
                                     rowGroup,
                                     c => c,
                                     r => columnSelector(r),
                                     (c, columnGroup) => dataSelector(columnGroup))
                             }).ToArray();


            foreach (var row in rows)
            {
                var items = row.Values.Cast<object>().ToList();
                items.Insert(0, row.Key);
                var obj = GetAnonymousObject(cols, items);
                arr.Add(obj);
            }
            return arr.ToArray();
        }

        private static dynamic GetAnonymousObject(IEnumerable<string> columns, IEnumerable<object> values)
        {
            IDictionary<string, object> eo = new ExpandoObject() as IDictionary<string, object>;
            int i;
            for (i = 0; i < columns.Count(); i++)
            {
                eo.Add(columns.ElementAt<string>(i), values.ElementAt<object>(i));
            }
            return eo;
        }

        public static List<dynamic> ToDynamicList(this DataTable dt)
        {
            var list = new List<dynamic>();
            foreach (DataRow row in dt.Rows)
            {
                dynamic dyn = new ExpandoObject();
                list.Add(dyn);
                foreach (DataColumn column in dt.Columns)
                {
                    var dic = (IDictionary<string, object>)dyn;
                    dic[column.ColumnName] = row[column];
                }
            }
            return list;
        }

        private static void GenetalTest()
        {

            var data = new[] {
              new { Product = "Product 1", Year = 2009, Sales = 1212 },
              new { Product = "Product 2", Year = 2009, Sales = 522 },
              new { Product = "Product 1", Year = 2010, Sales = 1337 },
              new { Product = "Product 2", Year = 2011, Sales = 711 },
              new { Product = "Product 2", Year = 2012, Sales = 2245 },
              new { Product = "Product 3", Year = 2012, Sales = 1000 }
          };

            DataTable myDataTable = new DataTable();
            myDataTable.Columns.AddRange(new DataColumn[3] { new DataColumn("Product"), new DataColumn("Year", typeof(int)), new DataColumn("Sales", typeof(int)) });
            myDataTable.Rows.Add("Product 1", 2009, 1212);
            myDataTable.Rows.Add("Product 2", 2009, 522);
            myDataTable.Rows.Add("Product 1", 2010, 1337);
            myDataTable.Rows.Add("Product 2", 2011, 711);
            myDataTable.Rows.Add("Product 2", 2012, 2245);
            myDataTable.Rows.Add("Product 3", 2012, 1000);

            var pivotArray = data.ToPivotArray(
               item => item.Year,
              item => item.Product,
              items => items.Any() ? items.Sum(x => x.Sales) : 0);


            var data2 = myDataTable.AsEnumerable().Select(x => new {
                Product = x.Field<String>("Product"),
                Year = x.Field<int>("Year"),
                Sales = x.Field<int>("Sales")
            });

            DataTable pivotDataTable = data2.ToPivotTable(
                 item => item.Year,
                item => item.Product,
                items => items.Any() ? items.Sum(x => x.Sales) : 0);


            String json = JsonConvert.SerializeObject(pivotArray, new KeyValuePairConverter());


        }

    }
}
