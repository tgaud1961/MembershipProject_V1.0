﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using MembershipProject_V1._0.Entities;

namespace MembershipProject_V1._0.Areas.Admin.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [MaxLength(255)]
        [Required]
        public string Title { get; set; }

        [MaxLength(2048)]
        public string Description { get; set; }

        [MaxLength(1024)]
        [DisplayName("Image Url")]
        public string ImageUrl { get; set; }

        public int ProductLinkTextId { get; set; }

        public int ProductTypeId { get; set; }
        [DisplayName("Product Link Text")]
        public ICollection<ProductLinkText> ProductLinkTexts { get; set; }
        [DisplayName("Product Type")]
        public ICollection<ProductType> ProductTypes { get; set; }

        public string ProductLinkText
        {
            get
            {
                return ProductLinkTexts == null || ProductLinkTexts.Count.Equals(0) ? string.Empty : ProductLinkTexts.First(pt => pt.Id.Equals(ProductLinkTextId)).Title;
            }
        }

        public string ProductType
        {
            get
            {
                return ProductTypes == null || ProductTypes.Count.Equals(0) ? string.Empty : ProductTypes.First(pt => pt.Id.Equals(ProductTypeId)).Title;
            }
        }
    }
}