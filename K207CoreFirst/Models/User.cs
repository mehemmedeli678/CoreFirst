using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K207CoreFirst.Models  
{
    //SQL-siz databaza yaratmaq ve sql-de baza yaratmaq
    public class User
    {
        public int ID { get; set; }
        public string name { get; set; }
        public DateTime birthday   { get; set; }
        public string phonenumber { get; set; }
        public string email { get; set; }
        public string  password { get; set; }
    }
}
