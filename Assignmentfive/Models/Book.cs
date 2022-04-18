//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignmentfive.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web;

    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.OrderSummaries = new HashSet<OrderSummary>();
        }
    
        public int BookID { get; set; }
        public string B_Name { get; set; }
        public string Author { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string B_Image { get; set; }
        public Nullable<int> Cat_ID { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderSummary> OrderSummaries { get; set; }

        public HttpPostedFileBase ImageFile { get; set; }
    }
}
