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
    public class Pulseira
    {
        Conexao con;

        public void Inserir(DTO.Pulseira dto)
        {
            try
            {
                con = new Conexao();

                con.Conectar();
                string comando = "INSERT INTO pulseira VALUES ('"+dto.Id_pulseira+"', '"+dto.Status+"', '"+dto.Camarote+"', '"+dto.Tipo+"')";
                con.ExecutarComandoSQL(comando);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Cadastrar Pulseira: " + ex.Message);
            }

            finally
            {
                con = null;
            }
        }
    }
}
