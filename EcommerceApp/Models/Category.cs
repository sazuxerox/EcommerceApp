using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EcommerceApp.Models
{
    public class Category
    {
        //Setting the primary key for the category table.
        [Key]
        public int Id { get; set; }

        //validation summary for Category Name
        [Required(ErrorMessage = "Category name is required")]
        [StringLength(100)]
        [MinLength(4, ErrorMessage = "Category must be four characters in length")]
        public string Name { get; set; }

        //setting the datetime privately for category addition, edit or update. 
        private DateTime? _createdDate;

        [DataType(DataType.DateTime)]
        public DateTime CreatedDate
        {
            get { return _createdDate ?? DateTime.UtcNow; }
            set { _createdDate = value; }
        }

        /// <summary>
        /// Mapping the one to many relationship with product table
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }


    }
}