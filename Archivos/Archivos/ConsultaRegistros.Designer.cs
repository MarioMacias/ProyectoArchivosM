namespace Archivos
{
    partial class ConsultaRegistros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_regresaEntidad = new System.Windows.Forms.Button();
            this.dgv_Registro = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Filtrar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registro)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_regresaEntidad
            // 
            this.btn_regresaEntidad.AutoSize = true;
            this.btn_regresaEntidad.BackColor = System.Drawing.Color.Black;
            this.btn_regresaEntidad.FlatAppearance.BorderSize = 0;
            this.btn_regresaEntidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresaEntidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_regresaEntidad.Location = new System.Drawing.Point(691, 358);
            this.btn_regresaEntidad.Margin = new System.Windows.Forms.Padding(1);
            this.btn_regresaEntidad.Name = "btn_regresaEntidad";
            this.btn_regresaEntidad.Size = new System.Drawing.Size(127, 23);
            this.btn_regresaEntidad.TabIndex = 10;
            this.btn_regresaEntidad.Text = "Tabla de entidades";
            this.btn_regresaEntidad.UseVisualStyleBackColor = false;
            this.btn_regresaEntidad.Click += new System.EventHandler(this.btn_regresaEntidad_Click);
            // 
            // dgv_Registro
            // 
            this.dgv_Registro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Registro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Registro.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Registro.Location = new System.Drawing.Point(12, 12);
            this.dgv_Registro.Name = "dgv_Registro";
            this.dgv_Registro.Size = new System.Drawing.Size(806, 342);
            this.dgv_Registro.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar:";
            // 
            // tb_Buscar
            // 
            this.tb_Buscar.Location = new System.Drawing.Point(89, 360);
            this.tb_Buscar.Name = "tb_Buscar";
            this.tb_Buscar.Size = new System.Drawing.Size(402, 20);
            this.tb_Buscar.TabIndex = 12;
            this.tb_Buscar.TextChanged += new System.EventHandler(this.tb_Buscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(497, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Filtrar:";
            // 
            // cb_Filtrar
            // 
            this.cb_Filtrar.FormattingEnabled = true;
            this.cb_Filtrar.Location = new System.Drawing.Point(564, 358);
            this.cb_Filtrar.Name = "cb_Filtrar";
            this.cb_Filtrar.Size = new System.Drawing.Size(123, 21);
            this.cb_Filtrar.TabIndex = 14;
            this.cb_Filtrar.SelectedIndexChanged += new System.EventHandler(this.cb_Filtrar_SelectedIndexChanged);
            // 
            // ConsultaRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(830, 389);
            this.Controls.Add(this.cb_Filtrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_regresaEntidad);
            this.Controls.Add(this.dgv_Registro);
            this.Name = "ConsultaRegistros";
            this.Text = "ConsultaRegistros";
            this.Load += new System.EventHandler(this.ConsultaRegistros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regresaEntidad;
        private System.Windows.Forms.DataGridView dgv_Registro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Filtrar;
    }
}