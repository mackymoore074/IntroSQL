using Dapper;
using System.Data;

namespace IntroSQL
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly IDbConnection _conn;

        public DepartmentRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public void CreateDepartment(string name)
        {
            _conn.Execute("INSERT INTO departments Name Values(@name);", new { name = name });
        }

        public void UpdateDepartment(int id, string newName)
        {
            _conn.Execute("UPDATE departments SET Name = @newName WHERE DepartmentID = @id;", new { newName = newName, id = id });
        }

        public IEnumerable<Department> GetDepartment()
        {
            return _conn.Query<Department>("Select * FROM departments;");
        }


    }

}
