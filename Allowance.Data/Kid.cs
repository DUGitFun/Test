//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Allowance.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kid
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kid()
        {
            this.Chores1 = new HashSet<Chore>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Chores { get; set; }
        public string Gender { get; set; }
        public Nullable<int> AllowanceTotal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chore> Chores1 { get; set; }
    }
}
