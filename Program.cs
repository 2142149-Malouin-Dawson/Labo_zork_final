/**

solution possible La tour de zork final

La tour de zork

16 novembre

Dawson Malouin
**/


using System;
using System.IO;

namespace Labo_zork_final
{
    class Program
    {


        static void Main(string[] args)
        {

            //ton perso
            Acteur gentil = new Acteur("Denis", "Denis est un petit enfant", 25, 30, 2, 17, 10);
            gentil.HP = gentil.MaxHP;
            gentil.Armure = gentil.MaxArmure;
            gentil.AfficherEtat();
            //mechant villain 
            Acteur mechant = new Acteur("mechant", "Un voyou qui aime semer la pagaille", 25, 30, 2, 17, 5);
            mechant.HP = mechant.MaxHP;
            mechant.Armure = mechant.MaxArmure;
            mechant.AfficherEtat();

            gentil.Attaquer(mechant);
            mechant.Defendre(gentil);
            gentil.EstvivantOuiouNon();
            mechant.EstvivantOuiouNon();














            Console.ReadLine();
        }
    }
}
