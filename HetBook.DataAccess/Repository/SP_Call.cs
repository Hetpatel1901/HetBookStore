using Dapper;
using HetBook.DataAccess.Repository.IRepository;
using HetBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HetBook.DataAccess.Repository
{
    public class SP_Call : ISP_Call
    {
        public SP_Call(ApplicationDbContext db)
        {
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Execute(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public T OneRecord<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public T Single<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }
    }
}
