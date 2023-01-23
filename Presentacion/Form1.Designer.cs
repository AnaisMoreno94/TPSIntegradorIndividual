namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridPacientes = new System.Windows.Forms.DataGridView();
            this.gridMedicos = new System.Windows.Forms.DataGridView();
            this.listMedicos = new System.Windows.Forms.ListBox();
            this.listHabitaciones = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPacientes
            // 
            this.gridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacientes.Location = new System.Drawing.Point(71, 45);
            this.gridPacientes.Name = "gridPacientes";
            this.gridPacientes.RowHeadersWidth = 51;
            this.gridPacientes.RowTemplate.Height = 29;
            this.gridPacientes.Size = new System.Drawing.Size(410, 175);
            this.gridPacientes.TabIndex = 0;
            // 
            // gridMedicos
            // 
            this.gridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedicos.Location = new System.Drawing.Point(71, 231);
            this.gridMedicos.Name = "gridMedicos";
            this.gridMedicos.RowHeadersWidth = 51;
            this.gridMedicos.RowTemplate.Height = 29;
            this.gridMedicos.Size = new System.Drawing.Size(410, 188);
            this.gridMedicos.TabIndex = 1;
            // 
            // listMedicos
            // 
            this.listMedicos.FormattingEnabled = true;
            this.listMedicos.ItemHeight = 20;
            this.listMedicos.Location = new System.Drawing.Point(572, 58);
            this.listMedicos.Name = "listMedicos";
            this.listMedicos.Size = new System.Drawing.Size(337, 104);
            this.listMedicos.TabIndex = 2;
            // 
            // listHabitaciones
            // 
            this.listHabitaciones.FormattingEnabled = true;
            this.listHabitaciones.ItemHeight = 20;
            this.listHabitaciones.Location = new System.Drawing.Point(572, 250);
            this.listHabitaciones.Name = "listHabitaciones";
            this.listHabitaciones.Size = new System.Drawing.Size(337, 104);
            this.listHabitaciones.TabIndex = 3;
            this.listHabitaciones.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 450);
            this.Controls.Add(this.listHabitaciones);
            this.Controls.Add(this.listMedicos);
            this.Controls.Add(this.gridMedicos);
            this.Controls.Add(this.gridPacientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView gridPacientes;
        private DataGridView gridMedicos;
        private ListBox listMedicos;
        private ListBox listHabitaciones;
    }
}