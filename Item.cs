using lessonAssubly;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lessonAssubly {

    internal class Item {

        private int _Id;

        public int Id {
            get { return _Id; }
            private set { _Id = value; }
        }

        public string Name { get; set; }
        public int Price { get; set; }

        public Item(int id) {
            _Id = id;
        }
    }


    internal class Drink : Item {

        private string _LiquidColor;
        public string LiquidColor {
            get { return _LiquidColor; }
            private set { _LiquidColor = value; }
        }
        
        public Drink(int id, string liquidColor) :base(id) {

            LiquidColor = liquidColor; ;
        }
    }

    internal class Food: Item {
        private int _Weight;
        public int Weight {
            get { return _Weight; }
            private set { _Weight = value; }
        }

        public Food(int id, int weight):base(id) { 
            Weight = weight;
        }
    }

    internal class Runner {

        public Runner() {

        }

        private Item[] arrItem = new Item[2];
        public void Run() {
            arrItem[0] = new Drink(1, "black");
            arrItem[0].Name = "Coca-Cola";
            arrItem[0].Price = 13;
            arrItem[1] = new Food(2, 10);
            arrItem[1].Name = "Sprite";
            arrItem[1].Price = 11;
        }

        private Item[] arrItem2 = new Item[10];
        Item[] arr2 = new Item[10];
        public void Run_10Item()
        {
            arrItem[0] = new Drink(1, "black");
            arrItem[0].Name = "Coca-Cola";
            arrItem[0].Price = 13;
            arrItem[1] = new Food(2, 10);
            arrItem[1].Name = "Sprite";
            arrItem[1].Price = 11;
        
            for (int i = 0; i< 10; i++)
            {
                if(i<5)
                {
                    Console.WriteLine("please enter id");
                    string temp = Console.ReadLine();
                    int result = int.Parse(temp);
                    Console.WriteLine("please enter a LiquidColor");
                    arr2[i] = new Drink(result, Console.ReadLine());
                    arr2[i].Name=Console.ReadLine();    
                    arr2[i].Price = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("please enter id");
                    string temp = Console.ReadLine();
                    int result = int.Parse(temp);
                    Console.WriteLine("please enter a Weight");
                    arr2[i] = new Food(result, int.Parse(Console.ReadLine()));
                    arr2[i].Name = Console.ReadLine();
                    arr2[i].Price = int.Parse(Console.ReadLine());
                }
                
            }




        }

        public void print()
        {
           for (int i = 0; i < 10; i++)
           {
             Console.WriteLine(arr2[i].Name);
             Console.WriteLine(arr2[i].Id);
           }
        }


         public void item100()
         {
             Item[] arr3 = new Item[100];
         
             Random rand = new Random(DateTime.Now.Millisecond);
             for (int i = 0; i < 10; i++)
             {
                 if (rand.Next(2) == 1)
                 {
                     Console.WriteLine("please enter id");
                     string temp = Console.ReadLine();
                     int result = int.Parse(temp);
                     Console.WriteLine("please enter a LiquidColor");
                     arr3[i] = new Drink(result, Console.ReadLine());
                     arr3[i].Name = Console.ReadLine();
                     arr3[i].Price = int.Parse(Console.ReadLine());
                 }
                 else
                 {
                     Console.WriteLine("please enter id");
                     string temp = Console.ReadLine();
                     int result = int.Parse(temp);
                     Console.WriteLine("please enter a Weight");
                     arr3[i] = new Food(result, int.Parse(Console.ReadLine()));
                     arr3[i].Name = Console.ReadLine();
                     arr3[i].Price = int.Parse(Console.ReadLine());
                 }
             }
         
             for (int i = 0; i < 100; i++)
             {
         
                 if (arr3[i] is Drink)
                 {
                     Drink banana = (Drink)arr3[i];
                     Console.WriteLine(banana.Name);
                     Console.WriteLine(banana.Id);
                     Console.WriteLine(banana.Price);
                     Console.WriteLine(banana.LiquidColor);
                 }
                 else if (arr3[i] is Food)
                 {
                     Food burger = (Food)arr3[i];
                     Console.WriteLine(burger.Name);
                     Console.WriteLine(burger.Id);
                     Console.WriteLine(burger.Price);
                     Console.WriteLine(burger.Weight);
                 }
             }
         }
    }
             
}





