namespace JogoRPG.src.Entities
{
    public class Thief : Hero
    {
        public Thief(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }
        public override string Attack(int opcao) //armas
        {
            if(opcao == 1)
                return this.Name + " ataca com sua flecha!";
            else
                return this.Name + " ataca com um golpe furtivo!";
        }          
    }
}