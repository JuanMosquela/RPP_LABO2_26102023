using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta : Vehiculo
    {

        private bool cabinaSimple;

        
        

        public Camioneta (EPropulsion propulsion, bool cabinaSimple):base(propulsion)
        {
            this.cabinaSimple = cabinaSimple;
        }

        protected override string Tipo { get { return "Camioneta"; } }

        protected override string GetInfo()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine($"con cabina, {this.cabinaSimple}");

            return stringBuilder.ToString();
        }


    }
}
