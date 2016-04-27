using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabemusPapaModeloPrimerParical
{
    class Cardenal
    {
        private int _cantidadDeVotosRecibidos;
        private ENacionalidades _nacionalidad;
        private string _nombre;
        private string _nombrePapal;

        private Cardenal()
        {
            this._cantidadDeVotosRecibidos = 0;
        }

        public Cardenal(string nombre, string nombrePapal):this()
        {
            this._nombre = nombre;
            this._nombrePapal = nombrePapal;
        }

        public Cardenal(string nombre, string nombrePapal, ENacionalidades nacionalidad):this(nombre,nombrePapal)
        {
            this._nacionalidad = nacionalidad;

        }

        public int getCantidadDeVotosRecibidos()
        {
            return this._cantidadDeVotosRecibidos;
        }

        private string Mostrar()
        {
            string respuesta;
            respuesta = string.Concat(ObtenerNombreYNombrePapal() + " Nacionalidad : " + this._nacionalidad + " Cantidad de votos recibidos : " + this._cantidadDeVotosRecibidos);
            return respuesta;
        }

        public static string Mostrar(Cardenal c)
        {
            return c.Mostrar();
        }

        public string ObtenerNombreYNombrePapal()
        {
            string alias;
            alias = string.Concat("El cardenal " + this._nombre + " se llamara " + this._nombrePapal);
            return alias;
        }

        public static bool operator !=(Cardenal c1, Cardenal c2)
        {
        }

        public static Cardenal operator ++(Cardenal c)
        {
        }

        public static bool operator ==(Cardenal c1, Cardenal c2)
        {
        }


    }

    enum ENacionalidades
    {
        Italiano, Polaco, Español, Argentino, Nigeriano
    }
}
