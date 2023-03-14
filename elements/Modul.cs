﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace elements
{
    internal class Modul
    {
        //Attributs
        private string nom;
        const int midaDefecte = 5;
        Alumne[] alumnes;
        int ultimElement;
        //Constructors
        public Modul(int max)
        {
            Console.Write("Indica el nom del mòdul: ");
            nom = Console.ReadLine();
            alumnes = new Alumne[max];
            ultimElement = -1;
        }
        public Modul() : this(midaDefecte) { }
        public Modul(Modul m) : this(m.alumnes.Length)
        {
            for(int i = 0; i < m.alumnes.Length; i++)
            {
                this.alumnes[i] = m.alumnes[i];
            }
        }
        //Propietats
        public int NumAlumnes
        {
            get { return alumnes.Length; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        //Metodes
        private int Index(string input)
        {
            Regex lletres = new Regex("[a-zA-Z]");
            Regex nums = new Regex("[0-9]");
            //comprova si input és nif
            if (input.Length == 9)
            {
                if (nums.IsMatch(input.Substring(0, 8)) && lletres.IsMatch(input.Substring(9)))
                {
                    //busca l'input a la taula alumnes
                    for (int i = 0; i < NumAlumnes; i++)
                    {
                        if (alumnes[i].Nif == input)
                            return i;
                    }
                }
            }   //comprova si input és nomCognom
            else if(!nums.IsMatch(input))
            {
                //busca l'input a la taula alumnes
                for (int i = 0; i < NumAlumnes; i++)
                {
                    if (alumnes[i].Nom == input)
                        return i;
                }
            }
            return -1;
        }
    }
}
