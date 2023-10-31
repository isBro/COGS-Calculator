using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COGS_Calculator.Model
{
    public class User
    {
        public string UserName { get; set; }
        public int UserID { get; set; }

        private string UserPassword { get; set; }

        public int Active { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime UpdatedDated { get; set; }

        public string UpdatedBy { get; set; }

        public string GetPassword()
        {
            return UserPassword;
        }

        public bool IsActive(int Active)
        {
            if (Active == 1)
            {
                return true;
            }

            return false;
        }
    }
}
