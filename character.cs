using System;
namespace character
{
    class Character
    {
        string name="";
        int hp=0
        int mp=0
        public Character(string name,int hp,int mp)//magic array needs to be created here when ,agic is made
        {
            this.name=name
            this.hp=hp
            this.mp=mp
        }

    }
    class Player: Character
    {
        //weapon object
        //armour object
        public Player(string name,string hp, string mp)//magic
        {
            :base(name,hp,mp)



        }
    }
}