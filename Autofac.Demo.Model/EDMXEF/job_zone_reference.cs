//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Autofac.Demo.Model.EDMXEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class job_zone_reference
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public job_zone_reference()
        {
            this.job_zones = new HashSet<job_zones>();
        }
    
        public decimal job_zone { get; set; }
        public string name { get; set; }
        public string experience { get; set; }
        public string education { get; set; }
        public string job_training { get; set; }
        public string examples { get; set; }
        public string svp_range { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<job_zones> job_zones { get; set; }
    }
}