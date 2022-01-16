using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    public class Solicitud
    {
        private int NumeroSolicitud;
        private string ClaveEstudiante;
        private string ClaveEncargado;
        private string ClaveTramite;
        private string FechaSolicitud;
        private string Estatus;

        public Solicitud(int numeroSolicitud, string claveEstudiante, string claveEncargado, string claveTramite, string fechaSolicitud, string estatus)
        {
            NumeroSolicitud = numeroSolicitud;
            ClaveEstudiante = claveEstudiante ?? throw new ArgumentNullException(nameof(claveEstudiante));
            ClaveEncargado = claveEncargado ?? throw new ArgumentNullException(nameof(claveEncargado));
            ClaveTramite = claveTramite ?? throw new ArgumentNullException(nameof(claveTramite));
            FechaSolicitud = fechaSolicitud ?? throw new ArgumentNullException(nameof(fechaSolicitud));
            Estatus = estatus ?? throw new ArgumentNullException(nameof(estatus));
        }

        private int getNumeroSolicitud(){
            return this.NumeroSolicitud;
        }

        private string getClaveEstudiante(){
            return this.ClaveEstudiante;
        }

        private string getClaveEncargado(){
            return this.ClaveEncargado;
        }

        private string getClaveTramite(){
            return this.ClaveTramite;
        }

        private string getFechaSolicitud(){
            return this.FechaSolicitud;
        }

        private string getEstatus(){
            return this.Estatus;
        }
    }
}
