namespace RPG.src.Entities
{
    public class Sorcerer : Monster
    {
        public Sorcerer(string Name, int Level, string HeroType, int Life, int MagicPoint) : base(Name, Level, HeroType, Life, MagicPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
            this.MagicPoint = MagicPoint;
        }

        public override string Attack()
        {
            return this.Name + " Usou Grima's Truth";
        }

        public string Attack(int Bonus)
        {
            if ( Bonus > 4)
            {
                return this.Name + " Magia super efetiva, ativou Anathema, bonus de ataque de " + Bonus + " " + "+";
            }else
            {
                return this.Name + " Magia ineficiente, bonus de ataque de " + Bonus + " " + "+";
            }
        }
    }
}