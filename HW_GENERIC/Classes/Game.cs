using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_GENERIC.Classes
{
    /*Класс Game формирует и обеспечивает: 
a.	Список игроков (минимум 2);
b.	Колоду карт (36 карт); 
c.	Перетасовку карт (случайным образом); 
d.	Раздачу карт игрокам (равными частями каждому игроку); 
e.	Игровой процесс. Принцип: 
Игроки кладут по одной карте. У кого карта больше, то тот игрок забирает все карты и кладет их в конец своей колоды. 
Упрощение: при совпадении карт забирает первый игрок, шестерка не забирает туза. Выигрывает игрок, который забрал все карты.
*/

    public class Game
    {
        public Game() { }
        Generator generator = new Generator();
        // Random rand = new Random();
        // int countPlayers = 0;

        /*a.Список игроков (минимум 2);*/
        public List<Player> gamers = Generator.CreateGamers();

        //foreach (Player item in gamers)
        //   Console.WriteLine("\t\t"+item.Name);

        int i = 1;
        /*b.Колоду карт (36 карт); */

        List<Karta> koloda = Generator.GetColoda();
        //  foreach (Karta item in koloda)
        //  Console.WriteLine("\t\t" + i + " " + item.Type_card + " " + item.Suit_card); i++;

    

        /*c.Перетасовку карт (случайным образом); */
        public void Mix()
        {
          Console.WriteLine("\n\t\tТусуем колоду!");
          //  koloda = null;
            koloda = Generator.MixColoda();
            //foreach (Karta item in koloda)
            //{
            //    Console.WriteLine("\t\t" + " " + item.Type_card + " " + item.Suit_card); 
            //}
            //Console.Read();
        }
        
        /*d.Раздачу карт игрокам (равными частями каждому игроку);*/
        public void Razdacha()
        {
            int index = gamers.Count; //Количество игроков
            int a = koloda.Count / index; //Количество карт на каждого
            int b = a;

            while (index > 0)
            {
                while (a > 0)
                {
                    gamers[index - 1].kartas.Add(koloda[a - 1]);
                    a--;
                }

                index--;
            }

            while (index > 0)
            {
                Console.WriteLine(gamers[index - 1].Name);
                 //   gamers[index - 1].kartas.Add(koloda[a - 1]);
                 //   a--;
             

                index--;
            }


            Console.WriteLine("Раздали карты!");
            //раздача карт

            //foreach (Player item in gamers)
            //{
            //    Console.WriteLine(item.Name);
            //    foreach (Karta item2 in item.kartas)
            //    {
            //        Console.WriteLine(item2.Type_card + " " + item2.Suit_card);
            //    }

            //}


        }





    }
}


