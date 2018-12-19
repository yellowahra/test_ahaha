using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Notes { get; set; }
        public int EmployeeID { get; set; }
    }
}
