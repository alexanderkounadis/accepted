using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcceptedAssignment.Models
{
    public class Book
    {
        [BsonId]
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public float Price{ get; set; }
        public string Author { get; set; }
        public string Summary { get; set; }
    }
}
