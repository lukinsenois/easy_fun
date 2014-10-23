using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easyfun.DTO
{
    public class Produtos
    {
        public virtual int Id_produtos { get; set; }
        public virtual double Preco {get; set;}
        public virtual String Nome { get; set; }
        public virtual String Descricao { get; set; }
    }
}
