using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_GENERIC.Classes
{

    /* Класс Player (набор имеющихся карт, вывод имеющихся карт).*/
    public class Player
    {
        public string Name { get; set; }
        public List<Karta> kartas = new List<Karta>(); //набор имеющихся карт

        public void PrintKartas()
        {
            Console.WriteLine("\n\t" + Name);
            foreach (Karta item in kartas) //вывод имеющихся карт
            {
                Console.WriteLine("\t" + item.Type_card + " " + item.Suit_card);
            }
        }
    }
}
