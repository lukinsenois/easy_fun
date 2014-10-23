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
    public class Compra
    {
        Conexao con;

        public void Inserir(DTO.Compra dto)
        {
            try
            {
                con = new Conexao();

                con.Conectar();
                string comando = "INSERT INTO compra VALUES ('"+dto.Id_compra+"', '"+dto.hora+"', '"+dto.Produtos_id_produtos+"', '"+dto.Id_pulseira+"')";
                con.ExecutarComandoSQL(comando);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Cadastrar Produto a Pulseira: " + ex.Message);
            }

            finally
            {
                con = null;
            }
        }
    }
}
