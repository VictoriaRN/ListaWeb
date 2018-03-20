
using System;
using System.ComponentModel.DataAnnotations;

namespace ListaWeb.Models
{


    public class PendienteItem
    {
        /// Guid genera un secuencia aletoria 
        /// Investigar Guid
        public Guid Id { get; set; }

        public bool EstaHecha { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Pendiente { get; set; }

        public DateTimeOffset? ParaCuando { get; set; }

        /// Aquí deben hacer todo lo necesario para la creación de un Pendiente
        public PendienteItem()
        {
            /// El Id debe generarse a la creación de Guid
        Id = Guid.NewGuid();

            /// Las tareas son para dentro de dos días 
        ParaCuando = DateTime.Today.Date.AddDays(3);
        
            
            /// Siempre las tareas deben estas no EstaHecha = false
        EstaHecha = false;


        }
    }
}