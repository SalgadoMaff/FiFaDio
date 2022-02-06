namespace FiFaDio.Models
{
    public class Ninja:Hero
    {
        public Ninja(string nombre, int lvl, string heroType,int hp, int mp)
        {
            this.Lvl=lvl;
            this.Name=nombre;
            this.HeroType=heroType;
            this.maxHP=hp;
            this.maxMP=mp;
            this.HP=this.maxHP;
            this.MP=this.maxMP;
        }
        public override string Attack(){
            return $"{this.Name} atacou com a adaga";
        }
        
    }
}