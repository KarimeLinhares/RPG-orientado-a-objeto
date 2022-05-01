namespace RPG.src.Entities
{
    public class DarkKnight : Monster
    {
        public DarkKnight(string Name, int Level, string HeroType, int Life, int MagicPoint) : base(Name, Level, HeroType, Life, MagicPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
            this.MagicPoint = MagicPoint;
        }

        public override string Attack()
        {
            return this.Name + " Atacou usando Goetia";
        }
        public string Attack(int Bonus)
        {
            if ( Bonus > 4)
            {
                return this.Name + " Ataque superefetivo, ativou Shadowgift, bonus de " + Bonus + " " + "+";
            }else
            {
                return this.Name + " Ataque ineficiente, bonus de " + Bonus + " " + "+";
            }
        }
    }
}