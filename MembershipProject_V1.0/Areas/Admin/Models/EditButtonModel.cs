﻿using System;
using System.Text;

namespace MembershipProject_V1._0.Areas.Admin.Models
{
    public class EditButtonModel
    {
        public int ItemId { get; set; }

        public int ProductId { get; set; }

        public int SubscriptionId { get; set; }

        public string Link
        {
            get
            {
                var s = new StringBuilder("?");
                if (ItemId > 0) s.Append(String.Format("{0}={1}&", "itemId", ItemId));
                if (ProductId > 0) s.Append(String.Format("{0}={1}&", "productId", ProductId));
                if (SubscriptionId > 0) s.Append(String.Format("{0}={1}&", "subscriptionId", SubscriptionId));
                return s.ToString().Substring(0, s.Length - 1);
            }
        }
    }
}