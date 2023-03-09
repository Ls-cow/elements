using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elements
{
    internal class alumne
    {
        private string cognom;
        private DateTime dataNaixament;
        private string email;
        private string nif;
        private string nom;
        private int numAlumne;
        private char sexe;
        private int telefon;

        public string Cognom
        {
            get { return cognom; }
            set { cognom = value; }
        }
        public string DataNaixament
        {
            get { return dataNaixament; }
            set { dataNaixament = value; }
        }
        public string Email 
        {
            get { return  email; }
            set { email = value; }
        }
        public string Nif
        {
            get { return nif; }
            set { nif = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value;}
        }
        public char Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }
        public int Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        private bool DataValid (DateTime data)
        {

        }
        public int Edat (string data)
        {

        }
        private string EmailValid (string correo)
        { 
        }
        public string Mostra  (string objecte)
        {

        }
        private bool NifValid (string document)
        {

        }
        private string NomValid (string nom)
        {

        }
        public void NumAlumne (int numero)
        {

        }
        private int TelfValid (int tlf)
        { 
        }
        public
}
