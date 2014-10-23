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
    public class Cliente_Pulseira
    {
        Conexao con;

        public void Inserir(DTO.Cliente_Pulseira dto)
        {
            try
            {
                con = new Conexao();

                con.Conectar();
                string comando = "INSERT INTO cliente_has_pulseira VALUES ('"+dto.Cliente_id_cliente+"', '"+dto.Pulseira_id_pulseira+"')";
                con.ExecutarComandoSQL(comando);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Cadastrar Cliente a Pulseira: " + ex.Message);
            }

            finally
            {
                con = null;
            }
        }

        public void Deletar(DTO.Cliente_Pulseira dto)
        {
            try
            {
                con = new Conexao();

                con.Conectar();
                string comando = "DELETE FROM cliente_has_pulseira WHERE pulseira_id_pulseira='"+dto.Pulseira_id_pulseira+"'";
                con.ExecutarComandoSQL(comando);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Retirar Pulseira do Cliente: " + ex.Message);
            }

            finally
            {
                con = null;
            }
        }
    }
}
