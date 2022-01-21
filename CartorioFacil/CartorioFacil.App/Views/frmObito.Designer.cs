namespace CartorioFacil.App.Views
{
    partial class frmObito
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
            this.lblDtRegistro = new System.Windows.Forms.Label();
            this.lblDataObito = new System.Windows.Forms.Label();
            this.groupBoxFalecido = new System.Windows.Forms.GroupBox();
            this.txtNomeFalecido = new System.Windows.Forms.TextBox();
            this.dtpDtNascFalecido = new System.Windows.Forms.DateTimePicker();
            this.lblDtNascFalecido = new System.Windows.Forms.Label();
            this.lblNomeFalecido = new System.Windows.Forms.Label();
            this.groupBoxPai = new System.Windows.Forms.GroupBox();
            this.txtNomePai = new System.Windows.Forms.TextBox();
            this.dtpDtNascPai = new System.Windows.Forms.DateTimePicker();
            this.lblNomePai = new System.Windows.Forms.Label();
            this.lblDtNascPai = new System.Windows.Forms.Label();
            this.groupBoxMae = new System.Windows.Forms.GroupBox();
            this.txtNomeMae = new System.Windows.Forms.TextBox();
            this.dtpDtNascMae = new System.Windows.Forms.DateTimePicker();
            this.lblDtNascMae = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDtRegistro = new System.Windows.Forms.DateTimePicker();
            this.dtpDtObito = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.groupBoxFalecido.SuspendLayout();
            this.groupBoxPai.SuspendLayout();
            this.groupBoxMae.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDtRegistro
            // 
            this.lblDtRegistro.AutoSize = true;
            this.lblDtRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtRegistro.Location = new System.Drawing.Point(43, 18);
            this.lblDtRegistro.Name = "lblDtRegistro";
            this.lblDtRegistro.Size = new System.Drawing.Size(108, 20);
            this.lblDtRegistro.TabIndex = 0;
            this.lblDtRegistro.Text = "Data Registro";
            // 
            // lblDataObito
            // 
            this.lblDataObito.AutoSize = true;
            this.lblDataObito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataObito.Location = new System.Drawing.Point(397, 18);
            this.lblDataObito.Name = "lblDataObito";
            this.lblDataObito.Size = new System.Drawing.Size(108, 20);
            this.lblDataObito.TabIndex = 1;
            this.lblDataObito.Text = "Data de Óbito";
            // 
            // groupBoxFalecido
            // 
            this.groupBoxFalecido.Controls.Add(this.txtNomeFalecido);
            this.groupBoxFalecido.Controls.Add(this.dtpDtNascFalecido);
            this.groupBoxFalecido.Controls.Add(this.lblDtNascFalecido);
            this.groupBoxFalecido.Controls.Add(this.lblNomeFalecido);
            this.groupBoxFalecido.Location = new System.Drawing.Point(47, 62);
            this.groupBoxFalecido.Name = "groupBoxFalecido";
            this.groupBoxFalecido.Size = new System.Drawing.Size(690, 74);
            this.groupBoxFalecido.TabIndex = 2;
            this.groupBoxFalecido.TabStop = false;
            this.groupBoxFalecido.Text = "Dados do Falecido";
            // 
            // txtNomeFalecido
            // 
            this.txtNomeFalecido.Location = new System.Drawing.Point(88, 29);
            this.txtNomeFalecido.Name = "txtNomeFalecido";
            this.txtNomeFalecido.Size = new System.Drawing.Size(247, 20);
            this.txtNomeFalecido.TabIndex = 6;
            // 
            // dtpDtNascFalecido
            // 
            this.dtpDtNascFalecido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtNascFalecido.Location = new System.Drawing.Point(505, 29);
            this.dtpDtNascFalecido.Name = "dtpDtNascFalecido";
            this.dtpDtNascFalecido.Size = new System.Drawing.Size(100, 20);
            this.dtpDtNascFalecido.TabIndex = 5;
            // 
            // lblDtNascFalecido
            // 
            this.lblDtNascFalecido.AutoSize = true;
            this.lblDtNascFalecido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtNascFalecido.Location = new System.Drawing.Point(350, 29);
            this.lblDtNascFalecido.Name = "lblDtNascFalecido";
            this.lblDtNascFalecido.Size = new System.Drawing.Size(132, 20);
            this.lblDtNascFalecido.TabIndex = 3;
            this.lblDtNascFalecido.Text = "Data Nascimento";
            // 
            // lblNomeFalecido
            // 
            this.lblNomeFalecido.AutoSize = true;
            this.lblNomeFalecido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFalecido.Location = new System.Drawing.Point(22, 29);
            this.lblNomeFalecido.Name = "lblNomeFalecido";
            this.lblNomeFalecido.Size = new System.Drawing.Size(51, 20);
            this.lblNomeFalecido.TabIndex = 2;
            this.lblNomeFalecido.Text = "Nome";
            // 
            // groupBoxPai
            // 
            this.groupBoxPai.Controls.Add(this.txtNomePai);
            this.groupBoxPai.Controls.Add(this.dtpDtNascPai);
            this.groupBoxPai.Controls.Add(this.lblNomePai);
            this.groupBoxPai.Controls.Add(this.lblDtNascPai);
            this.groupBoxPai.Location = new System.Drawing.Point(47, 160);
            this.groupBoxPai.Name = "groupBoxPai";
            this.groupBoxPai.Size = new System.Drawing.Size(690, 74);
            this.groupBoxPai.TabIndex = 3;
            this.groupBoxPai.TabStop = false;
            this.groupBoxPai.Text = "Dados do Pai";
            // 
            // txtNomePai
            // 
            this.txtNomePai.Location = new System.Drawing.Point(88, 32);
            this.txtNomePai.Name = "txtNomePai";
            this.txtNomePai.Size = new System.Drawing.Size(247, 20);
            this.txtNomePai.TabIndex = 7;
            // 
            // dtpDtNascPai
            // 
            this.dtpDtNascPai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtNascPai.Location = new System.Drawing.Point(505, 29);
            this.dtpDtNascPai.Name = "dtpDtNascPai";
            this.dtpDtNascPai.Size = new System.Drawing.Size(100, 20);
            this.dtpDtNascPai.TabIndex = 6;
            // 
            // lblNomePai
            // 
            this.lblNomePai.AutoSize = true;
            this.lblNomePai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePai.Location = new System.Drawing.Point(22, 29);
            this.lblNomePai.Name = "lblNomePai";
            this.lblNomePai.Size = new System.Drawing.Size(51, 20);
            this.lblNomePai.TabIndex = 2;
            this.lblNomePai.Text = "Nome";
            // 
            // lblDtNascPai
            // 
            this.lblDtNascPai.AutoSize = true;
            this.lblDtNascPai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtNascPai.Location = new System.Drawing.Point(350, 29);
            this.lblDtNascPai.Name = "lblDtNascPai";
            this.lblDtNascPai.Size = new System.Drawing.Size(132, 20);
            this.lblDtNascPai.TabIndex = 1;
            this.lblDtNascPai.Text = "Data Nascimento";
            // 
            // groupBoxMae
            // 
            this.groupBoxMae.Controls.Add(this.txtNomeMae);
            this.groupBoxMae.Controls.Add(this.dtpDtNascMae);
            this.groupBoxMae.Controls.Add(this.lblDtNascMae);
            this.groupBoxMae.Controls.Add(this.label3);
            this.groupBoxMae.Location = new System.Drawing.Point(47, 258);
            this.groupBoxMae.Name = "groupBoxMae";
            this.groupBoxMae.Size = new System.Drawing.Size(690, 74);
            this.groupBoxMae.TabIndex = 3;
            this.groupBoxMae.TabStop = false;
            this.groupBoxMae.Text = "Dados da Mãe";
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.Location = new System.Drawing.Point(88, 29);
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.Size = new System.Drawing.Size(247, 20);
            this.txtNomeMae.TabIndex = 8;
            // 
            // dtpDtNascMae
            // 
            this.dtpDtNascMae.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtNascMae.Location = new System.Drawing.Point(505, 29);
            this.dtpDtNascMae.Name = "dtpDtNascMae";
            this.dtpDtNascMae.Size = new System.Drawing.Size(100, 20);
            this.dtpDtNascMae.TabIndex = 7;
            // 
            // lblDtNascMae
            // 
            this.lblDtNascMae.AutoSize = true;
            this.lblDtNascMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtNascMae.Location = new System.Drawing.Point(350, 29);
            this.lblDtNascMae.Name = "lblDtNascMae";
            this.lblDtNascMae.Size = new System.Drawing.Size(132, 20);
            this.lblDtNascMae.TabIndex = 3;
            this.lblDtNascMae.Text = "Data Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // dtpDtRegistro
            // 
            this.dtpDtRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtRegistro.Location = new System.Drawing.Point(157, 18);
            this.dtpDtRegistro.Name = "dtpDtRegistro";
            this.dtpDtRegistro.Size = new System.Drawing.Size(100, 20);
            this.dtpDtRegistro.TabIndex = 4;
            // 
            // dtpDtObito
            // 
            this.dtpDtObito.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtObito.Location = new System.Drawing.Point(511, 18);
            this.dtpDtObito.Name = "dtpDtObito";
            this.dtpDtObito.Size = new System.Drawing.Size(100, 20);
            this.dtpDtObito.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MistyRose;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(47, 349);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(250, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(487, 349);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(250, 50);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(759, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "0";
            this.lblId.Visible = false;
            // 
            // frmObito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 425);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtpDtObito);
            this.Controls.Add(this.dtpDtRegistro);
            this.Controls.Add(this.groupBoxMae);
            this.Controls.Add(this.lblDataObito);
            this.Controls.Add(this.groupBoxPai);
            this.Controls.Add(this.groupBoxFalecido);
            this.Controls.Add(this.lblDtRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmObito";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Óbito";
            this.groupBoxFalecido.ResumeLayout(false);
            this.groupBoxFalecido.PerformLayout();
            this.groupBoxPai.ResumeLayout(false);
            this.groupBoxPai.PerformLayout();
            this.groupBoxMae.ResumeLayout(false);
            this.groupBoxMae.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDtRegistro;
        private System.Windows.Forms.Label lblDataObito;
        private System.Windows.Forms.GroupBox groupBoxFalecido;
        private System.Windows.Forms.Label lblNomeFalecido;
        private System.Windows.Forms.TextBox txtNomeFalecido;
        private System.Windows.Forms.DateTimePicker dtpDtNascFalecido;
        private System.Windows.Forms.Label lblDtNascFalecido;
        private System.Windows.Forms.GroupBox groupBoxPai;
        private System.Windows.Forms.TextBox txtNomePai;
        private System.Windows.Forms.DateTimePicker dtpDtNascPai;
        private System.Windows.Forms.Label lblNomePai;
        private System.Windows.Forms.Label lblDtNascPai;
        private System.Windows.Forms.GroupBox groupBoxMae;
        private System.Windows.Forms.TextBox txtNomeMae;
        private System.Windows.Forms.DateTimePicker dtpDtNascMae;
        private System.Windows.Forms.Label lblDtNascMae;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDtRegistro;
        private System.Windows.Forms.DateTimePicker dtpDtObito;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblId;
    }
}