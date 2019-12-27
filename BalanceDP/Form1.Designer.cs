namespace BalanceDP
{
    partial class frmDiagramma
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
            this.components = new System.ComponentModel.Container();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.btnExitDiagramma = new System.Windows.Forms.Button();
            this.btnDiagramma = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(12, 12);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(762, 368);
            this.zedGraph.TabIndex = 0;
            // 
            // btnExitDiagramma
            // 
            this.btnExitDiagramma.Location = new System.Drawing.Point(492, 74);
            this.btnExitDiagramma.Name = "btnExitDiagramma";
            this.btnExitDiagramma.Size = new System.Drawing.Size(75, 23);
            this.btnExitDiagramma.TabIndex = 2;
            this.btnExitDiagramma.Text = "Выход";
            this.btnExitDiagramma.UseVisualStyleBackColor = true;
            this.btnExitDiagramma.Click += new System.EventHandler(this.btnExitDiagramma_Click);
            // 
            // btnDiagramma
            // 
            this.btnDiagramma.Location = new System.Drawing.Point(133, 28);
            this.btnDiagramma.Name = "btnDiagramma";
            this.btnDiagramma.Size = new System.Drawing.Size(75, 23);
            this.btnDiagramma.TabIndex = 1;
            this.btnDiagramma.Text = "Диаграмма";
            this.btnDiagramma.UseVisualStyleBackColor = true;
            this.btnDiagramma.Click += new System.EventHandler(this.btnDiagramma_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 386);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnDiagramma);
            this.splitContainer1.Panel2.Controls.Add(this.btnExitDiagramma);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(762, 100);
            this.splitContainer1.SplitterDistance = 188;
            this.splitContainer1.TabIndex = 3;
            // 
            // frmDiagramma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 496);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.zedGraph);
            this.Name = "frmDiagramma";
            this.Text = "Расходные статьи теплового баланса";
            this.Load += new System.EventHandler(this.frmDiagramma_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Button btnExitDiagramma;
        private System.Windows.Forms.Button btnDiagramma;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}