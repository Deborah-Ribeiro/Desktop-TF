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
    public partial class FCadTarefa : Form
    {
        public FCadTarefa()
        {
            InitializeComponent();
        }

        private void tarefaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tarefaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tFdesktopDataSet);

        }

        private void FCadTarefa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tFdesktopDataSet.Status'. Você pode movê-la ou removê-la conforme necessário.
            this.statusTableAdapter.Fill(this.tFdesktopDataSet.Status);
            // TODO: esta linha de código carrega dados na tabela 'tFdesktopDataSet.Responsavel'. Você pode movê-la ou removê-la conforme necessário.
            this.responsavelTableAdapter.Fill(this.tFdesktopDataSet.Responsavel);
            // TODO: esta linha de código carrega dados na tabela 'tFdesktopDataSet.Tarefa'. Você pode movê-la ou removê-la conforme necessário.
            this.tarefaTableAdapter.Fill(this.tFdesktopDataSet.Tarefa);

        }
    }
}
