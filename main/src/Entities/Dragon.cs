namespace RPG.src.Entities
{
    public class Dragon : Monster
    {
        public Dragon(string Name, int Level, string HeroType, int Life, int MagicPoint) : base(Name, Level, HeroType, Life, MagicPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
            this.MagicPoint = MagicPoint;
        }

        public override string Attack()
        {
            return this.Name + " Usou, Dragon Breath: Expiration ";
        }

        public string Attack(int Bonus)
        {
            if ( Bonus > 4)
            {
                return this.Name + " Usou magia super efetiva com bonus de ataque de " + Bonus + " " + "+";
            }else
            {
                return this.Name + " Usou magia ineficiente, bonus de ataque de " + Bonus + " " + "+";
            }
        }
    }
}