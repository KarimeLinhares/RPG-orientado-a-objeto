namespace RPG.src.Entities
{
    public class GreatKnight : Hero
    {
        public GreatKnight(string Name, int Level, string HeroType, int Life, int MagicPoint) : base(Name, Level, HeroType, Life, MagicPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
            this.MagicPoint = MagicPoint;
        }

        public override string Attack()
        {
            return this.Name + " Atacou usando Silver Lance";
        }
        public string Attack(int Bonus)
        {
            if ( Bonus > 4)
            {
                return this.Name + " Ataque superefetivo, ativou Discipline, bonus de " + Bonus + " " + "+";
            }else
            {
                return this.Name + " Ataque ineficiente, bonus de " + Bonus + " " + "+";
            }
        }
    }
}