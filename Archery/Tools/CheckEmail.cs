using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Archery.Data;
using Archery.Models;


namespace Archery.Tools
{
    public static class CheckEmail
    {
        public static bool CompareEmail(string email)
        {
            bool check = false;
            using (var Bd = new ArcheryDbContext())
            {
                foreach (var archer in Bd.Archers)
                {
                    if (email == archer.Mail)
                    {
                        check = true;
                    }
                }
                    
            }
            return check;
        }
    }
}