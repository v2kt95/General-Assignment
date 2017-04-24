using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebAPI.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<int> Friends { get; set; } 
    }
}