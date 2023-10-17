using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba01.Class
{
    public class Equipo
    {
        public String NombreEquipo { get; set; } = null!;
        public int CantidadJugadores { get; set; }
        public String NombreDT { get; set; } = null!;
        public String TipoEquipo { get; set; } = null!;
        public String CapitanEquipo { get; set; } = null!;
        public bool TieneSub21 { get; set; }



        // Constructor que acepta todas las propiedades
        public Equipo(string nombreEquipo, int cantidadJugadores, string nombreDT, string tipoEquipo, string capitanEquipo, bool tieneSub21)
        {
            NombreEquipo = nombreEquipo;
            CantidadJugadores = cantidadJugadores;
            NombreDT = nombreDT;
            TipoEquipo = tipoEquipo;
            CapitanEquipo = capitanEquipo;
            TieneSub21 = tieneSub21;
        }

        public Equipo()
        {
        }

    }
}

