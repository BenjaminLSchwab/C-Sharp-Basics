using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee<T> : Person
    {
        public int ID { get; set; }
        public List<T> Things { get; set; }

        public void ListThings()
        {
            foreach(T thing in Things)
            {
                Console.WriteLine(thing);
            }
        }

        public static bool operator ==(Employee<T> employee1, Employee<T> employee2)
        {
            if (employee1.ID == employee2.ID)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Employee<T> employee1, Employee<T> employee2)
        {
            if (employee1.ID != employee2.ID)
            {
                return true;
            }
            return false;
        }

    }


    //public static Game operator -(Game game, Player player)
    //{
    //    game.Players.Remove(player);
    //    return game;
    //}
}
