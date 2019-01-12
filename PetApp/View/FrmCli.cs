using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetApp.Model;

namespace PetApp
{
    public partial class FrmCli : Form
    {
        public FrmCli()
        {
            InitializeComponent();
            List<Clientes> clientes = new List<Clientes>();
            if (clientes != null)
            {
                gridControl1.DataSource = clientes;
            }
        }

        private void btnAdcCli_Click(object sender, EventArgs e)
        {
            FrmCadCli frmcadcli = new FrmCadCli();
            frmcadcli.ShowDialog();
        }
    }
}
