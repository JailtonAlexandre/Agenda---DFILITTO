using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Agenda
{
    class DALContato
    {
        private Conexao objConexao;

        public DALContato(Conexao conexao)
        {
            objConexao = conexao;
        }

        public void Incluir(Contato contato)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "insert into TAB_CONTATO(NOME_VC_CONTATO, EMAIL_VC_CONTATO, FONE_VC_CONTATO,RUA_VC_CONTATO,BAIRRO_VC_CONTATO,CIDADE_VC_CONTATO,ESTADO_VC_CONTATO,CEP_VC_CONTATO)" +
                "VALUES (@nome, @email, @fone, @rua, @bairro, @cidade, @estado, @cep); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", contato.Nome);
            cmd.Parameters.AddWithValue("@email", contato.Email);
            cmd.Parameters.AddWithValue("@fone", contato.Fone);
            cmd.Parameters.AddWithValue("@rua", contato.Rua);
            cmd.Parameters.AddWithValue("@bairro", contato.Bairro);
            cmd.Parameters.AddWithValue("@cidade", contato.Cidade);
            cmd.Parameters.AddWithValue("@estado", contato.Estado);
            cmd.Parameters.AddWithValue("@cep", contato.Cep);
            objConexao.Conectar();
            contato.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            objConexao.Desconectar();
        }

        public void Alterar(Contato contato)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText =   "update TAB_CONTATO set NOME_VC_CONTATO = @nome, EMAIL_VC_CONTATO = @email," +
                                "FONE_VC_CONTATO = @fone, RUA_VC_CONTATO = @rua, BAIRRO_VC_CONTATO = @bairro," +
                                "CIDADE_VC_CONTATO = @cidade, ESTADO_VC_CONTATO = @estado, CEP_VC_CONTATO = @cep " +
                                " where ID_IN_CONTATO = @cod";
            cmd.Parameters.AddWithValue("@nome", contato.Nome);
            cmd.Parameters.AddWithValue("@email", contato.Email);
            cmd.Parameters.AddWithValue("@fone", contato.Fone);
            cmd.Parameters.AddWithValue("@rua", contato.Rua);
            cmd.Parameters.AddWithValue("@bairro", contato.Bairro);
            cmd.Parameters.AddWithValue("@cidade", contato.Cidade);
            cmd.Parameters.AddWithValue("@estado", contato.Estado);
            cmd.Parameters.AddWithValue("@cep", contato.Cep);
            cmd.Parameters.AddWithValue("@cod", contato.Codigo);
            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();
        }

        public void Excluir(int codigo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "delete from TAB_CONTATO where ID_IN_CONTATO = @Cod ";
            cmd.Parameters.AddWithValue("@cod", codigo);
            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();
        }

        public DataTable Localizar(String valor) 
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID_IN_CONTATO AS 'Código'" +
                                                    ", NOME_VC_CONTATO as 'Nome'" +
                                                    ", EMAIL_VC_CONTATO as 'E-mail'" +
                                                    ", FONE_VC_CONTATO as 'Telefone'" +
                                                    ", CEP_VC_CONTATO as 'CEP'" +
                                                    ", RUA_VC_CONTATO + ', ' + BAIRRO_VC_CONTATO + ' / ' + CIDADE_VC_CONTATO + '-' + ESTADO_VC_CONTATO as 'Endereço'" +
                                                    "from TAB_CONTATO where NOME_VC_CONTATO like '%" + valor + "%'", objConexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public Contato carregaContato(int codigo) 
        {
            Contato modelo = new Contato();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "select * from TAB_CONTATO where ID_IN_CONTATO =" + codigo.ToString();
            objConexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows) 
            {
                registro.Read();
                modelo.Codigo = Convert.ToInt32(registro["ID_IN_CONTATO"]);
                modelo.Nome = Convert.ToString(registro["NOME_VC_CONTATO"]);
                modelo.Fone = Convert.ToString(registro["FONE_VC_CONTATO"]);
                modelo.Email = Convert.ToString(registro["EMAIL_VC_CONTATO"]);
                modelo.Rua = Convert.ToString(registro["RUA_VC_CONTATO"]);
                modelo.Bairro = Convert.ToString(registro["BAIRRO_VC_CONTATO"]);
                modelo.Cidade = Convert.ToString(registro["CIDADE_VC_CONTATO"]);
                modelo.Estado = Convert.ToString(registro["ESTADO_VC_CONTATO"]);
                modelo.Cep = Convert.ToString(registro["CEP_VC_CONTATO"]);
                
            }
            return modelo;

        }
    }
}
