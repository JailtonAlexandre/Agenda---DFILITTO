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
        private SqlConnection _conexao;
        //transaction

        public Conexao(String dadosConexao)
        {
            this._conexao = new SqlConnection ();
            this._stringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;

        }

        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }
    }
}
