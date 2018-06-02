using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_GENERIC.Classes
{
    /*Класс Karta (масть и тип карты (6–10, валет, дама, король, туз).*/

    public class Karta
    {

        public string Suit_card { get; set; } //масть

        public string Type_card { get; set; } //тип карты (6–10, валет, дама, король, туз)
              
        public void PrintKarta()
        {
            Console.WriteLine(Type_card + " " + Suit_card);
        }
    }
}
