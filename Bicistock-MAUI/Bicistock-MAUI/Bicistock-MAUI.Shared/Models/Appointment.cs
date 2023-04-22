namespace Bicistock_MAUI.Bicistock_MAUI.Shared.Models
{
    public class Appointment
    {
        public int id_cita { get; set; }
        public DateTime fechaCitacion { get; set; }
        public DateTime fechaSolicitud { get; set; }
        public string nombreUsuario { get; set; }
        public string estado_cita { get; set; }
        public int id_marca { get; set; }
        public string usuarioActual { get; set; }
        public string nombreMarca { get; set; }
        public string descripcion { get; set; }

    }
}

