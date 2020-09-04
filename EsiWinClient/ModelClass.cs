using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsiWinClient
{
    public partial class ModelClass
    {
    }


    //public partial class EsiCategory
    //{
    //    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    //    public EsiCategory()
    //    {
    //        this.EsiFields = new HashSet<EsiField>();
    //    }

    //    public decimal CateID { get; set; }
    //    public string CateName { get; set; }
    //    public string CateLabel { get; set; }
    //    public int CateState { get; set; }
    //    public int CateOrder { get; set; }
    //    public Nullable<decimal> CateParent { get; set; }
    //    public string CateDesc { get; set; }
    //    public string CateTname { get; set; }

    //    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    //    public virtual ICollection<EsiField> EsiFields { get; set; }
    //}

    //public partial class EsiField
    //{
    //    public decimal FieldID { get; set; }
    //    public decimal FieldCateID { get; set; }
    //    public string FieldLabel { get; set; }
    //    public int FieldOrder { get; set; }
    //    public int FieldAutoDescState { get; set; }
    //    public string FieldPerfix { get; set; }
    //    public string FieldPostfix { get; set; }
    //    public int FieldType { get; set; }
    //    public int FieldHis { get; set; }
    //    public int FieldAllowNull { get; set; }
    //    public int FieldState { get; set; }
    //    public string FieldDesc { get; set; }
    //    public Nullable<int> FieldSize { get; set; }

    //    public virtual EsiCategory EsiCategory { get; set; }
    //    public virtual EsiMetaType EsiMetaType { get; set; }
    //}

    //public partial class EsiMetaType
    //{
    //    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    //    public EsiMetaType()
    //    {
    //        this.EsiFields = new HashSet<EsiField>();
    //    }

    //    public int EsiMetaTypeId { get; set; }
    //    public string EsiMetaTypeName { get; set; }
    //    public int EsiMetaTypeState { get; set; }
    //    public string EsiMetaTypeDesc { get; set; }
    //    public int EsiMetaTypeOrder { get; set; }
    //    public string EsiMetaTypelabel { get; set; }

    //    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    //    public virtual ICollection<EsiField> EsiFields { get; set; }
    //}
}
