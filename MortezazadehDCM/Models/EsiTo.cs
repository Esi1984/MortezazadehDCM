using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortezazadehDCM.Models
{
    public class EsiTo
    {
    }

    public partial class EsiToBigData
    {
        public decimal EsiBigDataId { get; set; }
        public byte[] EsiBigDataValue { get; set; }
    }

    public  class EsiToCategory
    {

        //public EsiCategory()
        //{
        //    this.EsiFields = new HashSet<EsiField>();
        //}

        public decimal CateID { get; set; }
      //  public string CateName { get; set; }
        public string CateLabel { get; set; }
        //public int CateState { get; set; }
       // public int CateOrder { get; set; }
       // public Nullable<decimal> CateParent { get; set; }
        public string CateDesc { get; set; }
       // public string CateTname { get; set; }
        // public  ICollection<EsiToField> EsiFields { get; set; }
    }



    public class EsiToCateDetails
    {

        //public EsiCategory()
        //{
        //    this.EsiFields = new HashSet<EsiField>();
        //}

        public decimal CateID { get; set; }
        //  public string CateName { get; set; }
        public string CateLabel { get; set; }
        //public int CateState { get; set; }
        // public int CateOrder { get; set; }
        // public Nullable<decimal> CateParent { get; set; }
        public string CateDesc { get; set; }
        // public string CateTname { get; set; }
         public  ICollection<EsiToFieldDetails> EsiFields { get; set; }
    }


    public  class EsiToFieldDetails
    {
        public decimal FieldID { get; set; }
        public decimal FieldCateID { get; set; }
        public string FieldLabel { get; set; }
        public int FieldOrder { get; set; }
        public int FieldAutoDescState { get; set; }
        public string FieldPerfix { get; set; }
        public string FieldPostfix { get; set; }
        public int FieldType { get; set; }
        public int FieldHis { get; set; }
        public int FieldAllowNull { get; set; }
        public int FieldState { get; set; }
        public string FieldDesc { get; set; }
        public Nullable<int> FieldSize { get; set; }
        public EsiToCategory EsiCategory { get; set; }
       // public ICollection<EsiToItem> EsiItems { get; set; }
        public EsiToMetaType EsiMetaType { get; set; }
    }


    public class EsiToField
    {
            public decimal FieldID { get; set; }
            public decimal FieldCateID { get; set; }
            public string FieldLabel { get; set; }
            public int FieldOrder { get; set; }
            public int FieldAutoDescState { get; set; }
            public string FieldPerfix { get; set; }
            public string FieldPostfix { get; set; }
            public int FieldType { get; set; }
            public int FieldHis { get; set; }
            public int FieldAllowNull { get; set; }
            public int FieldState { get; set; }
            public string FieldDesc { get; set; }
            public Nullable<int> FieldSize { get; set; }
          //  public  EsiCategory EsiCategory { get; set; }
            //public  ICollection<EsiItem> EsiItems { get; set; }
            public  EsiToMetaType EsiMetaType { get; set; }
    }



    public  class EsiToItem
    {
        public decimal EsiObjId { get; set; }
        public decimal EsiFieldId { get; set; }
        public string EsiStrVal { get; set; }

      //  public  EsiToField EsiField { get; set; }
      //  public  EsiToProduct EsiProduct { get; set; }
    }



    public  class EsiToMetaType
    {
        public int EsiMetaTypeId { get; set; }
        public string EsiMetaTypelabel { get; set; }
    }


    public  class EsiToProduct
    {
        //public EsiProduct()
        //{
        //    this.EsiItems = new HashSet<EsiItem>();
        //}
        public decimal EsiProductId { get; set; }
        public  EsiToCategory EsiCategory { get; set; }
        public  ICollection<EsiToItem> EsiItems { get; set; }
    }



}