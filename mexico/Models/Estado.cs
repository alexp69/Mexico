using System;
namespace mexico.Models
{
    public class Estado
    {
        public int id { get; set; } 
        public string name { get; set; } 
        public string image { get { return "l" + id.ToString(); } }
    }
}
