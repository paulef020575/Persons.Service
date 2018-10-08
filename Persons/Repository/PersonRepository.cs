using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Persons
{
    public class PersonRepository : IPersonRepository
    {
        private string _connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PROG\PERSONS.SERVICE\PERSONS\PERSONS.MDF;Integrated Security = True";
        
        private IDbConnection _db;

        public PersonRepository()
        {
            _db = new SqlConnection(_connectionString);
        }

        public Person Find(Guid id)
        {
            return
                _db.Query<Person>(Query.Select, new {Id = id})
                    .SingleOrDefault();
        }

        public void Insert(Person item)
        {
            _db.Execute(Query.Insert, new {id = item.Id, name = item.Name, birthday = item.Birthday});
        }
    }
}
