using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Data;
using System.Net.Http.Formatting;
using Newtonsoft.Json.Converters;
using System.Dynamic;
using MortezazadehDCM;

namespace MagicManager
{
    public partial class MagicMeta 
    {
        public  HttpClient client = new HttpClient();

        public MagicMeta()
        {
            // api/EsiCategories
            // http://localhost:54345/
            client.BaseAddress = new Uri("http://localhost:49671/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));            
        }

        private  static EsiToMetaType[] ST;

        public   EsiToMetaType[] STM
        {
            get
            {

                
                if (ST == null)
                {
                    ST = GetMt().Result;

                }
                                                   
                     return ST;
                
            }
            private set { }
        }

        public async Task<EsiToCategory[]> CatesView()
        {
            EsiToCategory[] RR;
        
            // = await client.GetAsync("http://localhost:54345/api/values/esihello");
            //  = await client.PostAsJsonAsync("http://localhost:54345/api/values/PostValue","111");

            
           // var rrr = EsiCategoriesExtensions.GetEsiCategories(fff);

            HttpResponseMessage response
                = client.GetAsync("EsiCategories").Result;
            if (response.IsSuccessStatusCode)
            {
                // product = response.Content.
                var s = response.Content.ReadAsStringAsync().Result;
                RR = JsonConvert.DeserializeObject<EsiToCategory[]>(s);
                return RR;
            }

            return null;
        }

        public async Task<EsiToField[]> GetCateMeta(decimal id)
        {

            EsiToField[] RR;
            HttpResponseMessage response
                   = client.GetAsync($"EsiFields/{id.ToString()}").Result;

            if (response.IsSuccessStatusCode)
            {
                // product = response.Content.
                var s = response.Content.ReadAsStringAsync().Result;
                RR = JsonConvert.DeserializeObject<EsiToField[]>(s);
                return RR;
            }
            
            return null;

        }

        private async Task<EsiToMetaType[]> GetMt()
        {
            EsiToMetaType[] RR;
            HttpResponseMessage response
                   = client.GetAsync("EsiMetaTypes").Result;

            if (response.IsSuccessStatusCode)
            {
                // product = response.Content.
                var s = response.Content.ReadAsStringAsync().Result;
                RR = JsonConvert.DeserializeObject<EsiToMetaType[]>(s);
                return RR;
            }
            return null;
        }

        public async Task<bool> CateNew(string label, string desc, List<EsiField> fields)
        {

            EsiToCategory obj = new EsiToCategory();
            obj.CateLabel = label.Trim();
            obj.CateDesc = desc;
            //obj.CateName = label.Trim();
            //obj.CateOrder = 0;
            //obj.CateState = 1;
            //obj.CateTname = label;
            //obj.CateParent = null;
            //obj.EsiFields = fields;

            HttpResponseMessage response
                = client.PostAsJsonAsync("EsiCategories", obj).Result;

            // response.EnsureSuccessStatusCode();
            //if (response.IsSuccessStatusCode)
            //{

            //}
            // return URI of the created resource.
            return response.IsSuccessStatusCode;



        }

        public async Task<bool> CateNew(EsiCategory objCate)
        {

            //string s = JsonConvert.SerializeObject(objCate, Formatting.Indented,
            //          new JsonSerializerSettings()
            //          {
            //              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            //          });

            //HttpResponseMessage response
            //    = client.PostAsJsonAsync("EsiCategories", objCate).Result;


            JsonMediaTypeFormatter jsonformatter;
            jsonformatter = new JsonMediaTypeFormatter();
            jsonformatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;

            HttpResponseMessage response =  
                client.PostAsync<EsiCategory>("EsiCategories",objCate , jsonformatter).Result;

            response.EnsureSuccessStatusCode();

            // response.EnsureSuccessStatusCode();
            //if (response.IsSuccessStatusCode)
            //{

            //}
            // return URI of the created resource.
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> CateNew(string label, string desc)
        {
            EsiToCategory obj = new EsiToCategory();
            obj.CateLabel = label.Trim();
            obj.CateDesc = desc;
            //obj.CateName = label.Trim();
            //obj.CateOrder = 0;
            //obj.CateState = 0;
            //obj.CateTname = label;
            //obj.CateParent = null;
            //obj.EsiFields = null;

            HttpResponseMessage response
                = client.PostAsJsonAsync("EsiCategories", obj).Result;

            // response.EnsureSuccessStatusCode();
            //if (response.IsSuccessStatusCode)
            //{

            //}
            // return URI of the created resource.
            return response.IsSuccessStatusCode;


        }

        public async Task<EsiToItem[]> GetGateItems(decimal id)
        {
            EsiToItem[] RR;

            // = await client.GetAsync("http://localhost:54345/api/values/esihello");
            //  = await client.PostAsJsonAsync("http://localhost:54345/api/values/PostValue","111");
            // $"api/products/{product.Id}"
            // $"api/products/{id}"

            HttpResponseMessage response
                = client.GetAsync($"EsiItems/GetGateItems/{id.ToString()}").Result;
            if (response.IsSuccessStatusCode)
            {
                // product = response.Content.
                var s = response.Content.ReadAsStringAsync().Result;
                RR = JsonConvert.DeserializeObject<EsiToItem[]>(s);
                return RR;
            }

            return null;
        }

        // DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

        #region Esi Model

        public partial class EsiBigData
        {
            public decimal EsiBigDataId { get; set; }
            public byte[] EsiBigDataValue { get; set; }
        }




        public partial class EsiCategory
        {
            public EsiCategory()
            {
                this.EsiFields = new HashSet<EsiField>();
            }

            public decimal CateID { get; set; }
            public string CateName { get; set; }
            public string CateLabel { get; set; }
            public int CateState { get; set; }
            public int CateOrder { get; set; }
            public Nullable<decimal> CateParent { get; set; }
            public string CateDesc { get; set; }
            public string CateTname { get; set; }
            public virtual ICollection<EsiField> EsiFields { get; set; }
            public virtual ICollection<EsiProduct> EsiProducts { get; set; }
        }

        public partial class EsiProduct
        {
            public EsiProduct()
            {
                
            }
        }



        public partial class EsiField
        {

            //  public EsiField This { get { return this; } }


            public EsiField()
            {
                this.EsiItems = new HashSet<EsiItem>();
            }
            public decimal FieldID { get; set; }
            public string FieldLabel { get; set; }
            public int FieldOrder { get; set; }
            public int FieldAutoDescState { get; set; }
            public string FieldPerfix { get; set; }
            public string FieldPostfix { get; set; }
            public int FieldHis { get; set; }
            public int FieldAllowNull { get; set; }
            public int FieldState { get; set; }
            public string FieldDesc { get; set; }
            public Nullable<int> FieldSize { get; set; }
            public virtual EsiCategory EsiToCategory { get; set; }
            public virtual ICollection<EsiItem> EsiItems { get; set; }
            public virtual EsiToMetaType EsiMetaType { get; set; }
        }


        public partial class EsiItem
        {
            // public EsiItem This { get { return this; } }
            public decimal EsiObjId { get; set; }
            public decimal EsiFieldId { get; set; }
            public string EsiStrVal { get; set; }

            public virtual EsiField EsiField { get; set; }
        }

        
        public partial class EsiMetaType
        {
            public EsiMetaType This { get { return this; } }

  
            public EsiMetaType()
            {
            }

            public int EsiMetaTypeId { get; set; }
            public string EsiMetaTypeName { get; set; }
            public int EsiMetaTypeState { get; set; }
            public string EsiMetaTypeDesc { get; set; }
            public int EsiMetaTypeOrder { get; set; }
            public string EsiMetaTypelabel { get; set; }
        }


        public partial class ViewCate
        {
            public decimal CateID { get; set; }
            public string CateName { get; set; }
            public string CateLabel { get; set; }
            public int CateState { get; set; }
            public int CateOrder { get; set; }
            public Nullable<decimal> CateParent { get; set; }
            public string CateDesc { get; set; }
            public string CateTname { get; set; }
        }



        public partial class ViewItem
        {
            public decimal EsiObjId { get; set; }
            public decimal CateID { get; set; }
            public string EsiStrVal { get; set; }
            public decimal EsiFieldId { get; set; }
        }


        public partial class ViewMeta
        {
            public int EsiMetaTypeId { get; set; }
            public string EsiMetaTypeName { get; set; }
            public int EsiMetaTypeState { get; set; }
            public string EsiMetaTypeDesc { get; set; }
            public int EsiMetaTypeOrder { get; set; }
            public string EsiMetaTypelabel { get; set; }
        }

        public partial class ViewField
        {
            public decimal FieldID { get; set; }
            public decimal FieldCateID { get; set; }
            public string FieldLabel { get; set; }
            public int FieldOrder { get; set; }
            public int FieldAutoDescState { get; set; }
            public string FieldPerfix { get; set; }
            public string FieldPostfix { get; set; }
            public Nullable<int> FieldType { get; set; }
            public int FieldHis { get; set; }
            public int FieldAllowNull { get; set; }
            public int FieldState { get; set; }
            public string FieldDesc { get; set; }
            public Nullable<int> FieldSize { get; set; }
        }

        public partial class ViewBig
        {
            public decimal EsiBigDataId { get; set; }
            public byte[] EsiBigDataValue { get; set; }
        }

        //public virtual DbSet<EsiBigData> EsiBigDatas { get; set; }
        //public virtual DbSet<EsiToCategory> EsiCategories { get; set; }
        //public virtual DbSet<EsiField> EsiFields { get; set; }
        //public virtual DbSet<EsiItem> EsiItems { get; set; }
        //public virtual DbSet<EsiMetaType> EsiMetaTypes { get; set; }
        //public virtual DbSet<ViewCate> ViewCates { get; set; }
        //public virtual DbSet<ViewItem> ViewItems { get; set; }
        //public virtual DbSet<ViewBig> ViewBigs { get; set; }
        //public virtual DbSet<ViewField> ViewFields { get; set; }
        //public virtual DbSet<ViewMeta> ViewMetas { get; set; }



        #endregion






    }
}
