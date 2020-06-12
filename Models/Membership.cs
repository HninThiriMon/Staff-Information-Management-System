using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StaffInformationManagementSystem.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string User { get; set; }

        public string Password { get; set; }
        public string UserName { get; internal set; }

        internal object FirstOrDefault(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}