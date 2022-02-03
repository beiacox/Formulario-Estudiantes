using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SpreadsheetLight;

namespace Formulario_E.Models
{
    public class excel:Iestudiante
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
            //creo una tabla y la transformo a hoja de calculo
            string pathfile = AppDomain.CurrentDomain.BaseDirectory + FILENAME;
            SLDocument slcd = new SLDocument();
            System.Data.DataTable dt = new System.Data.DataTable();

            dt.Columns.Add("Matrucula");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("Nacimiento");
            dt.Columns.Add("Carrera");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Mail");

            dt.Rows.Add(MATRICULA,NOMBRES,APELLIDOS,NACIMIENTO,CARRERA,DIRECCION,TELEFONO,EMAIL);

            slcd.ImportDataTable(1, 1, dt, true);
            slcd.SaveAs(pathfile);

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
            this.FILENAME = NOM + ".xlsx";
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