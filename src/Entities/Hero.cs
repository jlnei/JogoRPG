using System.Threading;

namespace JogoRPG.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = Level * 50;
            this.MP = 0;
        }
        public string Name;
        public int Level;
        public int HP;
        public int MP;
        public string HeroType;

        public override string ToString()
        {
            return this.Name + "  \t\tClass " + this.HeroType + "\tLevel " + this.Level;
        }

        public virtual string Attack()
        {
            return this.Name + " ataca com sua espada";
        }
        public virtual string Attack(int opcao)
        {
            return this.Name + " ataca com sua magia";
        }    

        static int Dice()
        {
            Random randNum = new Random();
            return randNum.Next(1,6);
        }  

        public static void BattleNow()
        {
            Knight arus = new Knight ("Arus", 2, "Knight");
            Wizard telly = new Wizard ("Telly", 3, "Wizard");
            Paladin wolly = new Paladin ("Wolly", 3, "Paladin");
            Ninja lee = new Ninja ("Lee", 3, "Ninja");
            Thief loue = new Thief ("Loue", 2, "Thief");

            Console.WriteLine("\nGuerreiros do Jogo:\n");
            Console.WriteLine("1- " + arus);
            Console.WriteLine("2- " + telly);
            Console.WriteLine("3- " + wolly);
            Console.WriteLine("4- " + lee);
            Console.WriteLine("5- " + loue);
            Console.WriteLine("\nEscolha o primeiro personagem para a batalha: ");
            var opcao1 = Console.ReadLine();
            Console.WriteLine("Escolha o segundo personagem para a batalha: ");
            var opcao2 = Console.ReadLine();

            Hero warrior1 = arus;
            Hero warrior2 = telly;
            switch(opcao1)
            {
                case "1":
                    warrior1 = arus;
                break;
                case "2":
                    warrior1 = telly;
                break;           
                case "3":
                    warrior1 = wolly;
                break;   
                case "4":
                    warrior1 = lee;
                break;           
                case "5":
                    warrior1 = loue;
                break;   
            }
            switch(opcao2)
            {
                case "1":
                    warrior2 = arus;
                break;
                case "2":
                    warrior2 = telly;
                break;           
                case "3":
                    warrior2 = wolly;
                break;   
                case "4":
                    warrior2 = lee;
                break;           
                case "5":
                    warrior2 = loue;
                break;                
            }    

            Console.WriteLine("\nComeça a batalha entre {0} vs {1}!\n", warrior1.Name, warrior2.Name);
            int ataque;

            while (true)
            {
                Thread.Sleep(1200);
                var oneAttack = Dice();
                var twoDefend = Dice();
                if(oneAttack > twoDefend)
                {
                    ataque = oneAttack % 2;
                    Console.WriteLine(warrior1.Attack(ataque));
                    Thread.Sleep(1000);
                    if(ataque != 1 & warrior1.MP > 0)
                    {
                        warrior2.HP = warrior2.HP - 30;
                        Console.WriteLine("Dano de -30");
                    }
                    else
                    {
                        warrior2.HP = warrior2.HP - 20;
                        Console.WriteLine("Dano de -20");
                    }
                    if(warrior2.HP < 1)
                    {
                        Thread.Sleep(900);
                        Console.WriteLine("\n{0} vence a batalha!", warrior1.Name);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("{0} defende o ataque!", warrior2.Name);
                }
                Thread.Sleep(1200);
                var twoAttack = Dice();
                var oneDefend = Dice();
                if(twoAttack > oneDefend)
                {
                    ataque = twoAttack % 2;
                    Console.WriteLine(warrior2.Attack(ataque));
                    Thread.Sleep(1000);
                    if(ataque != 1 & warrior2.MP > 0)
                    {
                        warrior1.HP = warrior1.HP - 30;
                        Console.WriteLine("Dano de -30");
                    }
                    else
                    {
                        warrior1.HP = warrior1.HP - 20;
                        Console.WriteLine("Dano de -20");
                    }
                    if(warrior1.HP < 1)
                    {
                        Thread.Sleep(900);
                        Console.WriteLine("\n{0} vence a batalha!", warrior2.Name);
                        break;
                    }
                } 
                else
                {
                    Console.WriteLine("{0} defende o ataque!", warrior1.Name);
                }               
            }
        }      
    }
}