using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Formulario_E.Models
{
    public class texto : Iestudiante
    {
        private string MATRICULA;
        private string NOMBRES;
        private string APELLIDOS;
        private string NACIMIENTO;
        private string CARRERA;
        private string DIRECCION;
        private string TELEFONO;
        private string EMAIL;
        private string FILENAME;
        


        public void Exportar()
        {
            //creo variable y luego la exporto como txt
            string pathfile = AppDomain.CurrentDomain.BaseDirectory + FILENAME;
            TextWriter tw = new StreamWriter(pathfile);
            string textu = $"{MATRICULA}\n" +
                $"{NOMBRES}\n" +
                $"{APELLIDOS}\n" +
                $"{NACIMIENTO}\n" +
                $"{CARRERA}\n" +
                $"{DIRECCION}\n" +
                $"{TELEFONO}\n" +
                $"{EMAIL}\n";
            tw.WriteLine(textu);
            tw.Close();
            

        }
        public void Asignar(
            string MAT,
            string NOM,
            string APEL,
            string NACI,
            string CAR,
            string DIR,
            string TEL,
            string MAIL)


        {
            this.MATRICULA = MAT;
            this.NOMBRES = NOM;
            this.APELLIDOS = APEL;
            this.NACIMIENTO = NACI;
            this.CARRERA = CAR;
            this.DIRECCION = DIR;
            this.TELEFONO = TEL;
            this.EMAIL = MAIL;
            this.FILENAME = NOM + ".txt";
        }
        public string getMATRICULA()
        {
            return MATRICULA;
        }
        public string getNOMBRES()
        {
            return NOMBRES;
        }
        public string getAPELLIDOS()
        {
            return APELLIDOS;
        }
        public string getNACIMIENTO()
        {
            return NACIMIENTO;
        }
        public string getCARRERA()
        {
            return CARRERA;
        }
        public string getDIRECCION()
        {
            return DIRECCION;
        }
        public string getTELEFONO()
        {
            return TELEFONO;
        }
        public string getEMAIL()
        {
            return EMAIL;
        }
        public string getFILENAME()
        {
            return FILENAME;
        }

    }
}