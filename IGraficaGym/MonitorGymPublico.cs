using IGraficaIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2HerenciaSimpleIES
{
    public class MonitorGymPublico : MonitorGym, IEmpleadoPublico
    {
        private int anyoIngresoCuerpo;
        private bool definitivo;
        private TipoMed tipoMedico;
        public int AnyoIngresoCuerpo
        {
            get { return anyoIngresoCuerpo; }
            set { anyoIngresoCuerpo = value; }
        }

        public bool DestinoDefinitivo
        {
            get { return definitivo; }
            set { definitivo = value; }
        }
        public TipoMed TipoMedico
        {
            get { return tipoMedico; }
            set { tipoMedico = value; }
        }

        public MonitorGymExtendido MonitorGymExtendido { get; set; }
        public MonitorGymPublico()
        {
        }
        public MonitorGymPublico(int edad, string apellidos, string nombre) : base(edad, apellidos, nombre)
        {
        }

        public MonitorGymPublico(string nombre,
                                   string apellidos,
                                   int edad,
                                   string materia,
                                   TipoMonitor tipoMonitor,
                                   int anyoIngreso,
                                   bool definitivo,
                                   TipoMed tipoMedico) : base(edad, apellidos, nombre)
        {
            Especializacion = materia;
            TipoMonitor = tipoMonitor;
            DestinoDefinitivo = definitivo;
            AnyoIngresoCuerpo = anyoIngreso;
            TipoMedico = tipoMedico;
        }

        public MonitorGymPublico(string nombre,
                                   string apellidos,
                                   int edad,
                                   string materia,
                                   TipoMonitor tipoMonitor,
                                   int anyoIngreso,
                                   bool definitivo,
                                   TipoMed tipoMedico,
                                   string rutaFoto) : base(rutaFoto, edad, apellidos, nombre)
        {
            Especializacion = materia;
            TipoMonitor = tipoMonitor;
            DestinoDefinitivo = definitivo;
            AnyoIngresoCuerpo = anyoIngreso;
            TipoMedico = tipoMedico;

        }

        public MonitorGymPublico(string rutaFoto, int edad, string apellidos, string nombre) : base(rutaFoto, edad, apellidos, nombre)
        {
        }
        public int GetSexenios()
        {
            return (DateTime.Today.Year - AnyoIngresoCuerpo) / 6;
        }

        public int GetTrienios()
        {
            return (DateTime.Today.Year - AnyoIngresoCuerpo) / 3;
        }

        public (int anyos, int meses, int dias) TiempoServicio()
        {
            DateTime fechaIngreso = new DateTime(AnyoIngresoCuerpo, 9, 1);
            TimeSpan diferencia = DateTime.Now - fechaIngreso;
            int dias = diferencia.Days % 365 % 30;
            int meses = diferencia.Days % 365 / 30;
            int anyos = diferencia.Days / 365;
            return (anyos, meses, dias);
        }

        public override string ToString()
        {
            return base.ToStringMonitor() + string.Format("{0}{1}{2}",
                anyoIngresoCuerpo.ToString().PadRight(10),
                definitivo ? "SI".PadRight(20) : "NO".PadRight(20),
                tipoMedico.ToString().PadRight(20));
        }
        public override bool Equals(object? obj)
        {

            return (obj is MonitorGymPublico funcionario &&
                   Id == funcionario.Id);
        }
        public static List<MonitorGymPublico> CrearListaMonitoresPublico()
        {
            // Primero obtenemos los emails de la lista de MonitoresExtendidos
            List<MonitorGymExtendido> extendidos = MonitorGymExtendido.CrearListaMonitoresEx();
            List<MonitorGymPublico> listaPublicos = new List<MonitorGymPublico>();

            foreach (var ex in extendidos)
            {
                // Crear MonitorGymPublico con el mismo email
                listaPublicos.Add(new MonitorGymPublico
                {
                    Id = ex.MonitorGymPublicoId,
                    Nombre = "Nombre temporal",
                    Apellidos = "Apellidos temporales",
                    Edad = 30, // Edad temporal
                    RutaFoto = "",
                    AnyoIngresoCuerpo = 2020,
                    DestinoDefinitivo = true,
                    TipoMedico = TipoMed.Muface,
                    Especializacion = "Especialidad temporal",
                    TipoMonitor = TipoMonitor.Novato
                });
            }

            return listaPublicos;
        }
    }
}
