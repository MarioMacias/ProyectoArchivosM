namespace Archivos
{
    partial class ConsultaEntidad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Entidad = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Datos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_SigEntidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Atributo = new System.Windows.Forms.Button();
            this.btn_regreso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Entidad
            // 
            this.dgv_Entidad.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_Entidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Entidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Entidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Dir_Entidad,
            this.Dir_Atributo,
            this.Dir_Datos,
            this.Dir_SigEntidad});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Entidad.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Entidad.Location = new System.Drawing.Point(12, 12);
            this.dgv_Entidad.Name = "dgv_Entidad";
            this.dgv_Entidad.ReadOnly = true;
            this.dgv_Entidad.Size = new System.Drawing.Size(699, 354);
            this.dgv_Entidad.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Dir_Entidad
            // 
            this.Dir_Entidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dir_Entidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dir_Entidad.HeaderText = "Dir. Entidad";
            this.Dir_Entidad.Name = "Dir_Entidad";
            this.Dir_Entidad.ReadOnly = true;
            // 
            // Dir_Atributo
            // 
            this.Dir_Atributo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dir_Atributo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dir_Atributo.HeaderText = "Dir. Atributo";
            this.Dir_Atributo.Name = "Dir_Atributo";
            this.Dir_Atributo.ReadOnly = true;
            // 
            // Dir_Datos
            // 
            this.Dir_Datos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dir_Datos.DefaultCellStyle = dataGridViewCellStyle4;
            this.Dir_Datos.HeaderText = "Dir. Datos";
            this.Dir_Datos.Name = "Dir_Datos";
            this.Dir_Datos.ReadOnly = true;
            // 
            // Dir_SigEntidad
            // 
            this.Dir_SigEntidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dir_SigEntidad.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dir_SigEntidad.HeaderText = "Dir. Siguiente Entidad";
            this.Dir_SigEntidad.Name = "Dir_SigEntidad";
            this.Dir_SigEntidad.ReadOnly = true;
            // 
            // btn_Atributo
            // 
            this.btn_Atributo.AutoSize = true;
            this.btn_Atributo.BackColor = System.Drawing.Color.Black;
            this.btn_Atributo.FlatAppearance.BorderSize = 0;
            this.btn_Atributo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atributo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Atributo.Location = new System.Drawing.Point(12, 374);
            this.btn_Atributo.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Atributo.Name = "btn_Atributo";
            this.btn_Atributo.Size = new System.Drawing.Size(127, 23);
            this.btn_Atributo.TabIndex = 8;
            this.btn_Atributo.Text = "Tabla de atributos  ";
            this.btn_Atributo.UseVisualStyleBackColor = false;
            this.btn_Atributo.Click += new System.EventHandler(this.btn_Atributo_Click);
            // 
            // btn_regreso
            // 
            this.btn_regreso.AutoSize = true;
            this.btn_regreso.BackColor = System.Drawing.Color.Black;
            this.btn_regreso.FlatAppearance.BorderSize = 0;
            this.btn_regreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regreso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_regreso.Location = new System.Drawing.Point(645, 374);
            this.btn_regreso.Margin = new System.Windows.Forms.Padding(1);
            this.btn_regreso.Name = "btn_regreso";
            this.btn_regreso.Size = new System.Drawing.Size(66, 23);
            this.btn_regreso.TabIndex = 9;
            this.btn_regreso.Text = "Regresar";
            this.btn_regreso.UseVisualStyleBackColor = false;
            this.btn_regreso.Click += new System.EventHandler(this.btn_regreso_Click);
            // 
            // ConsultaEntidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(724, 407);
            this.Controls.Add(this.btn_regreso);
            this.Controls.Add(this.btn_Atributo);
            this.Controls.Add(this.dgv_Entidad);
            this.Name = "ConsultaEntidad";
            this.Text = "ConsultaEntidad";
            this.Load += new System.EventHandler(this.ConsultaEntidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Atributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_SigEntidad;
        private System.Windows.Forms.Button btn_Atributo;
        private System.Windows.Forms.Button btn_regreso;
    }
}