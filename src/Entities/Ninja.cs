namespace JogoRPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }
        public override string Attack(int opcao)  
        {
            if(opcao == 1)
                return this.Name + " ataca com sua shuriken!";
            else
                return this.Name + " ataca com o chute tornado!";
        }                    
    }
}