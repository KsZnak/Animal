using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{

    public class Program
    {
        public static void Main()

        {
            Bears Teddy = new Bears();
            Teddy.name = "Teddy";
            Teddy.age = 8;
            Teddy.color = "Коричневый";
            Teddy.weight = 30;
            string messagebear = "Имя " + Teddy.name + " Возраст " + Teddy.age + "Лет" + " Вес " + Teddy.weight + " кг ";
            Console.WriteLine(messagebear);
            Teddy.eat(" рыба и мёд");
            Teddy.slip(" всю зиму");
            Teddy.howl(" шерсть");
            Teddy.fedmilk();
           
            
            

            Wolf Seryi = new Wolf();
            Seryi.name = " Серый ";
            Seryi.age = 7;
            Seryi.color = " Серый ";
            Seryi.weight = 11;
            string messagewolf = "Имя " + Seryi.name + " Возраст " + Seryi.age + "Лет" + " Вес " + Seryi.weight + " кг ";
            Console.WriteLine(messagewolf);
            Seryi.eat(" Мясо ");
            Seryi.slip(" Как все обычные волки ");
            Seryi.howl(" Шерсть ");
            Console.ReadKey();
        }
    }
    class Animals
    {
        public string color { get; set; }
        public int weight { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string meal { get; set; }

        public void eat(string meal)
        {
            Console.WriteLine("Питается: " + meal);
        }

        public void slip(string slept)
        {
            Console.WriteLine("Спит: " + slept);
    }

    }

    class Memmals : Animals
    {
        
        bool woll;

        public void howl(string howl) {
            Console.WriteLine("Есть: " + howl);
        }

        public void fedmilk() { }
            
        
    }

    class Birds : Animals
        
    {
        public virtual  void  havefeathers(){}

        public virtual void fly() { }


    }

    class Bears : Memmals
    {
        
        
       
    }

    class Wolf : Memmals
    {

    }

    



}
