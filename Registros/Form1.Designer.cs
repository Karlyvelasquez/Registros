namespace Registros
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.btnPorLinea = new System.Windows.Forms.Button();
            this.btnCSV = new System.Windows.Forms.Button();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(96, 60);
            this.txtLinea.Multiline = true;
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(261, 245);
            this.txtLinea.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dtgDatos
            // 
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3});
            this.dtgDatos.Location = new System.Drawing.Point(381, 60);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.Size = new System.Drawing.Size(348, 245);
            this.dtgDatos.TabIndex = 2;
            // 
            // btnPorLinea
            // 
            this.btnPorLinea.Location = new System.Drawing.Point(247, 347);
            this.btnPorLinea.Name = "btnPorLinea";
            this.btnPorLinea.Size = new System.Drawing.Size(107, 42);
            this.btnPorLinea.TabIndex = 3;
            this.btnPorLinea.Text = "Linea a Linea";
            this.btnPorLinea.UseVisualStyleBackColor = true;
            this.btnPorLinea.Click += new System.EventHandler(this.btnPorLinea_Click);
            // 
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(395, 349);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(95, 40);
            this.btnCSV.TabIndex = 4;
            this.btnCSV.Text = "CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // Col1
            // 
            this.Col1.HeaderText = "Column1";
            this.Col1.Name = "Col1";
            // 
            // Col2
            // 
            this.Col2.HeaderText = "Column2";
            this.Col2.Name = "Col2";
            // 
            // Col3
            // 
            this.Col3.HeaderText = "Column3";
            this.Col3.Name = "Col3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.btnPorLinea);
            this.Controls.Add(this.dtgDatos);
            this.Controls.Add(this.txtLinea);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.Button btnPorLinea;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
    }
}

