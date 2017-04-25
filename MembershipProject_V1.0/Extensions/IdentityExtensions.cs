using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web;
using MembershipProject_V1._0.Models;

namespace MembershipProject_V1._0.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetUserFirstName(this IIdentity identity)
        {
            var db = ApplicationDbContext.Create();
            var user = db.Users.FirstOrDefault(u => u.UserName.Equals(identity.Name));

            return user != null ? user.FirstName : String.Empty;
        }

        public static async Task GetUsers(this List<UserViewModel> users)
        {
            var db = ApplicationDbContext.Create();
            users.AddRange(await (from u in db.Users select new UserViewModel { Id = u.Id, Email = u.Email, FirstName = u.FirstName, LastName = u.LastName }).OrderBy(o => o.Email).ToListAsync());
        }
    }
}