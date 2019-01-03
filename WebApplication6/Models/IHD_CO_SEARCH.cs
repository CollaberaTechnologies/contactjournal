//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class IHD_CO_SEARCH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IHD_CO_SEARCH()
        {
            this.IHD_CO_SEARCH_VIEW = new HashSet<IHD_CO_SEARCH_VIEW>();
        }
    
        public long Rid { get; set; }
        [RegularExpression(@"^[A-Za-z -]+$", ErrorMessage = "Enter only Alphabates")]
        public string FirstName { get; set; }
        [RegularExpression(@"^[A-Za-z -]+$", ErrorMessage = "Enter only Alphabates")]
        public string LastName { get; set; }
        [RegularExpression(@"^[0-9]{10,21}$",ErrorMessage ="Enter minimum 10 digit")]
        public Nullable<long> PhoneNo { get; set; }
        [RegularExpression(@"^((\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)\s*[;]{0,1}\s*)+$", ErrorMessage = "Enter valid email address")]
        public string EmailID { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MMM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> CallDate { get; set; }
        [Required]
        public string Comments { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IHD_CO_SEARCH_VIEW> IHD_CO_SEARCH_VIEW { get; set; }
    }
}
