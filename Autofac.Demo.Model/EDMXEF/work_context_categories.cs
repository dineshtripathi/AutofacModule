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
    
    public partial class work_context_categories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public work_context_categories()
        {
            this.work_context = new HashSet<work_context>();
        }
    
        public string element_id { get; set; }
        public string scale_id { get; set; }
        public decimal category { get; set; }
        public string category_description { get; set; }
    
        public virtual content_model_reference content_model_reference { get; set; }
        public virtual scales_reference scales_reference { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<work_context> work_context { get; set; }
    }
}
