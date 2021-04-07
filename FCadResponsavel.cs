using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_TF
{
    public partial class FCadResponsavel : Form
    {
        public FCadResponsavel()
        {
            InitializeComponent();
        }

        private void responsavelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.responsavelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tFdesktopDataSet);

        }

        private void FCadResponsavel_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tFdesktopDataSet.Responsavel'. Você pode movê-la ou removê-la conforme necessário.
            this.responsavelTableAdapter.Fill(this.tFdesktopDataSet.Responsavel);

        }

        private void nomeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
