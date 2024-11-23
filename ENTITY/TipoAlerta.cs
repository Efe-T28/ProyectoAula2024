using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class TipoAlerta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public static readonly TipoAlerta Accidente = new TipoAlerta { Id = 1, Nombre = "Accidente" };
        public static readonly TipoAlerta Robo = new TipoAlerta { Id = 2, Nombre = "Robo" };
        public static readonly TipoAlerta ActividadSospechosa = new TipoAlerta { Id = 3, Nombre = "Actividad Sospechosa" };

        private TipoAlerta() { }

        public static bool EsTipoValido(TipoAlerta tipo)
        {
            return tipo != null && (tipo == Accidente || tipo == Robo || tipo == ActividadSospechosa);
        }
    }
}
