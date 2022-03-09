namespace JogoRPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }
        public override string Attack(int opcao) //armas 
        {
            if(opcao == 1)
                return this.Name + " ataca com sua espada!";
            else
                return this.Name + " ataca com sua adaga!";
        }   
    }
}