using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee : Person
    {
        public int ID { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.ID == employee2.ID)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
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
