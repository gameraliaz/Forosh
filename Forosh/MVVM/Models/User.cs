using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forosh.MVVM.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string FullName 
        { 
            get
            {
                return FirstName+ " " + LastName;
            }
        }
        public DateTime LoginTime { get; set; }
    }
}
