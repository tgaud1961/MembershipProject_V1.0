using System.Collections.Generic;
using MembershipProject_V1._0.Models;

namespace MembershipProject_V1._0.Comparers
{
    public class ThumbnailEqualityComparer : IEqualityComparer<ThumbnailModel>
    {
        public bool Equals(ThumbnailModel thumb1, ThumbnailModel thumb2)
        {
            return thumb1.ProductId.Equals(thumb2.ProductId);
        }

        public int GetHashCode(ThumbnailModel thumb)
        {
            return thumb.ProductId;
        }
    }
}