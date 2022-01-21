
namespace CartorioFacil.App.Views
{
    partial class fmrExpRelCasamento
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
            this.btnExportar = new System.Windows.Forms.Button();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.lblDtFim = new System.Windows.Forms.Label();
            this.lblDtInicio = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(88, 111);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(150, 50);
            this.btnExportar.TabIndex = 19;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(163, 70);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(111, 20);
            this.dtpFim.TabIndex = 18;
            // 
            // lblDtFim
            // 
            this.lblDtFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtFim.Location = new System.Drawing.Point(32, 59);
            this.lblDtFim.Name = "lblDtFim";
            this.lblDtFim.Size = new System.Drawing.Size(100, 40);
            this.lblDtFim.TabIndex = 17;
            this.lblDtFim.Text = "Dt Fim";
            this.lblDtFim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDtInicio
            // 
            this.lblDtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtInicio.Location = new System.Drawing.Point(32, 18);
            this.lblDtInicio.Name = "lblDtInicio";
            this.lblDtInicio.Size = new System.Drawing.Size(100, 40);
            this.lblDtInicio.TabIndex = 16;
            this.lblDtInicio.Text = "Dt Início";
            this.lblDtInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpInicio
            // 
            this.dtpInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(163, 29);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(111, 20);
            this.dtpInicio.TabIndex = 15;
            // 
            // fmrExpRelCasamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 179);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.lblDtFim);
            this.Controls.Add(this.lblDtInicio);
            this.Controls.Add(this.dtpInicio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmrExpRelCasamento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar Relatório de Casamentos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label lblDtFim;
        private System.Windows.Forms.Label lblDtInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
    }
}