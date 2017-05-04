﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MembershipProject_V1._0.Models;

namespace MembershipProject_V1._0.Comparers
{
    public class ProductSectionEqualityComparer : IEqualityComparer<ProductSection>
    {
        public bool Equals(ProductSection section1, ProductSection section2)
        {
            return section1.Id.Equals(section2.Id);
        }

        public int GetHashCode(ProductSection section)
        {
            return (section.Id).GetHashCode();
        }
    }
}