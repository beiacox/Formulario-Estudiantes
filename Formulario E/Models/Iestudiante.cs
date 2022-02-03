using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_E.Models
{
    public interface Iestudiante
    {
        //exportacion a archivo externo
        void Exportar();
        //asignacion de valores
        void Asignar(
            string MAT,
            string NOM,
            string APEL,
            string NACI,
            string CAR,
            string DIR,
            string TEL,
            string MAIL);
        //metodos para tomar variables de la clase
        string getMATRICULA();
        string getNOMBRES();
        string getAPELLIDOS();
        string getNACIMIENTO();
        string getCARRERA();
        string getDIRECCION();
        string getTELEFONO();
        string getEMAIL();
        string getFILENAME();

    }
}
