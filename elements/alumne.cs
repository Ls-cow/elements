using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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

        #region//Propietats
        public string Cognom
        {
            get { return cognom; }
            set { cognom = value; }
        }
        public DateTime DataNaixament
        {
            get { return dataNaixament; }
            set { dataNaixament = value; }
        }
        public string DataNaix
        {
            get { return dataNaixament.ToString(); }
            set { DateTime.TryParse(value, out dataNaixament); }
        }
        public string Email
        {
            get { return email; }
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
            set { nom = value; }
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
        #endregion
        private bool DataValid(DateTime data)
        {

        }
        public int Edat()
        {
            int edat = DateTime.Now.Year - dataNaixament.Year;
            if (DateTime.Now.Month < dataNaixament.Month)
                edat--;
            else
            {
                if (DateTime.Now.Day < dataNaixament.Day)
                    edat--;
            }
            return edat;
        }
        private string EmailValid(string correo)
        {
            string patron = "[^@]+@[^\\.]+\\..+";
            Regex regex = new Regex(patron);
            do
            {
                Console.WriteLine("Error,escribe nuevamente");
                correo = Console.ReadLine();
            }
            while (!regex.IsMatch(email));
            return correo.ToLower();
        }
        public string Mostra(string objecte)
        {
            Console.WriteLine($"DADES ALUMNE {nom}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Cognom: {cognom}");
        }
        private string NifValid(string document)
        {
            string dniLetra, dniNumeros;
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            while (document.Length != 9)
            {
                Console.WriteLine("Dni mal escrito, ingrese nuevamente.");
                document = Console.ReadLine();
            }
            dniNumeros = document.Substring(0, document.Length - 1);
            dniLetra = document.Substring(document.Length - 1, 1);
            int numeros = Int32.Parse(dniNumeros);
            var mod = numeros % 23;
            document = dniNumeros + control[mod];
            return document;
        }
        private string NomValid(string nom)
        {

        }
        public void NumAlumne(int numero)
        {

        }
        private string TelfValid(string tlf)
        {
            int i = 0, numeroInt;
            while (tlf.Length != 9)
            {
                Console.WriteLine("Numero mal escrito, ingrese de nuevo.");
                tlf = Console.ReadLine();
            }
            bool esNumero = int.TryParse(tlf, out numeroInt);
            while (esNumero == false)
            {
                Console.WriteLine("El numero no puede contener letras, ingrese de nuevo.");
                tlf = Console.ReadLine();
                esNumero = int.TryParse(tlf, out numeroInt);
            }
            return tlf;
        }
    }
}
