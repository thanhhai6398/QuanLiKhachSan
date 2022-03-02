using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHotel
{
    public static class Global
    {

        public static string GlobalUserId;

        public static string GetGlobalUserId()
        {
            return GlobalUserId;
        }
        public static void SetGlobalUserId(string user)
        {
            GlobalUserId = user;
        }
    }
}
