using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easyfun.DTO
{
    public class Pulseira
    {
        public virtual int Id_pulseira { get; set; }
        public virtual String Status { get; set; }
        public virtual String Camarote { get; set; }
        public virtual String Tipo { get; set; }
    }
}
