using _2HerenciaSimpleIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGraficaIES
{
    public enum EstadCivil : uint
    {
        Soltero = 1,
        Casado = 2,
        Divorciado = 3,
        Viudo = 4
    }
    public class MonitorGymExtendido
    {
        private string id;
        private EstadCivil ecivil;
        private string email;
        private int peso;
        private int estatura;

        public MonitorGymExtendido()
        {
        }
        public MonitorGymExtendido(int estatura, int peso, string email, EstadCivil eCivil)
        {
            Estatura = estatura;
            Peso = peso;
            Id = email;
            MonitorGymPublicoId = email;
            ECivil = eCivil;
        }

        public int Estatura
        {
            get { return estatura; }
            set { estatura = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }


        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public string MonitorGymPublicoId
        {
            get { return email; }
            set { email = value; }
        }

        public EstadCivil ECivil
        {
            get { return ecivil; }
            set { ecivil = value; }
        }
        public static List<MonitorGymExtendido> CrearListaMonitoresEx()
        {

            List<MonitorGymExtendido> listaProfesores = new List<MonitorGymExtendido>();


            listaProfesores.Add(new MonitorGymExtendido(
               150,  75, "gamaa@trass.com", EstadCivil.Casado));

            listaProfesores.Add(new MonitorGymExtendido(
            165, 82, "felol@trass.com", EstadCivil.Casado));

            listaProfesores.Add(new MonitorGymExtendido(
                160, 68, "sadic@trass.com", EstadCivil.Divorciado));

            listaProfesores.Add(new MonitorGymExtendido(
           172, 70, "roruj@trass.com", EstadCivil.Viudo));

            listaProfesores.Add(new MonitorGymExtendido(
             185, 91, "pegol@trass.com", EstadCivil.Soltero));

            listaProfesores.Add(new MonitorGymExtendido(
            155, 65, "mahem@trass.com", EstadCivil.Casado));

            listaProfesores.Add(new MonitorGymExtendido(
             178, 88, "jimos@trass.com", EstadCivil.Soltero));

            listaProfesores.Add(new MonitorGymExtendido(
           157, 79, "mogid@trass.com", EstadCivil.Viudo));

            listaProfesores.Add(new MonitorGymExtendido(
            185, 85, "varoe@trass.com", EstadCivil.Casado));

            listaProfesores.Add(new MonitorGymExtendido(
                153, 73, "natop@trass.com", EstadCivil.Divorciado));

            return listaProfesores;
        }

        public override bool Equals(object? obj)
        {

            return (obj is MonitorGymExtendido extendido &&
                   MonitorGymPublicoId == extendido.MonitorGymPublicoId);
        }

    }
}
