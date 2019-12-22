using AcceptedAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcceptedAssignment.Litedb
{
    public interface IAssignmentService
    {
        IEnumerable<Book> GetAll();
        Book GetById(int id);
        int Insert(Book book);
        bool Updatedb(Book book);
    }
}
