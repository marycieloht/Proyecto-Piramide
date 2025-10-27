using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultar_Area_y_Volumen_de_una_Piramide.Libreria
{
    public class ValidaDatos
    {
        public string esRealCorto(string nombreVar, string valorVar)
        {
            if (valorVar.Equals(""))
            {
                return "Ingrese " + nombreVar;
            }else
            {
                float valorFloat;
                if (float.TryParse(valorVar, out valorFloat))//trae un float y esta convertido
                {
                    if ( valorFloat > 0.0F)
                    {
                        //Todo OK
                        return "";
                    }else
                    {
                        return "Ingrese " + nombreVar + "> 0";
                    }
                }else
                {
                    return "Ingrese " + nombreVar + " numerico con decimales";
                }
            }
        }
    }
}
