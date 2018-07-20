namespace LibrosBiblicos.UI.Reportes
{
    partial class LibrosBibliasReportViewer
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
            this.LibrosBiblicosReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // LibrosBiblicosReportViewer
            // 
            this.LibrosBiblicosReportViewer.ActiveViewIndex = -1;
            this.LibrosBiblicosReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LibrosBiblicosReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.LibrosBiblicosReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibrosBiblicosReportViewer.Location = new System.Drawing.Point(0, 0);
            this.LibrosBiblicosReportViewer.Name = "LibrosBiblicosReportViewer";
            this.LibrosBiblicosReportViewer.Size = new System.Drawing.Size(536, 455);
            this.LibrosBiblicosReportViewer.TabIndex = 0;
            this.LibrosBiblicosReportViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // LibrosBibliasReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 455);
            this.Controls.Add(this.LibrosBiblicosReportViewer);
            this.Name = "LibrosBibliasReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrosBibliasReportViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LibrosBibliasReportViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer LibrosBiblicosReportViewer;
    }
}