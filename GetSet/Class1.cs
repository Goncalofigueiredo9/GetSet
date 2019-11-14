using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class Class1
    {
        private double valor;
 

        public string recebe
        {
            set
            {
                valor = Convert.ToDouble(value) * 2;
            }
        }
        public string resultado
        {
            get
            {
                return valor.ToString();
            }
        }
    }
}
