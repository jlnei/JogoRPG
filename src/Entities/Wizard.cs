namespace JogoRPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.MP = Level * 30;
        }
        public override string Attack(int opcao) //magia
        {
            if(opcao == 1)
                return this.Name + " ataca com sua magia de fogo!";
            else
                return this.Name + " ataca com sua magia de raio!";
        }
    }
}