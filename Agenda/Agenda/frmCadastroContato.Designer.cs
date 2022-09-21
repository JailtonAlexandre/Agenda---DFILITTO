
namespace Agenda
{
    partial class frmCadastroContato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pDados = new System.Windows.Forms.Panel();
            this.pMenu = new System.Windows.Forms.Panel();
            this.btInserir = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.pDados.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pDados
            // 
            this.pDados.Controls.Add(this.txtCep);
            this.pDados.Controls.Add(this.label9);
            this.pDados.Controls.Add(this.txtEstado);
            this.pDados.Controls.Add(this.label8);
            this.pDados.Controls.Add(this.txtCidade);
            this.pDados.Controls.Add(this.label7);
            this.pDados.Controls.Add(this.txtBairro);
            this.pDados.Controls.Add(this.label6);
            this.pDados.Controls.Add(this.txtRua);
            this.pDados.Controls.Add(this.label5);
            this.pDados.Controls.Add(this.txtEmail);
            this.pDados.Controls.Add(this.label4);
            this.pDados.Controls.Add(this.txtFone);
            this.pDados.Controls.Add(this.label3);
            this.pDados.Controls.Add(this.txtNome);
            this.pDados.Controls.Add(this.label2);
            this.pDados.Controls.Add(this.txtCodigo);
            this.pDados.Controls.Add(this.label1);
            this.pDados.Location = new System.Drawing.Point(11, 16);
            this.pDados.Name = "pDados";
            this.pDados.Size = new System.Drawing.Size(761, 451);
            this.pDados.TabIndex = 0;
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.btCancelar);
            this.pMenu.Controls.Add(this.btSalvar);
            this.pMenu.Controls.Add(this.btExcluir);
            this.pMenu.Controls.Add(this.btAlterar);
            this.pMenu.Controls.Add(this.btLocalizar);
            this.pMenu.Controls.Add(this.btInserir);
            this.pMenu.Location = new System.Drawing.Point(11, 473);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(760, 76);
            this.pMenu.TabIndex = 1;
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(7, 17);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(74, 32);
            this.btInserir.TabIndex = 0;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(103, 17);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(73, 32);
            this.btLocalizar.TabIndex = 1;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(202, 17);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(74, 32);
            this.btAlterar.TabIndex = 2;
            this.btAlterar.Text = "Aletarar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(338, 17);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(93, 32);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(536, 17);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(93, 32);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(655, 17);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(93, 32);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(6, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(97, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(7, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(735, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(533, 123);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(209, 20);
            this.txtFone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(7, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(495, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-mail";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(7, 280);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(735, 20);
            this.txtRua.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rua";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(7, 329);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(735, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bairro";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(7, 378);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(735, 20);
            this.txtCidade.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cidade";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(6, 186);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(459, 20);
            this.txtEstado.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(532, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "CEP";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(531, 186);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(209, 20);
            this.txtCep.TabIndex = 17;
            // 
            // frmCadastroContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.pDados);
            this.Name = "frmCadastroContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de contatos";
            this.Load += new System.EventHandler(this.frmCadastroContato_Load);
            this.pDados.ResumeLayout(false);
            this.pDados.PerformLayout();
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pDados;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
    }
}