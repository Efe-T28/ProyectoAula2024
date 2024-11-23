using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Alerta
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public Coordenada Ubicacion { get; set; }
        public TipoAlerta Tipo { get; private set; }

        public Alerta(TipoAlerta tipo, Coordenada ubicacion)
        {
            if (!TipoAlerta.EsTipoValido(tipo))
            {
                throw new ArgumentException("Tipo de alerta no válido", nameof(tipo));
            }

            this.Tipo = tipo;
            this.FechaHora = DateTime.Now;
            this.Ubicacion = ubicacion;
        }

        public void CambiarTipoAlerta(TipoAlerta nuevoTipo)
        {
            if (!TipoAlerta.EsTipoValido(nuevoTipo))
            {
                throw new ArgumentException("Tipo de alerta no válido", nameof(nuevoTipo));
            }

            this.Tipo = nuevoTipo;
        }
    }
}

