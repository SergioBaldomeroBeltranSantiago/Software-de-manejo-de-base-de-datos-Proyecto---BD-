using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    class Solicitud
    {
        private int NumeroSolicitud { get; set; }
        private string ClaveEstudiante { get; set; }
        private string ClaveEncargado { get; set; }
        private string ClaveTramite { get; set; }
        private string FechaSolicitud { get; set; }
        private string Estatus { get; set; }

        public Solicitud(int numeroSolicitud, string claveEstudiante, string claveEncargado, string claveTramite, string fechaSolicitud, string estatus)
        {
            NumeroSolicitud = numeroSolicitud;
            ClaveEstudiante = claveEstudiante ?? throw new ArgumentNullException(nameof(claveEstudiante));
            ClaveEncargado = claveEncargado ?? throw new ArgumentNullException(nameof(claveEncargado));
            ClaveTramite = claveTramite ?? throw new ArgumentNullException(nameof(claveTramite));
            FechaSolicitud = fechaSolicitud ?? throw new ArgumentNullException(nameof(fechaSolicitud));
            Estatus = estatus ?? throw new ArgumentNullException(nameof(estatus));
        }

        public Solicitud()
        {
        }
    }
}
