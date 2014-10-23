using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using easyfun.DAL;
using easyfun.DTO;
using System.Windows.Forms;
using System.Data;


namespace easyfun.BLL
{
    public class Produtos
    {
        Conexao con;

        public void Inserir(DTO.Produtos dto)
        {
            try
            {
                con = new Conexao();

                con.Conectar();
                string comando = "INSERT INTO produtos VALUES ('"+dto.Id_produtos+"', '"+dto.Preco+"', '"+dto.Nome+"', '"+dto.Descricao+"')";
                con.ExecutarComandoSQL(comando);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Cadastrar Produto: " + ex.Message);
            }

            finally
            {
                con = null;
            }
        }
    }
}
