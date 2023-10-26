using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo

    {
        private bool esAWD;
        private Guid numeroDeChasis;
       
        private EPropulsion propulsion;

        protected Vehiculo(EPropulsion propulsion):this(propulsion, false)
        {
            this.esAWD = false;
        }
        protected Vehiculo(EPropulsion propulsion, bool esAWD)
        {
            this.esAWD = esAWD;
            numeroDeChasis = Guid.NewGuid();
            this.propulsion = propulsion;

        }


        public EPropulsion Propulsion
        {
            get { return this.propulsion; }
        }

        protected abstract string Tipo { get; }

        protected virtual string GetInfo()
        {
            string esAwd = this.esAWD ? "SI" : "NO";
            return string.Format("[{0}] con propulsión a {1}, {2} es AWD, número de chasis {3}.", this.Tipo, this.propulsion, esAwd, this.numeroDeChasis);
        }

        public override string ToString()
        {
            return GetInfo();
        }


        public static bool operator == (Vehiculo v1, Vehiculo v2)
        {
            return (v1.Tipo == v2.Tipo) && v1.numeroDeChasis == v2.numeroDeChasis;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }






    }

    public enum EPropulsion { Combustion, Hibrido, Electrico }
}
