using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Conexao
    {
        private String _stringConexao;
        private SqlConnection _Conexao;
        //transaction

        public Conexao(String dadosConexao)
        {
            this._Conexao = new SqlConnection ();
            this._stringConexao = dadosConexao;
            this._Conexao.ConnectionString = dadosConexao;

        }

        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        public SqlConnection ObjetoConexao
        {
            get { return this._Conexao; }
            set { this._Conexao = value; }
        }

        public void Conectar()
        {
            this._Conexao.Open();

        }

        public void Desconectar()
        {
            this._Conexao.Close();
        }
    }
}
