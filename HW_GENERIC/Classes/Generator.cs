using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_GENERIC.Classes
{
 
    public enum Suit {Буби = 1, Черви, Крести, Пики };
    public enum Type { шесть = 6, семь, восемь, девять, десять, Валет, Дама, Король, Туз };

    public class Generator
    {

        static Random rand = new Random();
        static List<Player> gamers = new List<Player>();
        static List<Karta> coloda = new List<Karta>();
        static int i = 0;
        static int countPlayers = 0;

        static public List<Player> CreateGamers()
        {
            for (int i = 0; i < rand.Next(2, 5); i++)
            {
                Player player = new Player();
                player.Name = "Player-" + (i + 1);
                countPlayers++;
                gamers.Add(player);
            }

            return gamers;
        }


        /*создаем карту*/
        static public Karta CreateKarta()
        {
                Karta karta = new Karta();
                karta.Type_card = ((Type)(rand.Next(6, 15))).ToString();
                karta.Suit_card = ((Suit)(rand.Next(1, 5))).ToString();
           return karta;
        }
              
       /*создаем колоду*/
       static public List<Karta> GetColoda()
        {
          do
            {
                Karta karta = CreateKarta();

                if (coloda.Count == 0)
                {
                    coloda.Add(karta);
                    i++;
                }
                else
                {                   
                      if (IsExist(coloda, karta))
                            GetColoda(); 
                        else
                        {
                            coloda.Add(karta);
                          i++;
                         }
                }
            } while (i < 36);
         return coloda;
        }

        /*распечатываем колоду*/
        public void PrintColoda()
        {
          int i = 1;
          
            foreach (Karta item in coloda)
            {
                Console.WriteLine(i + " " + item.Type_card + " " + item.Suit_card );
                i++;
            }
        }

        /*проверяем есть ли такая карта в колоде*/
        static public bool IsExist(List<Karta> karts, Karta karta)
        {
            foreach (Karta item in karts)
                if (item.Suit_card == karta.Suit_card && item.Type_card == karta.Type_card)
                    return true;
            return false;
        }

        /*Перемешиваем колоду*/
        static public List<Karta> MixColoda()
        {
         List<Karta> coloda1 = GetColoda();
               return coloda1;
        }


    }
}

//public enum TypeDevice { USB2, USB3 }
//public class Flash : Storage
//{
//    public Flash(string Model) : base("", Model)
//    {

//    }
//    public Flash() : this(0) { }
//    public Flash(int SpeedFlash) : this(SpeedFlash, 0) { }

//    public Flash(int SpeedFlash, double MemoryFlash) : base()
//    {
//        this.SpeedFlash = SpeedFlash;
//        this.MemoryFlash = MemoryFlash;
//    }

//    public int SpeedFlash { get; private set; }
//    public double MemoryFlash { get; set; }


//    private TypeDevice TypeDevice_;
//    public TypeDevice typeDevice
//    {
//        get { return TypeDevice_; }
//        set { if (TypeDevice.USB2 == value) SpeedFlash = 2000; else SpeedFlash = 3000; }
//    }


//    public override double getMemory()
//    {
//        return MemoryFlash;
//    }

//    public override void PrintInfo()
//    {
//        base.PrintInfo();  // Console.WriteLine("{0} ({1})", base.Name, base.Model);
//        Console.WriteLine("SpeedFlash = {0} \n MemoryFlash = {1} \n TypeDevice = {2}", SpeedFlash, MemoryFlash, typeDevice);

//    }
//    /*●	расчет времени необходимого для копирования;
//    public override void Copy()
//    {
//        int sum = (int)MemoryFlash / SpeedFlash;
//        for (int i = 0; i < sum; i++)
//        {
//            Console.WriteLine(".");
//            Thread.Sleep(500);
//        }
//    }