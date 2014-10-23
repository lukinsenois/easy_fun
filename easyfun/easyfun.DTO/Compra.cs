using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easyfun.DTO
{
    public class Compra
    {
        public virtual int Id_compra { get; set; }
        public virtual DateTime hora { get; set; }
        public virtual int Produtos_id_produtos { get; set; }
        public virtual int Id_pulseira { get; set; }
    }
}
