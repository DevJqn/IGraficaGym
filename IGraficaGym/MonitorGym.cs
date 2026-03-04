
namespace _2HerenciaSimpleIES
{
    public enum TipoMonitor : uint
    {
        Novato = 1,
        EnPracticas = 2,
        Experto = 3
    }

    public abstract class MonitorGym : Persona
    {

		private string especializacion;
        private TipoMonitor tipoMonitor;

        protected MonitorGym()
        {
        }

        protected MonitorGym(int edad, string apellidos, string nombre) : base(edad, apellidos, nombre)
        {
        }

        protected MonitorGym(string rutaFoto, int edad, string apellidos, string nombre) : base(rutaFoto, edad, apellidos, nombre)
        {
        }

        public TipoMonitor TipoMonitor
        {
            get { return tipoMonitor; }
            set { tipoMonitor = value; }
        }

        public string Especializacion
		{
			get { return especializacion; }
			set { especializacion = value; }
		}

        public abstract override string ToString();

        public string ToStringMonitor()
        {
            return base.ToString()+string.Format("{0}{1}",
                especializacion.PadRight(20),
                tipoMonitor.ToString().PadRight(20));
        }
	}
}
