//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestBlog.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_posts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_posts()
        {
            this.t_comment = new HashSet<t_comment>();
        }
    
        public int id { get; set; }
        public int userid { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string tags { get; set; }
        public int categoryId { get; set; }
        public string postContent { get; set; }
        public string date_time { get; set; }
        public bool is_active { get; set; }
    
        public virtual t_category t_category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_comment> t_comment { get; set; }
        public virtual t_user t_user { get; set; }
    }
}