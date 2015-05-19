using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EcommerceApp.Models
{
    public class Product
    {
        /// <summary>
        ///This class holds a constructor which contains a default value for a specified field and holds the validation 
        ///rules and definitions for the field which are known as attribute of the Product Entity.
        /// </summary>
        public Product()
        {
            Availability = 1;  //default value for Availability field.
        }

        //setting the Id value as primary key
        [Key]
        public int Id { get; set; }

        //Foreign key to map with category table
        public int CategoryId { get; set; }

        //validation summary for Title 
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(100)]
        [MinLength(4, ErrorMessage = "Prodcut should be minimum four characters in length")]
        [Display(Name = "Product Title")]
        public string Title { get; set; }

        //validation summary for Description
        [Required(ErrorMessage = "Description is required")]
        [StringLength(1000)]
        [MinLength(20, ErrorMessage = "Prodcut should be minimum 20 characters in length")]
        public string Description { get; set; }


        //Validation for Availability
        [Required(ErrorMessage = "Availability is required")]
        public int Availability { get; set; }

        // //validation summary price which is in decimal datatype
        [Required(ErrorMessage = "Price is required")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }

        //Setting the validation for image url
        [DataType(DataType.ImageUrl)]
        [Required(ErrorMessage = "Image is required")]
        public string Image { get; set; }

        //setting the created date of the record
        private DateTime? _createdDate;

        [DataType(DataType.DateTime)]
        public DateTime CreatedDate
        {
            get { return _createdDate ?? DateTime.UtcNow; }
            set { _createdDate = value; }
        }


        // Mapping the Many to one relationship with category table.

        public virtual Category Category { get; set; }
    }
}