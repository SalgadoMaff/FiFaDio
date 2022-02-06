using System.Collections;
namespace FiFaDio.Models
{
    public class Wizard : Hero
    {

        public override string Attack(){
            return $"{this.Name} atacou com o cajado";

        }
        public string Attack(int Bonus){
            if(Bonus>6){
                return $"{this.Name} lançou uma magia top com bonus de dano de: {Bonus}";
            }else{
                return $"{this.Name} lançou uma magia meh com bonus de dano de: {Bonus}";
            }
        }
        public Wizard(){}

        public Wizard(string nombre, int lvl, string heroType,int hp, int mp)
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