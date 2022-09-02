using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaternaWindowsForms
{
    public class Laterna
    {
        public Laterna(Bateria bateria) {
            this.bateria = bateria;
            status = 0;
        }
        public int status { get; set; }
        public Bateria bateria { get; set;}
    }
}
