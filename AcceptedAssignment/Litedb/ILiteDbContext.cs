using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcceptedAssignment.Litedb
{
    public interface ILiteDbContext
    {
        LiteDatabase Database { get; }
    }
}
