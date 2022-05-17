using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentTable
{
    public class DbContextClass:DbContext
    {
        private string _connectionString;
        private string _assembleName;
        public virtual DbSet<StudentInfo> Students { get; set; }
        public DbContextClass()
        {
            _connectionString = "Server=DESKTOP-UAD9J96\\SQLEXPRESS;Database=GrpcStudentTable;User Id=grpcStudentTable;Password=123456;";
            _assembleName = Assembly.GetExecutingAssembly().FullName;
            Console.WriteLine(_assembleName);
        }
    }
}
