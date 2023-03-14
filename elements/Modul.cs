using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
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
            ultimElement = m.ultimElement;
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
                    if (alumnes[i].Nom == input.Substring(0, input.IndexOf(" ")) && alumnes[i].Cognom == input.Substring(input.IndexOf(" ")))
                        return i;
                }
            }
            return -1;
        }
        public Alumne Indexador(string alumne)
        {
            //busca la posició de l'alumne
            int posicio = Index(alumne);
            //retorna l'alumne o null si no existeix
            if (posicio == -1) return null;
            else return alumnes[posicio];
        }
        public void Afegir(Alumne a)
        {
            alumnes[ultimElement] = a;
            ultimElement++;
        }
        public void Modificar(Alumne a)
        {
            //Extreu el nom complet de l'alumne
            string nomComplet = a.Nom + " " + a.Cognom;
            //localitza a l'alumne
            int posicio = Index(nomComplet);
            //modifica l'alumne trobat o no fa res si no existeix
            if (posicio == -1) return;
            else
            {
                alumnes[posicio].Nif = a.Nif;
                alumnes[posicio].DataNaixament = a.DataNaixament;
                alumnes[posicio].Email = a.Email;
                alumnes[posicio].Telefon = a.Telefon;
                alumnes[posicio].Sexe = a.Sexe;
            }
        }
        public void Eliminar(string nomComplet)
        {
            //troba la posicio de l'alumne
            int posicio = Index(nomComplet);
            //si el troba elimina l'alumne
            if (posicio == -1) { }
            else
            {
                alumnes[posicio] = null;
                //reordena l'array i actualitza numero d'alumnes
                for(int i = posicio; i < alumnes.Length; i++)
                {
                    Alumne aux = alumnes[i];
                    alumnes[i] = alumnes[i + 1];
                    alumnes[i + 1] = aux;
                }
                ultimElement--;
            }
        }
    }
}