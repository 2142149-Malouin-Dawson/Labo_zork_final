using System;

namespace Labo_zork_final
{
    class Acteur
    {

public string Nom{get;set;}
public string Description{get;set;}
public int MaxHP{get;set;}
public double HP {get;set;}
public int MaxArmure{get;set;}
public double Armure{get;set;}
public int RegenArmure{get;set;}
public double Agilite{get;set;}
public double Dommage{get;set;}
public double TauxCritique{get;set;}
public Acteur(string Nom,string Description,int MaxHP,int MaxArmure,int RegenArmure, double Agilite, double Dommage)
        {
            this.Nom=Nom;
            this.Description=Description;
            this.MaxHP=MaxHP;
            this.HP=MaxHP;
            this.MaxArmure=MaxArmure;
            this.Armure=MaxArmure;
            this.RegenArmure=RegenArmure;
            this.Agilite=Agilite;
            this.Dommage=Dommage;
            this.TauxCritique=Agilite/2;
        }

public void Attaquer(Acteur mechant)
        {
            Random aleatoire = new Random();
            int banque = aleatoire.Next(1, 101);
            //critique
            if (banque > 100 - this.TauxCritique)
            {
                Console.WriteLine("coup critique");
                mechant.Armure = mechant.Armure - (this.Dommage * 1.5);
               
            }
            //dommage annulee
            else if (banque < mechant.Agilite)
            {
                Console.WriteLine("dommage annulé");
            }
            //dommage normaux
            else
            {
                Console.WriteLine("dommage normaux");
                mechant.Armure = mechant.Armure - this.Dommage;
               
            }
        }
 public void AfficherEtat(){
            Console.WriteLine($"nom:{this.Nom} description:{this.Description} MaxHP: {this.MaxHP} armure:{this.MaxArmure} regenarmure: {this.RegenArmure} agilite:{this.Agilite} dommage:{this.Dommage} taux critique {this.TauxCritique}");
        }
public void Defendre(Acteur acteur)
        
        {
             if (this.Armure < 0) //si armure brisee
                {
                    this.HP = this.HP + this.Armure;
                    this.Armure = 0;                   
                }
                 //regen armure
            if(this.Armure<this.MaxArmure)
            this.Armure=this.Armure+this.RegenArmure;
            //double verif
            if(this.Armure>this.MaxArmure)
            {
                this.Armure=this.MaxArmure;
            }
                
        }
         public bool Estvivant()
    {
        bool estvivant=false;
        if(this.HP>0)
        {
            estvivant=true;
        }
        return estvivant;
    }
    public void EstvivantOuiouNon()
    {
          bool estvivant=this.Estvivant();
           if(estvivant==true)
           {
Console.WriteLine(this.Nom+" est en vie");
           }
           else
           {
               Console.WriteLine(this.Nom+" est en mort");
           }
    }
    }
   
}