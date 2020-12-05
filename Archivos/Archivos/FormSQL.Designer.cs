namespace Archivos
{
    partial class FormSQL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Consulta = new System.Windows.Forms.DataGridView();
            this.btn_Ejecutar = new System.Windows.Forms.Button();
            this.rtb_Comando = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Consulta
            // 
            this.dgv_Consulta.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_Consulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Consulta.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Consulta.Location = new System.Drawing.Point(10, 272);
            this.dgv_Consulta.Name = "dgv_Consulta";
            this.dgv_Consulta.ReadOnly = true;
            this.dgv_Consulta.Size = new System.Drawing.Size(699, 210);
            this.dgv_Consulta.TabIndex = 1;
            // 
            // btn_Ejecutar
            // 
            this.btn_Ejecutar.AutoSize = true;
            this.btn_Ejecutar.BackColor = System.Drawing.Color.Black;
            this.btn_Ejecutar.FlatAppearance.BorderSize = 0;
            this.btn_Ejecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ejecutar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Ejecutar.Location = new System.Drawing.Point(290, 10);
            this.btn_Ejecutar.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Ejecutar.Name = "btn_Ejecutar";
            this.btn_Ejecutar.Size = new System.Drawing.Size(135, 38);
            this.btn_Ejecutar.TabIndex = 8;
            this.btn_Ejecutar.Text = "Ejecutar SQL  ";
            this.btn_Ejecutar.UseVisualStyleBackColor = false;
            this.btn_Ejecutar.Click += new System.EventHandler(this.btn_Ejecutar_Click);
            // 
            // rtb_Comando
            // 
            this.rtb_Comando.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Comando.Location = new System.Drawing.Point(12, 52);
            this.rtb_Comando.Name = "rtb_Comando";
            this.rtb_Comando.Size = new System.Drawing.Size(697, 214);
            this.rtb_Comando.TabIndex = 2;
            this.rtb_Comando.Text = "";
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(721, 494);
            this.Controls.Add(this.btn_Ejecutar);
            this.Controls.Add(this.rtb_Comando);
            this.Controls.Add(this.dgv_Consulta);
            this.Name = "FormSQL";
            this.Text = "Consulta SQL";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Consulta;
        private System.Windows.Forms.Button btn_Ejecutar;
        private System.Windows.Forms.RichTextBox rtb_Comando;
    }
}