using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLTA_LR_2
{
    public partial class TraversalGraph : Form
    {
        public TraversalGraph()
        {
            InitializeComponent();
        }


        private void bt_DrawGraph_Click(object sender, EventArgs e)
        {
            if (OrientedGraph_cb.Checked)
            {
                UndirectedGraph_cb.Checked = false; 
                pb1.Image = new Bitmap("C:\\Users\\marjn\\source\\repos\\MLTA_LR_2\\orientedGraph.png");
            }
            else if (UndirectedGraph_cb.Checked)
            {
                pb1.Image = new Bitmap("C:\\Users\\marjn\\source\\repos\\MLTA_LR_2\\undirectedGraph.png");
            }
            else
            {
                pb1.Image = null; 
            }
        }

        private void OrientedGraph_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (OrientedGraph_cb.Checked)
            {
                UndirectedGraph_cb.Checked = false;
            }
        }

        private void UndirectedGraph_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (UndirectedGraph_cb.Checked)
            {
                OrientedGraph_cb.Checked = false; 
            }
        }

        private void IsDFS_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (IsDFS_cb.Checked)
            {
                IsBFS_cb.Checked = false; 
            }
        }

        private void IsBFS_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (IsBFS_cb.Checked)
            {
                IsDFS_cb.Checked = false; 
            }
        }

        private void bt_Exid_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            Application.Exit();

        }

        private void bt_MakeDetour_Click(object sender, EventArgs e)
        {
            if (!OrientedGraph_cb.Checked && !UndirectedGraph_cb.Checked)
            {
                MessageBox.Show("Будь ласка, оберіть тип графа!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsDFS_cb.Checked && !IsBFS_cb.Checked)
            {
                MessageBox.Show("Будь ласка, оберіть вид обходу!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GraphTraversal graphTraversal = new GraphTraversal();
            graphTraversal.InitializeGraphs(); 

            int startVertex = cb_StartVertex.SelectedIndex; 

            List<string> traversalResult;

            if (OrientedGraph_cb.Checked)
            {
                traversalResult = IsDFS_cb.Checked ? graphTraversal.DFS(graphTraversal.directedGraph, startVertex) : graphTraversal.BFS(graphTraversal.directedGraph, startVertex);
            }
            else
            {
                traversalResult = IsDFS_cb.Checked ? graphTraversal.DFS(graphTraversal.undirectedGraph, startVertex) : graphTraversal.BFS(graphTraversal.undirectedGraph, startVertex);
            }

            tb1.Text = $"Обрано граф: {(OrientedGraph_cb.Checked ? "Орієнтований" : "Неорієнтований")}{Environment.NewLine}" +
                        $"Тип обходу: {(IsDFS_cb.Checked ? "Обхід у глибину (DFS)" : "Обхід у ширину (BFS)")}{Environment.NewLine}" +
                        $"Результат обходу: {string.Join(" -> ", traversalResult)}";
        }


    }
}
