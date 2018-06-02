using HW_GENERIC.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Тема: Введение в Generics.
Программа «Карточная игра!»
Создать модель карточной игры.
*/
namespace HW_GENERIC
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Требования: Класс Game, Класс Player, Класс Karta  */

            // Generator g = new Generator();
            // g.createKarta();
            //g.GetColoda();
            //g.PrintColoda();
            Game game = new Game();
            //game.Mix();
            game.gamers = new List<Player>();
            //game.Razdacha();

        }
    }
}
