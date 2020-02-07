using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{




    public class Tiles
    {
        public string brand = "Пол";
        public double size_h = 200;
        public double size_w = 200;
        public int price = 7000;

        public Tiles()
        {

        }
        public Tiles(double size_h)
        {

            this.size_h = size_h;
            
        }
                                    
      
        public Tiles(string brand)
        {
            this.brand = brand;
            
        }
        public Tiles(int price)
        {
            
            this.price = price;
        }

        public void GetData()
        {
            Console.WriteLine($"Бренд: {brand}, Высота: {size_h}, Ширина: {size_w}, Цена: {price}");
        }

    }



    class Program
    {

        static void Main(string[] args)
        {

            Tiles type1 = new Tiles();
            type1.GetData();

            Tiles type2 = new Tiles();
            

            Console.ReadKey();
        }


    }

}

















// public class Animal
    // {
    //  public string type = "Млекопитающие";
    //  public string breed = "Британская";
    // public string color = "gray";
    // public int agression = 30;


    //  public Animal(string type, string breed, string color, int agression)
    //  {
    //      this.type = type;
    //      this.breed = breed;
    //      this.color = color;
    //      this.agression = agression;
    //  }
    // public Animal(string type, string breed, string color)
    // {
    //  this.type = type;
    //   this.breed = breed;
    //   this.color = color;

    // }


    // public Animal()
    // {

    // }

    // public Animal(string type, string breed)
    // {
    //     this.type = type;
    //     this.breed = breed;
    // }

    // public  void MyInfo()
    //{
    //  Console.WriteLine($"Тип: {type}, Порода: {breed}, Цвет: {color}, Агрессия:{agression}");
    // }



        // Animal cat = new Animal();
         //  cat.breed = "Мейнкун";
         //  cat.agression = 0;
         //  cat.color = "обычно желтоватый - коричневый";
         // cat.MyInfo();

         //  Animal dog = new Animal();
         // dog.breed = "Немецкая овчарка";
         // dog.agression = 100;
         //  dog.MyInfo();

         // Animal mouse = new Animal("Мыш", "Летучая");
         //  mouse.MyInfo();

         // Animal rat = new Animal("Крыса", "Болотная", "серый");
         //rat.MyInfo();