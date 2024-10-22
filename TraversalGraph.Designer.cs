namespace MLTA_LR_2
{
    partial class TraversalGraph
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.bt_Exid = new System.Windows.Forms.Button();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_StartVertex = new System.Windows.Forms.ComboBox();
            this.bt_MakeDetour = new System.Windows.Forms.Button();
            this.IsBFS_cb = new System.Windows.Forms.CheckBox();
            this.IsDFS_cb = new System.Windows.Forms.CheckBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.bt_DrawGraph = new System.Windows.Forms.Button();
            this.OrientedGraph_cb = new System.Windows.Forms.CheckBox();
            this.UndirectedGraph_cb = new System.Windows.Forms.CheckBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.gb1.SuspendLayout();
            this.gb3.SuspendLayout();
            this.gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.bt_Exid);
            this.gb1.Controls.Add(this.gb3);
            this.gb1.Controls.Add(this.gb2);
            this.gb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb1.Location = new System.Drawing.Point(13, 13);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(378, 415);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Операції над графом";
            // 
            // bt_Exid
            // 
            this.bt_Exid.Location = new System.Drawing.Point(9, 374);
            this.bt_Exid.Name = "bt_Exid";
            this.bt_Exid.Size = new System.Drawing.Size(363, 35);
            this.bt_Exid.TabIndex = 4;
            this.bt_Exid.Text = "Вихід";
            this.bt_Exid.UseVisualStyleBackColor = true;
            this.bt_Exid.Click += new System.EventHandler(this.bt_Exid_Click);
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.label1);
            this.gb3.Controls.Add(this.cb_StartVertex);
            this.gb3.Controls.Add(this.bt_MakeDetour);
            this.gb3.Controls.Add(this.IsBFS_cb);
            this.gb3.Controls.Add(this.IsDFS_cb);
            this.gb3.Location = new System.Drawing.Point(5, 172);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(366, 169);
            this.gb3.TabIndex = 3;
            this.gb3.TabStop = false;
            this.gb3.Text = "Вид обходу";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Оберіть вершину з якої розпочати обхід";
            // 
            // cb_StartVertex
            // 
            this.cb_StartVertex.FormattingEnabled = true;
            this.cb_StartVertex.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f"});
            this.cb_StartVertex.Location = new System.Drawing.Point(15, 58);
            this.cb_StartVertex.Name = "cb_StartVertex";
            this.cb_StartVertex.Size = new System.Drawing.Size(197, 28);
            this.cb_StartVertex.TabIndex = 6;
            // 
            // bt_MakeDetour
            // 
            this.bt_MakeDetour.Location = new System.Drawing.Point(6, 122);
            this.bt_MakeDetour.Name = "bt_MakeDetour";
            this.bt_MakeDetour.Size = new System.Drawing.Size(350, 31);
            this.bt_MakeDetour.TabIndex = 5;
            this.bt_MakeDetour.Text = "Здійснити обхід";
            this.bt_MakeDetour.UseVisualStyleBackColor = true;
            this.bt_MakeDetour.Click += new System.EventHandler(this.bt_MakeDetour_Click);
            // 
            // IsBFS_cb
            // 
            this.IsBFS_cb.AutoSize = true;
            this.IsBFS_cb.Location = new System.Drawing.Point(163, 92);
            this.IsBFS_cb.Name = "IsBFS_cb";
            this.IsBFS_cb.Size = new System.Drawing.Size(110, 24);
            this.IsBFS_cb.TabIndex = 1;
            this.IsBFS_cb.Text = "В ширину";
            this.IsBFS_cb.UseVisualStyleBackColor = true;
            this.IsBFS_cb.CheckedChanged += new System.EventHandler(this.IsBFS_cb_CheckedChanged);
            // 
            // IsDFS_cb
            // 
            this.IsDFS_cb.AutoSize = true;
            this.IsDFS_cb.Location = new System.Drawing.Point(16, 92);
            this.IsDFS_cb.Name = "IsDFS_cb";
            this.IsDFS_cb.Size = new System.Drawing.Size(114, 24);
            this.IsDFS_cb.TabIndex = 0;
            this.IsDFS_cb.Text = "В глибину";
            this.IsDFS_cb.UseVisualStyleBackColor = true;
            this.IsDFS_cb.CheckedChanged += new System.EventHandler(this.IsDFS_cb_CheckedChanged);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.bt_DrawGraph);
            this.gb2.Controls.Add(this.OrientedGraph_cb);
            this.gb2.Controls.Add(this.UndirectedGraph_cb);
            this.gb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb2.Location = new System.Drawing.Point(6, 31);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(361, 135);
            this.gb2.TabIndex = 2;
            this.gb2.TabStop = false;
            this.gb2.Text = "Вибір виду графа";
            // 
            // bt_DrawGraph
            // 
            this.bt_DrawGraph.Location = new System.Drawing.Point(3, 90);
            this.bt_DrawGraph.Name = "bt_DrawGraph";
            this.bt_DrawGraph.Size = new System.Drawing.Size(352, 31);
            this.bt_DrawGraph.TabIndex = 6;
            this.bt_DrawGraph.Text = "Зобразити граф";
            this.bt_DrawGraph.UseVisualStyleBackColor = true;
            this.bt_DrawGraph.Click += new System.EventHandler(this.bt_DrawGraph_Click);
            // 
            // OrientedGraph_cb
            // 
            this.OrientedGraph_cb.AutoSize = true;
            this.OrientedGraph_cb.Location = new System.Drawing.Point(15, 30);
            this.OrientedGraph_cb.Name = "OrientedGraph_cb";
            this.OrientedGraph_cb.Size = new System.Drawing.Size(196, 24);
            this.OrientedGraph_cb.TabIndex = 0;
            this.OrientedGraph_cb.Text = "Орієнтований граф";
            this.OrientedGraph_cb.UseVisualStyleBackColor = true;
            this.OrientedGraph_cb.CheckedChanged += new System.EventHandler(this.OrientedGraph_cb_CheckedChanged);
            // 
            // UndirectedGraph_cb
            // 
            this.UndirectedGraph_cb.AutoSize = true;
            this.UndirectedGraph_cb.Location = new System.Drawing.Point(14, 60);
            this.UndirectedGraph_cb.Name = "UndirectedGraph_cb";
            this.UndirectedGraph_cb.Size = new System.Drawing.Size(216, 24);
            this.UndirectedGraph_cb.TabIndex = 1;
            this.UndirectedGraph_cb.Text = "Неорієнтований граф";
            this.UndirectedGraph_cb.UseVisualStyleBackColor = true;
            this.UndirectedGraph_cb.CheckedChanged += new System.EventHandler(this.UndirectedGraph_cb_CheckedChanged);
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb1.Location = new System.Drawing.Point(798, 27);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.ReadOnly = true;
            this.tb1.Size = new System.Drawing.Size(337, 401);
            this.tb1.TabIndex = 2;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(397, 21);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(395, 401);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            // 
            // TraversalGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 441);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.gb1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "TraversalGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обхід графа в глибину та ширину";
            this.gb1.ResumeLayout(false);
            this.gb3.ResumeLayout(false);
            this.gb3.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.CheckBox UndirectedGraph_cb;
        private System.Windows.Forms.CheckBox OrientedGraph_cb;
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.CheckBox IsBFS_cb;
        private System.Windows.Forms.CheckBox IsDFS_cb;
        private System.Windows.Forms.Button bt_MakeDetour;
        private System.Windows.Forms.Button bt_Exid;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button bt_DrawGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_StartVertex;
    }
}

