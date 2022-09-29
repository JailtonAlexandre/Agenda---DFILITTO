using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmCadastroContato : Form
    {
        public string operacao = "";

        public frmCadastroContato()
        {
            InitializeComponent();
        }

        public void AleteraBotoes (int op)
        {
            pDados.Enabled = false;
            btInserir.Enabled = false;
            btLocalizar.Enabled = false;
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;

            if (op == 1)
            {
                btInserir.Enabled = true;
                btLocalizar.Enabled = true;

            }
            if (op == 2)
            {
                pDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btExcluir.Enabled = true;
                btAlterar.Enabled = true;
                btCancelar.Enabled = true;
            }
        }
        public void LimpaCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtFone.Clear();
            txtEstado.Clear();
            txtCep.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtCidade.Clear();

        }

        private void frmCadastroContato_Load(object sender, EventArgs e)
        {
            this.AleteraBotoes(1);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AleteraBotoes(2);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.AleteraBotoes(1);
            this.LimpaCampos();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Contato contato = new Contato();
                if (txtNome.Text.Length <= 0)
                {
                    MessageBox.Show("Nome obrigatório");
                    return;
                }
                contato.Nome = txtNome.Text;
                contato.Email = txtEmail.Text;
                contato.Fone = txtFone.Text;
                contato.Estado = txtEstado.Text;
                contato.Cep = txtCep.Text;
                contato.Rua = txtRua.Text;
                contato.Cidade = txtCidade.Text;
                contato.Bairro = txtBairro.Text;

                string strConexao = "Data Source=WS006098\\SQLEXPRESS;Initial Catalog=Agenda;Integrated Security=True";
                Conexao conexao = new Conexao(strConexao);
                //try
                //{
                //    conexao.Conectar();
                //    MessageBox.Show("Conexao realizada com sucesso");
                //}
                //catch (Exception erro)
                //{
                //    MessageBox.Show(erro.Message);
                //}

                DALContato dal = new DALContato(conexao);
                if (this.operacao == "inserir")
                {
                    //inserir registro no BD                
                    dal.Incluir(contato);
                    MessageBox.Show("O código gerado foi: " + contato.Codigo.ToString());
                }
                else
                {
                    //alterar o contato que esta na tela
                    contato.Codigo = Convert.ToInt32(txtCodigo.Text);
                    dal.Alterar(contato);
                    MessageBox.Show("Registro ALETERADO com sucesso");

                }
                this.AleteraBotoes(1);
                this.LimpaCampos();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaContato f = new frmConsultaContato();
            f.ShowDialog();
            if (f.codigo != 0) 
            {
                string strConexao = "Data Source=WS006098\\SQLEXPRESS;Initial Catalog=Agenda;Integrated Security=True";
                Conexao conexao = new Conexao(strConexao);
                DALContato dal = new DALContato(conexao);
                Contato contato = dal.carregaContato(f.codigo);
                txtCodigo.Text = contato.Codigo.ToString();
                txtNome.Text = contato.Nome;
                txtEmail.Text = contato.Email;
                txtFone.Text = contato.Fone;
                txtBairro.Text = contato.Bairro;
                txtCep.Text = contato.Cep;
                txtRua.Text = contato.Rua;
                txtEstado.Text = contato.Estado;
                txtCidade.Text = contato.Cidade;
                this.AleteraBotoes(3);
            }
            f.Dispose();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.AleteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja EXCLUIR o registro? ", "Aviso", MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes") 
            {
                string strConexao = "Data Source=WS006098\\SQLEXPRESS;Initial Catalog=Agenda;Integrated Security=True";
                Conexao conexao = new Conexao(strConexao);
                DALContato dal = new DALContato(conexao);
                dal.Excluir(Convert.ToInt32(txtCodigo.Text));
                this.AleteraBotoes(1);
                this.LimpaCampos();
            }
        }
    }
}
