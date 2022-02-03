using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Formulario_E.Models
{
    public class menu
    {
        public static Iestudiante estud;

        public void Printmethod(
            string opcion,
            string MAT,
            string NOM,
            string APEL,
            string NACI,
            string CAR,
            string DIR,
            string TEL,
            string MAIL)
        {
            switch (opcion)
            {
                case "excel":
                    estud = new excel();
                    break;
                case "json":
                    estud = new json();
                    break;
                case "txt":
                    estud = new texto();
                    break;
                    

            }
            estud.Asignar(MAT,NOM,APEL,NACI,CAR,DIR,TEL,MAIL);
            estud.Exportar();
        }

        public Iestudiante ActionEx()
        {
            return estud;
        }

    }
}