namespace RPG.src.Entities
{
    public class Myrmidon : Monster
    {
        public Myrmidon(string Name, int Level, string HeroType, int Life, int MagicPoint) : base(Name, Level, HeroType, Life, MagicPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
            this.MagicPoint = MagicPoint;
        }

        public override string Attack()
        {
            return this.Name + " Atacou usando Levin Sword";
        }
        public string Attack(int Bonus)
        {
            if ( Bonus > 3)
            {
                return this.Name + " Ataque superefetivo, ativou Locktouch, bonus de " + Bonus + " " + "+";
            }else
            {
                return this.Name + " Ataque ineficiente, bonus de " + Bonus + " " + "+";
            }
        }
    }
}