//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManagerDL.EntityDataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_PROJ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_PROJ()
        {
            this.T_TASK = new HashSet<T_TASK>();
        }
    
        public int PROJ_ID { get; set; }
        public string PROJ_NM { get; set; }
        public Nullable<System.DateTime> PROJ_STRT_DT { get; set; }
        public Nullable<System.DateTime> PROJ_END_DT { get; set; }
        public int PROJ_PRIORITY { get; set; }
        public int PROJ_MGR_ID { get; set; }
    
        public virtual T_USR T_USR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TASK> T_TASK { get; set; }
    }
}