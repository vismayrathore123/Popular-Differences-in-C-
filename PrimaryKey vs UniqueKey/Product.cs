using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryKey_vs_UniqueKey
{
    public class Product
    {
       
        
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Category { get; set; }
    }

}
