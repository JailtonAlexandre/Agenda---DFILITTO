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
    public partial class frmConsultaContato : Form
    {
        public int codigo = 0;
        public frmConsultaContato()
        {
            InitializeComponent();
        }

        private void btExecutar_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao("Data Source=WS006098\\SQLEXPRESS;Initial Catalog=Agenda;Integrated Security=True");
            DALContato dal = new DALContato(cx);
            dgDados.DataSource = dal.Localizar(txtValor.Text);
        }

        private void dgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0) 
            {
                this.codigo = Convert.ToInt32(dgDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
