using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultar_Area_y_Volumen_de_una_Piramide.Libreria
{
    public class Piramide : I_Piramide
    {
        #region "Atributos"
        private float _lado;
        private float _altura;


        #endregion
        #region "Constructores"
        public Piramide() //constructor por defecto
        {
            _lado = 0.0F;
            _altura = 0.0F;
        }
        public Piramide(float lado, float altura) //constructor parametrizado
        {
            _lado = lado;
            _altura = altura;
        }
        #endregion
        #region "Propiedades"
        public float Lado
        {
            get { return _lado; }
            set { _lado = value; }
        }
        public float Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }
        #endregion
        #region "Metodos"
        public float obtenerArea()
        {
            try
            {
                return _lado * _lado * (3.0F * _lado * _altura);
            } catch (Exception)
            {
                return -1.0F;
            }
        }
        public float obtenerVolumen()
        {
            try
            {
                return (1.0F / 3.0F) * _lado * _lado * _altura;
            }
            catch (Exception)
            {
                return -1.0F;
            }
        }
                #endregion
    }
}
