namespace FiFaDio.Models
{
    public class Hero
    {
        public int Lvl;
        public string Name;
        public string HeroType;
        public int maxHP,HP,maxMP,MP;
        
        public Hero()
        {
            
        }

        public virtual string Attack(){
            return $"{this.Name} atacou com a espada";
        }
    }
}