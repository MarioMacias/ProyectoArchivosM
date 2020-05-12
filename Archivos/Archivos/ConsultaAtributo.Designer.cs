namespace Archivos
{
    partial class ConsultaAtributo
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
            this.dgv_Atributo = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_Dato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.long_Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Atributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_sigAtributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_regreso = new System.Windows.Forms.Button();
            this.cb_Entidades = new System.Windows.Forms.ComboBox();
            this.btn_aceptarEntidad = new System.Windows.Forms.Button();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.tb_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Filtro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Atributo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Atributo
            // 
            this.dgv_Atributo.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_Atributo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Atributo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Atributo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.tipo_Dato,
            this.long_Atributo,
            this.Dir_Atributo,
            this.tipo_Indice,
            this.Dir_Indice,
            this.Dir_sigAtributo});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Atributo.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Atributo.Location = new System.Drawing.Point(12, 12);
            this.dgv_Atributo.Name = "dgv_Atributo";
            this.dgv_Atributo.ReadOnly = true;
            this.dgv_Atributo.Size = new System.Drawing.Size(842, 330);
            this.dgv_Atributo.TabIndex = 4;
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
            // tipo_Dato
            // 
            this.tipo_Dato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tipo_Dato.DefaultCellStyle = dataGridViewCellStyle2;
            this.tipo_Dato.HeaderText = "Tipo Dato";
            this.tipo_Dato.Name = "tipo_Dato";
            this.tipo_Dato.ReadOnly = true;
            // 
            // long_Atributo
            // 
            this.long_Atributo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.long_Atributo.DefaultCellStyle = dataGridViewCellStyle3;
            this.long_Atributo.HeaderText = "Longitud";
            this.long_Atributo.Name = "long_Atributo";
            this.long_Atributo.ReadOnly = true;
            // 
            // Dir_Atributo
            // 
            this.Dir_Atributo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dir_Atributo.DefaultCellStyle = dataGridViewCellStyle4;
            this.Dir_Atributo.HeaderText = "Dir. Atributo";
            this.Dir_Atributo.Name = "Dir_Atributo";
            this.Dir_Atributo.ReadOnly = true;
            // 
            // tipo_Indice
            // 
            this.tipo_Indice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tipo_Indice.DefaultCellStyle = dataGridViewCellStyle5;
            this.tipo_Indice.HeaderText = "Tipo de Indice";
            this.tipo_Indice.Name = "tipo_Indice";
            this.tipo_Indice.ReadOnly = true;
            // 
            // Dir_Indice
            // 
            this.Dir_Indice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dir_Indice.HeaderText = "Dir. Indice";
            this.Dir_Indice.Name = "Dir_Indice";
            this.Dir_Indice.ReadOnly = true;
            // 
            // Dir_sigAtributo
            // 
            this.Dir_sigAtributo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dir_sigAtributo.HeaderText = "Dir. Siguiente Atributo";
            this.Dir_sigAtributo.Name = "Dir_sigAtributo";
            this.Dir_sigAtributo.ReadOnly = true;
            // 
            // btn_regreso
            // 
            this.btn_regreso.AutoSize = true;
            this.btn_regreso.BackColor = System.Drawing.Color.Black;
            this.btn_regreso.FlatAppearance.BorderSize = 0;
            this.btn_regreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regreso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_regreso.Location = new System.Drawing.Point(787, 346);
            this.btn_regreso.Margin = new System.Windows.Forms.Padding(1);
            this.btn_regreso.Name = "btn_regreso";
            this.btn_regreso.Size = new System.Drawing.Size(66, 23);
            this.btn_regreso.TabIndex = 10;
            this.btn_regreso.Text = "Regresar";
            this.btn_regreso.UseVisualStyleBackColor = false;
            this.btn_regreso.Click += new System.EventHandler(this.btn_regreso_Click);
            // 
            // cb_Entidades
            // 
            this.cb_Entidades.FormattingEnabled = true;
            this.cb_Entidades.Location = new System.Drawing.Point(520, 350);
            this.cb_Entidades.Name = "cb_Entidades";
            this.cb_Entidades.Size = new System.Drawing.Size(121, 21);
            this.cb_Entidades.TabIndex = 20;
            // 
            // btn_aceptarEntidad
            // 
            this.btn_aceptarEntidad.BackColor = System.Drawing.Color.Black;
            this.btn_aceptarEntidad.FlatAppearance.BorderSize = 0;
            this.btn_aceptarEntidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptarEntidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_aceptarEntidad.Location = new System.Drawing.Point(656, 348);
            this.btn_aceptarEntidad.Margin = new System.Windows.Forms.Padding(1);
            this.btn_aceptarEntidad.Name = "btn_aceptarEntidad";
            this.btn_aceptarEntidad.Size = new System.Drawing.Size(114, 23);
            this.btn_aceptarEntidad.TabIndex = 21;
            this.btn_aceptarEntidad.Text = "Cambiar";
            this.btn_aceptarEntidad.UseVisualStyleBackColor = false;
            this.btn_aceptarEntidad.Click += new System.EventHandler(this.btn_aceptarEntidad_Click);
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Buscar.Location = new System.Drawing.Point(12, 351);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(70, 20);
            this.lbl_Buscar.TabIndex = 23;
            this.lbl_Buscar.Text = "Buscar:";
            // 
            // tb_Buscar
            // 
            this.tb_Buscar.Location = new System.Drawing.Point(88, 350);
            this.tb_Buscar.Name = "tb_Buscar";
            this.tb_Buscar.Size = new System.Drawing.Size(189, 20);
            this.tb_Buscar.TabIndex = 22;
            this.tb_Buscar.TextChanged += new System.EventHandler(this.tb_Buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(438, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Entidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(283, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Filtro:";
            // 
            // cb_Filtro
            // 
            this.cb_Filtro.FormattingEnabled = true;
            this.cb_Filtro.Items.AddRange(new object[] {
            "Nombre",
            "Tipo Dato",
            "Longitud",
            "Tipo de indice"});
            this.cb_Filtro.Location = new System.Drawing.Point(345, 349);
            this.cb_Filtro.Name = "cb_Filtro";
            this.cb_Filtro.Size = new System.Drawing.Size(79, 21);
            this.cb_Filtro.TabIndex = 26;
            this.cb_Filtro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ConsultaAtributo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(863, 377);
            this.Controls.Add(this.cb_Filtro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Buscar);
            this.Controls.Add(this.tb_Buscar);
            this.Controls.Add(this.btn_aceptarEntidad);
            this.Controls.Add(this.cb_Entidades);
            this.Controls.Add(this.btn_regreso);
            this.Controls.Add(this.dgv_Atributo);
            this.Name = "ConsultaAtributo";
            this.Text = "ConsultaAtributo";
            this.Load += new System.EventHandler(this.ConsultaAtributo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Atributo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Atributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_Dato;
        private System.Windows.Forms.DataGridViewTextBoxColumn long_Atributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Atributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_sigAtributo;
        private System.Windows.Forms.Button btn_regreso;
        private System.Windows.Forms.ComboBox cb_Entidades;
        private System.Windows.Forms.Button btn_aceptarEntidad;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.TextBox tb_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Filtro;
    }
}