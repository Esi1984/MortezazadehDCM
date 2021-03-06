//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MortezazadehDCM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EsiField
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EsiField()
        {
            this.EsiItems = new HashSet<EsiItem>();
        }
    
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
        public Nullable<decimal> FieldLink { get; set; }
    
        public virtual EsiCategory EsiCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EsiItem> EsiItems { get; set; }
        public virtual EsiMetaType EsiMetaType { get; set; }
    }
}
