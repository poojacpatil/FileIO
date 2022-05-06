using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Book
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string AuthorName { get; set; }  
        public int Price { get; set; }
    }
}
