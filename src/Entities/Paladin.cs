namespace JogoRPG.src.Entities
{
    public class Paladin : Hero
    {
        public Paladin(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.MP = Level * 20;
        }
        public override string Attack(int opcao)  
        {
            if(opcao == 1)
                return this.Name + " ataca com sua espada!";
            else
                return this.Name + " ataca com sua magia de espada de fogo!";
        }   
    }

}
