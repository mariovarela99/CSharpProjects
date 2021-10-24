namespace Exercicio_Aula_27_28
{
    partial class Form1
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
            this.btnLer = new System.Windows.Forms.Button();
            this.dgvValores = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(176, 284);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(124, 37);
            this.btnLer.TabIndex = 0;
            this.btnLer.Text = "Ler Valores";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // dgvValores
            // 
            this.dgvValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3});
            this.dgvValores.Location = new System.Drawing.Point(70, 94);
            this.dgvValores.Name = "dgvValores";
            this.dgvValores.Size = new System.Drawing.Size(347, 170);
            this.dgvValores.TabIndex = 1;
            // 
            // col1
            // 
            this.col1.HeaderText = "Coluna 0";
            this.col1.Name = "col1";
            // 
            // col2
            // 
            this.col2.HeaderText = "Coluna 2";
            this.col2.Name = "col2";
            // 
            // col3
            // 
            this.col3.HeaderText = "Coluna 3";
            this.col3.Name = "col3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 333);
            this.Controls.Add(this.dgvValores);
            this.Controls.Add(this.btnLer);
            this.Name = "Form1";
            this.Text = "Exercicio Aula 27 28";
            ((System.ComponentModel.ISupportInitialize)(this.dgvValores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.DataGridView dgvValores;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
    }
}

