using System;
using RPG.src.Entities;
using  static System. Console;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Random valorAleatorio = new Random();
            int meleeAtk;
            meleeAtk = valorAleatorio.Next(30);

            Random valorAle = new Random();
            int magicAtk;
            magicAtk = valorAleatorio.Next(30);

            Lord chrom = new Lord("Chrom", 22, "Lord", 120, 50);
            GreatKnight frederick = new GreatKnight("Frederick", 22, "Great Knight", 100, 60);
            Cleric lissa = new Cleric("Lissa", 22, "Cleric", 100, 95); 
            Wizard robin  = new Wizard("Robin", 22, "Wizard", 100, 120);
            Fighter vaike = new Fighter("Vaike", 22, "Fighter", 100, 10);
            Archer virion = new Archer("Virion", 20, "Archer", 90, 30);

            Sorcerer validar = new Sorcerer("Validar", 55, "Sorcerer", 190, 150);
            Myrmidon gangrel = new Myrmidon("Validar", 55, "Myrmidon", 150, 100);
            DarkKnight aversa = new DarkKnight("Aversa", 55, "DarkKinght", 170, 150);
            Dragon grima = new Dragon("Grima", 85, "Fell Dragon", 200, 190);

            WriteLine(vaike);
            WriteLine(vaike.Attack(5) + " " + meleeAtk);

            WriteLine(frederick);
            WriteLine(frederick.Attack(7) + " " + meleeAtk);

            WriteLine(chrom);
            WriteLine(chrom.Attack(6) + " " + meleeAtk);

            WriteLine(robin);
            WriteLine(robin.Attack(6) + " " + magicAtk);

            WriteLine(virion);
            WriteLine(virion.Attack(5) + " " + meleeAtk);

            WriteLine(lissa);
            WriteLine(lissa.Attack(4) + " " + magicAtk);

            WriteLine(validar);
            WriteLine(validar.Attack(7) + " " + magicAtk);

            WriteLine(aversa);
            WriteLine(aversa.Attack(7) + " " + magicAtk);

            WriteLine(gangrel);
            WriteLine(gangrel.Attack(4) + " " + meleeAtk);

            WriteLine(grima);
            WriteLine(grima.Attack(9) + " " + magicAtk);
            
        }
    }
}