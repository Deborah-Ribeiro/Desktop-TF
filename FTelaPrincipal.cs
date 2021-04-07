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
    public partial class FTelaPrincipal : Form
    {
        public FTelaPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCadStatus fCadStatus = new FCadStatus();
            fCadStatus.ShowDialog();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FCadTarefa fCadTarefa = new FCadTarefa();
            fCadTarefa.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FCadResponsavel fCadResponsavel = new FCadResponsavel();
            fCadResponsavel.ShowDialog();
        }

        private void tarefaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tarefaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tFdesktopDataSet);

        }

        private void tarefaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tarefaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tFdesktopDataSet);

        }

        private void FTelaPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tFdesktopDataSet.SelectQueryDados'. Você pode movê-la ou removê-la conforme necessário.
            this.selectQueryDadosTableAdapter.Fill(this.tFdesktopDataSet.SelectQueryDados);
            // TODO: esta linha de código carrega dados na tabela 'tFdesktopDataSet.Tarefa'. Você pode movê-la ou removê-la conforme necessário.
            this.tarefaTableAdapter.Fill(this.tFdesktopDataSet.Tarefa);

        }

        private void tarefaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
