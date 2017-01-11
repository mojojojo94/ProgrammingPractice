using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        class Product
        {
            protected double price;
            protected string name;
        }
        class Product 1 : Product
        {
            private string name = "Car";
			
			private int tires = 4;
			
			private int engine = 1;
			
			public string color;
			
            public override void func()
            {
                base.price = 180000.00;
                base.name = "Ahmer Mobile";
            }
            public string myProductName()
            {
                return name;
            }
			
			public string setColor(string myCarColor)
			{
				color = myCarColor;
			}
			
			
			public printVariables()
			{
				Console.WriteLine("amount = ", amount);
				Console.WriteLine("companyName = ", companyName);
				Console.WriteLine("personName = ", personName);
				Console.WriteLine("productName = ", productName);
				
			}
            
        }
        class Product 2 : Product
        {
            private string name = "myPhone";
			
			private string osType = "myOS";
			
			private string hardDrive = "SS 500GB";
			
			private string ram = "3 GB";
			
			private int numOfCameras = 2;
			
			private string procesor = "A23";
			

            public override void func()
            {
                base.price = 1200.00;
                base.name = "Sherry Phone";
            }
            public string myProductName()
            {
                return name;
            }
			
			public printVariables()
			{
				Console.WriteLine("productName = ", productName);
				Console.WriteLine("companyName = ", companyName);
				Console.WriteLine("personName = ", personName);
				Console.WriteLine("productName = ", productName);
				Console.WriteLine("companyName = ", companyName);
				Console.WriteLine("personName = ", personName);
				
			}
        }
        class Orders
        {
            private int amount;
			private string companyName;
			private string personName;
			
			public double bill;
			
			
			public void int setAmount(int productAmount)
			{
				amount = productAmount;
			}
			
			public void string setCompanyName(string customerCompanyName)
			{
				companyName = customerCompanyName;
			}
			
			public void string setPersonName(string customerPersonName)
			{
				personName = customerPersonName;
			}
			
			public void double customerBill()
			{
				
				//bill = product * amount;
				
				
			}
            
			public printVariables()
			{
				Console.WriteLine("amount = ", amount);
				Console.WriteLine("companyName = ", companyName);
				Console.WriteLine("personName = ", personName);
			}
            /*public virtual void func()
            {
                speak = "The things I do for England.";
                health = 10;
            }
            public int damage(int d)
            {
                health -= d;
                return health;
            }
            public int Attack()
            {
                Random rng = new Random();
                return rng.Next(10);
            }
            public int rhealth()
            {
                return health;
            }
            public string rname()
            {
                return name;
            }
            public string call()
            {
                return speak;
            }*/
        }
        /*static void Main(string[] args)
        {
            Enemy1 e1 = new Enemy1();
            Enemy2 e2 = new Enemy2();
            e1.func();
            e2.func();
            Player p = new Player();
            p.func();
            Random rng = new Random();

            int phealth, e1health, e2health, attack;

            phealth = p.rhealth();
            e1health = e1.rhealth();
            e2health = e2.rhealth();

            while (phealth >= 0 && e1health >= 0)
            {
                Console.WriteLine(p.call());
                attack = rng.Next(10);
                e1health = e1.damage(attack);
                Console.WriteLine("{0} attacks {1} for {2} damage. {3} health remaining.", p.rname(), e1.rname(), attack, e1health);
                Console.WriteLine();
                if (e1health > 0)
                {
                    Console.WriteLine(e1.call());
                    attack = rng.Next(10);
                    phealth = p.damage(attack);
                    Console.WriteLine("{0} attacks {1} for {2} damage. {3} health remaining.", e1.rname(), p.rname(), attack, phealth);
                    Console.WriteLine();
                }
                if (phealth <= 0)
                {
                    Console.WriteLine("{0} Wins!", e1.rname());
                    Console.WriteLine();
                }
                if (e1health <= 0)
                {
                    Console.WriteLine("{0} Wins!", p.rname());
                    Console.WriteLine();
                }
            }
            while (phealth >= 0 && e2health >= 0)
            {
                Console.WriteLine(p.call());
                attack = rng.Next(10);
                e2health = e2.damage(attack);
                Console.WriteLine("{0} attacks {1} for {2} damage. {3} health remaining.", p.rname(), e2.rname(), attack, e2health);
                Console.WriteLine();
                if (e2health > 0)
                {
                    Console.WriteLine(e2.call());
                    attack = rng.Next(10);
                    phealth = p.damage(attack);
                    Console.WriteLine("{0} attacks {1} for {2} damage. {3} health remaining.", e2.rname(), p.rname(), attack, phealth);
                    Console.WriteLine();
                }
                if (phealth <= 0)
                {
                    Console.WriteLine("{0} Wins!", e2.rname());
                    Console.WriteLine();
                }
                if (e2health <= 0)
                {
                    Console.WriteLine("{0} Wins!", p.rname());
                    Console.WriteLine();*/
                }
            }
        }
    }
}