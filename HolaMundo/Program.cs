using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User();
            user1.FirstName = "Juan";
            user1.LastName = "Gutierrez";
            user1.Email = "kiritos12_14@hotmail.com";

            Console.WriteLine("Usuario: " + user1.FullName);
            Console.Read();

            var user2 = new User
            {
                FirstName = "Ofelia",
                LastName = "La del abarrote",
                Email = "ofelia@abarrote.santa.fe",
                Name = "ofelia",
                Password = "123"
            };
            Console.WriteLine("Usuario: " + user2.FullName);
                Console.Read());
        }
    }
}
