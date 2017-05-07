using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MembershipProject_V1._0.Models
{
    public class ProductSectionModel
    {
        public string Title { get; set; }

        public List<ProductSection> Sections { get; set; }
    }
}