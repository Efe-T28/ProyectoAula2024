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
        public string Descripcion { get; set; }
        public DateTime FechaHora { get; set; }
        public Coordenada Ubicacion { get; set; }
        public int UsuarioId { get; set; }


        public enum TipoAlerta
        {
            Accidente,
            ActividadSospechosa
        }


        public TipoAlerta Tipo { get; private set; }


        public Alerta(TipoAlerta tipo, string descripcion, Coordenada ubicacion, int usuarioId)
        {
            this.Tipo = tipo;
            this.Descripcion = descripcion;
            this.FechaHora = DateTime.Now;
            this.Ubicacion = ubicacion;
            this.UsuarioId = usuarioId;
        }


        public void CambiarTipoAlerta(TipoAlerta nuevoTipo)
        {
            this.Tipo = nuevoTipo;
        }


        private bool EsTipoValido(TipoAlerta tipo)
        {
            return Enum.IsDefined(typeof(TipoAlerta), tipo);
        }
    }
}
