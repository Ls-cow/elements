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
    { //ATRIBUTS
        private string cognom;
        private DateTime dataNaixament;
        private string email;
        private string nif;
        private string nom;
        private int numAlumne;
        private char sexe;
        private string telefon;

        //PROPIETATS
        public string Cognom
        {
            get { return cognom; }
            set { cognom = value; }
        }
        public DateTime DataNaixament
        {
            get { return dataNaixament.ToString; }
            set { DateTime.TryParse(value, dataNaixament); }
        }
        public string DataNaix
        {
            get { return dataNaixament.ToString(); }
            set { DateTime.TryParse(value, out dataNaixament); }
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
        //METODES
        private bool DataValid (DateTime data)
        {

        }
        public int Edat (string data)
        {

        }
        private string EmailValid (string correo)
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
        public string Mostra  (string objecte)
        {

        }
        private string NifValid (string document)
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
        private string NomValid (string nom)
        {
            Regex validar = new Regex("[a-zA-Z]");
            if(!validar.IsMatch(nom))
            {
                Console.WriteLine("El només pot contenir lletres, torna a escriure");
                nom = Console.ReadLine();
            }
            return nom;

        }
        public int NumAlumne(string[] alumne )
        {
            return alumne.Length + 1;
        }
        private string TelfValid (string tlf)
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
        public string Tostrinng() 
        {
            return $"Nom: {nom} \rCognom: {cognom}\rNum alumne: {numAlumne} \rData de naixament: {dataNaixament}\rNIF:{nif}\rEmail: {email}\r" +
                $"Telefon: {telefon}\r Sexe:{sexe}";
        }
}
