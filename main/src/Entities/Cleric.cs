namespace RPG.src.Entities
{
    public class Cleric : Hero
    {
        public Cleric(string Name, int Level, string HeroType, int Life, int MagicPoint) : base(Name, Level, HeroType, Life, MagicPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
            this.MagicPoint = MagicPoint;
        }

        public override string Attack()
        {
            return this.Name + " Usou Maná ";
        }

        public string Attack(int Bonus)
        {
            if ( Bonus > 3)
            {
                return this.Name + " Usou técnica super efetiva e recuperou a vida dos companheiros, com bonus de " + Bonus + " " + "+";
            }else
            {
                return this.Name + " Usou técnica ineficiente, bonus de " + Bonus + " " + "+";
            }
        }
    }
}