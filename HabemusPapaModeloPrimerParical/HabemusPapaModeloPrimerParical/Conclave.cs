using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabemusPapaModeloPrimerParical
{
    class Conclave
    {
        private int _cantMaxCardenales;
        private List<Cardenal> _cardenales;
        private bool _habemusPapa;
        private string _lugarEleccion;
        private Cardenal _papa;
        public static int _cantidadVotaciones;
        public static DateTime fechaVotacion;
        

        static Conclave()
        { 
            _cantidadVotaciones = 0;
            fechaVotacion = DateTime.Now;
        }

        public Conclave()
        { 
            this._cantMaxCardenales = 1;
            this._lugarEleccion = "Capilla Sixtina";
            this._cardenales = new List<Cardenal>();

        }

        private  Conclave(int cantidadCardenales):this()
        {
            
        }

        public Conclave(int cantidadCardenales, string lugarEleccion):this()
        {
            

        }

        private void ContarVotos(Conclave conclave)
        {

        }

        public static explicit operator bool(Conclave con)
        {
            bool hayPapa = false;
            if (con._habemusPapa == true)
            {
                hayPapa = true;
            }

            return hayPapa;
        }

        private bool HayLugar()
        {
            bool respuesta = false;
            if (this._cantMaxCardenales > this._cardenales.Count)
            {
                respuesta = true;
            }
             return respuesta;

        }

        public implicit operator Conclave(int cantidadCardenales)
        {
             return new Conclave(cantidadCardenales);
        }

        public string Mostrar()
        {
            string respuesta = "";

            if (this._habemusPapa == true)
            {
                respuesta = string.Concat("Lugar de votacion : " + this._lugarEleccion + "\nFecha de Votacion: " + fechaVotacion + "\nCantidad de votos: " + _cantidadVotaciones + "\nHABEMUS PAPA!!!" + this._papa.ObtenerNombreYNombrePapal());
            }
            else
            {
                respuesta = string.Concat("Lugar de votacion : " + this._lugarEleccion + "\nFecha de Votacion: " + fechaVotacion + "\nCantidad de votos: " + _cantidadVotaciones + "\nNO HABEMUS PAPA!!!" + MostrarCardenales());
            }
            
            
        }

        private string MostrarCardenales()
        {
            string respuesta = "";

            foreach(Cardenal item in _cardenales)
            {
                respuesta=Cardenal.Mostrar(item);
            }
            return respuesta;
            
        }

        public static bool operator !=(Conclave con,Cardenal c)
        {
        }

        public static Conclave operator +(Conclave con, Cardenal c)
        {
        }

        public static bool operator ==(Conclave con, Cardenal c)
        {
        }

        public void VotarPapa(Conclave conclave)
        {
        }



    }
}
