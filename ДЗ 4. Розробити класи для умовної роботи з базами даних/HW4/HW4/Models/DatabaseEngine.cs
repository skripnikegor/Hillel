using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Models
{
    public class DatabaseEngine<T>
    {
        public string Password { get; set; }
        public void WriteValue(T value, string password)
        {
            DatabaseValue db1 = new DatabaseValue();
            db1.Value = value;
            db1.TableName = "Bobobo";
            db1.ToString();
        }

        public DatabaseEngine(string password)
        {
            this.Password = password;
        }



        public class DatabaseValue
        {
            public T Value { get; set; }
            public string TableName { get; set; }

            public DatabaseValue()
            {

            }
            public override string ToString()
            {
                Console.WriteLine($"{Value} {TableName}");
                return $"{Value} {TableName}";
            }
        }
    }
}
