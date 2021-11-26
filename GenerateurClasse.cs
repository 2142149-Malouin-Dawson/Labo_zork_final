using System;
using System.IO;
namespace Labo_zork_final
{
    class GenerateurClasse
    {
        //lecteur
        public Acteur GenerateurClasses()
        {
            string[] questions = new string[3];
            Acteur[] tableauacteur = new Acteur[3];
            string[] classe = new string[2];
            int guerrier = 0;
            int magicien = 0;
            int voleur = 0;
            int reponse = 0;
            int i = 0;
            Acteur hero=DecoderClasse(classe[0]);
            //lecteur1.................................................................................................
            StreamReader lecteur = new StreamReader("question.txt");
            while (!lecteur.EndOfStream)
            {
                string texte = lecteur.ReadLine();//pose les questions puis decode la classe selon la classe determinee avec les reponses
                questions[i] = texte;//             au questions
                Console.WriteLine(questions[i]);
                reponse = PoserQuestion(questions[i]);
                if (reponse == 1)
                {
                    guerrier++;

                   
                }
                else if (reponse == 2)
                {
                    magicien++;    
                             
                }
                else
                {
                    voleur++;                    
                }
                i++;  
            }
            //....................................................................................................
            i = 0;
            lecteur.Close();
            //lecteur2...............................................................................................
            StreamReader lecteur2 = new StreamReader("classe.txt");
            while (!lecteur.EndOfStream)
            {
                string texte = lecteur2.ReadLine();
                classe[i] = texte;
                Console.WriteLine(classe[i]);
                i++;
            }
            i = 0;
            lecteur.Close();
//...................................................................................................................






            return hero;
        }
        private Acteur DecoderClasse(string classe)
        {
            //tableau du lecteur
            string[] tempo = new string[8];
            tempo = classe.Split(';');
            //nom
            string Nom = tempo[0];
            //description
            string Description = tempo[1];
            //maxhp
            int MaxHP = 0;
            int.TryParse(tempo[2], out MaxHP);
            //hp
            //double HP = MaxHP;
            //max armure
            int MaxArmure = 0;
            int.TryParse(tempo[3], out MaxArmure);
            //armure
            //double Armure = MaxArmure;
            //regenArmure
            int RegenArmure = 0;
            int.TryParse(tempo[4], out RegenArmure);
            //agilite
            double Agilite = 0;
            double.TryParse(tempo[5], out Agilite);
            //dommage
            double Dommage = 0;
            double.TryParse(tempo[6], out Dommage);
            //TauxCritique
            double TauxCritique = 0;
            double.TryParse(tempo[7], out TauxCritique);
            //acteur
            Acteur temporaire = new Acteur(Nom, Description, MaxHP, MaxArmure, RegenArmure, Agilite, Dommage);


            return temporaire;
        }
        public int PoserQuestion(string question)
        {
            string[] tempo = new string[4];
            tempo[0] = question;
            int reponse = 0;
            int reponse1 = 0;
            int reponse2 = 0;
            int reponse3 = 0;
            bool valide = false;
            //question 1
            while (!valide == true)
                int.TryParse(tempo[0], out reponse);
            if (reponse == 1)
            {
                reponse1++;
                valide = true;
            }
            else if (reponse == 2)
            {
                reponse2++;
                valide = true;
            }
            else if (reponse == 3)
            {
                reponse3++;
                valide = true;
            }
            else
            {
                Console.WriteLine("reponse invalide");
            }
            if (reponse1 > reponse2 && reponse1 > reponse3)
            {
                reponse = 1;
            }
            else if (reponse2 > reponse1 && reponse2 > reponse3)
            {
                reponse = 2;
            }
            else if (reponse3 > reponse1 && reponse3 > reponse2)
            {
                reponse = 3;
            }
            else
            {
                bool valide2 = false;
                while (!valide2 == true)
                    Console.WriteLine("les reponse n'ont pu determiner votre personnage,voulez vous 1-guerrier 2-magicien 3-voleur");
                int.TryParse(Console.ReadLine(), out reponse);
                if (reponse > 3)
                {
                    Console.WriteLine("resultat invalide");
                }
                else
                {
                    valide2 = true;
                }
            }
            return reponse;
        }













































    }
}