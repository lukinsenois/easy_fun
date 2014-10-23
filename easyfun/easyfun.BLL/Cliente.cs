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
    public class Cliente
    {
        Conexao con;

        public void Inserir(DTO.Cliente dto)
        {
            try
            {
                con = new Conexao();

                con.Conectar();
                string comando = "INSERT INTO cliente VALUES (null, '"+dto.Nome+"', '"+dto.Cpf+"', '"+dto.Rg+"', '"+dto.Data_nasc+"')";
                con.ExecutarComandoSQL(comando);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Cadastrar o Cliente: "+ex.Message); 
            }

            finally
            {
                con = null;
            }
        }

        public void Alterar(DTO.Cliente dto)
        {
            try
            {
                con = new Conexao();

                con.Conectar();
                string comando = "UPDATE cliente SET nome='"+dto.Nome+"', cpf='"+dto.Cpf+"', rg='"+dto.Rg+"', data_nasc='"+dto.Data_nasc+"'";
                con.ExecutarComandoSQL(comando);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Atualizar o CLiente: "+ex.Message);
            }

            finally
            {
                con = null;
            }
        }

        public DataTable SelecionaTodosCliente()
        {
            try
            {
                DataTable dt = new DataTable();
                con = new Conexao();
                con.Conectar();

                dt = con.GetDatTable("SELECT id_cliente, nome, cpf, rg, data_nasc FROM cliente;");

                return dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Tentar Selecionar os Clientes: "+ex.Message);

                return null;
            }

            finally
            {
                con = null;
            }
        }
    }
}
