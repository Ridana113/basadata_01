using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace basedata_01
{
    class Program
    {
        static void Main(string[] args)
        {
            using(UserContext db = new UserContext())
            {
                var users = db.Users;
                Console.WriteLine("Список людей");
                foreach(User u in users)
                {
                    Console.WriteLine("{0}.{1} - {2}", u.Id, u.Name, u.Age);
                }
            }
            Console.Read();
        }
    }
    public class UserContext : DbContext
    {
        public UserContext() :
                base("UserDB")
        {

        }
        public DbSet<User> Users { get; set; }
    }
    
    public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }


