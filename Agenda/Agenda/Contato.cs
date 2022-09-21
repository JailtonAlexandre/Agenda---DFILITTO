using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contato
    {
        public Contato()
        {
            this.Codigo = 0;
            this.Nome = "";
            this.Email = "";
            this.Fone = "";
            this.Rua = "";
            this.Bairro = "";
            this.Cidade = "";
            this.Estado = "";
            this.Cep = "";
        }

        public Contato(int codigo, string nome, string email, string fone, string rua, string bairro, string cidade, string estado, string cep )
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Email = email;
            this.Fone = fone;
            this.Rua = rua;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Cep = cep;
        }

        private int ID_IN_CONTATO;
        public int Codigo
        {
            get { return this.ID_IN_CONTATO; }
            set { this.ID_IN_CONTATO = value; }
        }

        private String NOME_VC_CONTATO;
        public string Nome
        {
            get { return this.NOME_VC_CONTATO; }
            set { this.NOME_VC_CONTATO = value; }
        }

        private String EMAIL_VC_CONTATO;
        public string Email
        {
            get { return this.EMAIL_VC_CONTATO; }
            set { this.EMAIL_VC_CONTATO = value; }
        }

        private String FONE_VC_CONTATO;

        public string Fone
        {
            get { return this.FONE_VC_CONTATO; }
            set { this.FONE_VC_CONTATO = value; }
        }

        private String RUA_VC_CONTATO;
        public string Rua
        {
            get { return this.RUA_VC_CONTATO; }
            set { this.RUA_VC_CONTATO = value; }
        }

        private String BAIRRO_VC_CONTATO;
        public string Bairro
        {
            get { return this.BAIRRO_VC_CONTATO; }
            set { this.BAIRRO_VC_CONTATO = value; }
        }

        private string CIDADE_VC_CONTATO;
        public string Cidade
        { 
            get { return this.CIDADE_VC_CONTATO; }
            set { this.CIDADE_VC_CONTATO = value; }
        }

        private string ESTADO_VC_CONTATO;
        public string Estado
        {
            get { return this.ESTADO_VC_CONTATO; }
            set { this.ESTADO_VC_CONTATO = value; }
        }

        private string CEP_VC_CONTATO;
        public string Cep
        {
            get { return this.CEP_VC_CONTATO; }
            set { this.CEP_VC_CONTATO = value; }
        }

    }
}
