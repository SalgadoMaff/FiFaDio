namespace FiFaDio.Models
{
    public class Knight: Hero
    {
        public Knight(string nombre, int lvl, string heroType,int hp, int mp)
        {
            this.Lvl=lvl;
            this.Name=nombre;
            this.HeroType=heroType;
            this.maxHP=hp;
            this.maxMP=mp;
            this.HP=this.maxHP;
            this.MP=this.maxMP;
        }
    }
}