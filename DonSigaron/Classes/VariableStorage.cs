using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonSigaron.Classes
{
    internal class VariableStorage
    {
        public static string userName { get; set; }
        public static string tableName { get; set; }
        public static string productName { get; set; }
        public static int globalUserID { get; set; }
        public static int globalProductID { get; set; }
        public static int quantity { get; set; }
        public static int stockProduct { get; set;}
    }
}
