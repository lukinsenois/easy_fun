using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easyfun.DTO
{
    public class Cliente
    {
        public virtual int Id_cliente { get; set; }
        public virtual String Nome { get; set; }
        public virtual String Cpf { get; set; }
        public virtual String Rg { get; set; }
        public virtual DateTime Data_nasc { get; set; }
    }
}
