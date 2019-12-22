using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcceptedAssignment.Models;
using LiteDB;

namespace AcceptedAssignment.Litedb
{
    public class AssignmentService : IAssignmentService
    {
        private LiteDatabase _liteDb;
        public AssignmentService(ILiteDbContext ctx)
        {
            _liteDb = ctx.Database;
        }
        public IEnumerable<Book> GetAll()
        {
            return _liteDb.GetCollection<Book>("Api").FindAll();
        }

        public Book GetById(int Id)
        {
            return _liteDb.GetCollection<Book>("Api").Find(b => b.Id == Id).FirstOrDefault();
        }

        public int Insert(Book book)
        {
            return _liteDb.GetCollection<Book>("Api")
                .Insert(book);
        }

        public bool Updatedb(Book book)
        {
            return _liteDb.GetCollection<Book>("Api")
                .Update(book);
        }
    }
}
