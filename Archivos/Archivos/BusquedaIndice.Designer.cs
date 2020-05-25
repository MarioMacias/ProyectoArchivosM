namespace Archivos
{
    partial class BusquedaIndice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_IndicePrimario = new System.Windows.Forms.DataGridView();
            this.lbl_primario = new System.Windows.Forms.Label();
            this.dgv_Direcciones = new System.Windows.Forms.DataGridView();
            this.dgv_IndiceSecundario = new System.Windows.Forms.DataGridView();
            this.lbl_secundario = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.cb_Filtrar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Registro = new System.Windows.Forms.DataGridView();
            this.btn_ActualizaIndice = new System.Windows.Forms.Button();
            this.tb_primario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_secundario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IndicePrimario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Direcciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IndiceSecundario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_IndicePrimario
            // 
            this.dgv_IndicePrimario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_IndicePrimario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IndicePrimario.Location = new System.Drawing.Point(18, 287);
            this.dgv_IndicePrimario.Name = "dgv_IndicePrimario";
            this.dgv_IndicePrimario.Size = new System.Drawing.Size(210, 187);
            this.dgv_IndicePrimario.TabIndex = 2;
            // 
            // lbl_primario
            // 
            this.lbl_primario.AutoSize = true;
            this.lbl_primario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_primario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_primario.Location = new System.Drawing.Point(53, 247);
            this.lbl_primario.Name = "lbl_primario";
            this.lbl_primario.Size = new System.Drawing.Size(134, 24);
            this.lbl_primario.TabIndex = 3;
            this.lbl_primario.Text = "Indice primario";
            // 
            // dgv_Direcciones
            // 
            this.dgv_Direcciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Direcciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Direcciones.Location = new System.Drawing.Point(468, 287);
            this.dgv_Direcciones.Name = "dgv_Direcciones";
            this.dgv_Direcciones.ReadOnly = true;
            this.dgv_Direcciones.Size = new System.Drawing.Size(205, 187);
            this.dgv_Direcciones.TabIndex = 14;
            // 
            // dgv_IndiceSecundario
            // 
            this.dgv_IndiceSecundario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_IndiceSecundario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IndiceSecundario.Location = new System.Drawing.Point(243, 287);
            this.dgv_IndiceSecundario.Name = "dgv_IndiceSecundario";
            this.dgv_IndiceSecundario.ReadOnly = true;
            this.dgv_IndiceSecundario.Size = new System.Drawing.Size(208, 187);
            this.dgv_IndiceSecundario.TabIndex = 13;
            this.dgv_IndiceSecundario.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_IndiceSecundario_CellMouseDoubleClick);
            this.dgv_IndiceSecundario.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_IndiceSecundario_CellMouseDown);
            // 
            // lbl_secundario
            // 
            this.lbl_secundario.AutoSize = true;
            this.lbl_secundario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_secundario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_secundario.Location = new System.Drawing.Point(268, 247);
            this.lbl_secundario.Name = "lbl_secundario";
            this.lbl_secundario.Size = new System.Drawing.Size(163, 24);
            this.lbl_secundario.TabIndex = 17;
            this.lbl_secundario.Text = "Indice Secundario";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_direccion.Location = new System.Drawing.Point(482, 247);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(90, 24);
            this.lbl_direccion.TabIndex = 18;
            this.lbl_direccion.Text = "Dirección";
            // 
            // cb_Filtrar
            // 
            this.cb_Filtrar.FormattingEnabled = true;
            this.cb_Filtrar.Location = new System.Drawing.Point(468, 194);
            this.cb_Filtrar.Name = "cb_Filtrar";
            this.cb_Filtrar.Size = new System.Drawing.Size(104, 21);
            this.cb_Filtrar.TabIndex = 23;
            this.cb_Filtrar.SelectedIndexChanged += new System.EventHandler(this.cb_Filtrar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(401, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Filtrar:";
            // 
            // tb_Buscar
            // 
            this.tb_Buscar.Location = new System.Drawing.Point(94, 198);
            this.tb_Buscar.Name = "tb_Buscar";
            this.tb_Buscar.Size = new System.Drawing.Size(301, 20);
            this.tb_Buscar.TabIndex = 21;
            this.tb_Buscar.TextChanged += new System.EventHandler(this.tb_Buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(17, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Buscar:";
            // 
            // dgv_Registro
            // 
            this.dgv_Registro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Registro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Registro.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Registro.Location = new System.Drawing.Point(18, 12);
            this.dgv_Registro.Name = "dgv_Registro";
            this.dgv_Registro.Size = new System.Drawing.Size(655, 162);
            this.dgv_Registro.TabIndex = 19;
            // 
            // btn_ActualizaIndice
            // 
            this.btn_ActualizaIndice.AutoSize = true;
            this.btn_ActualizaIndice.BackColor = System.Drawing.Color.Black;
            this.btn_ActualizaIndice.FlatAppearance.BorderSize = 0;
            this.btn_ActualizaIndice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ActualizaIndice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ActualizaIndice.Location = new System.Drawing.Point(587, 194);
            this.btn_ActualizaIndice.Margin = new System.Windows.Forms.Padding(1);
            this.btn_ActualizaIndice.Name = "btn_ActualizaIndice";
            this.btn_ActualizaIndice.Size = new System.Drawing.Size(86, 23);
            this.btn_ActualizaIndice.TabIndex = 24;
            this.btn_ActualizaIndice.Text = "Ver Indices";
            this.btn_ActualizaIndice.UseVisualStyleBackColor = false;
            this.btn_ActualizaIndice.Click += new System.EventHandler(this.btn_ActualizaIndice_Click);
            // 
            // tb_primario
            // 
            this.tb_primario.Location = new System.Drawing.Point(94, 487);
            this.tb_primario.Name = "tb_primario";
            this.tb_primario.Size = new System.Drawing.Size(134, 20);
            this.tb_primario.TabIndex = 25;
            this.tb_primario.TextChanged += new System.EventHandler(this.tb_primario_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(17, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Buscar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(352, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Buscar:";
            // 
            // tb_secundario
            // 
            this.tb_secundario.Location = new System.Drawing.Point(429, 487);
            this.tb_secundario.Name = "tb_secundario";
            this.tb_secundario.Size = new System.Drawing.Size(134, 20);
            this.tb_secundario.TabIndex = 27;
            this.tb_secundario.TextChanged += new System.EventHandler(this.tb_secundario_TextChanged);
            // 
            // BusquedaIndice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(692, 516);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_secundario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_primario);
            this.Controls.Add(this.btn_ActualizaIndice);
            this.Controls.Add(this.cb_Filtrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Registro);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_secundario);
            this.Controls.Add(this.dgv_Direcciones);
            this.Controls.Add(this.dgv_IndiceSecundario);
            this.Controls.Add(this.lbl_primario);
            this.Controls.Add(this.dgv_IndicePrimario);
            this.Name = "BusquedaIndice";
            this.Text = "Busqueda de indices";
            this.Load += new System.EventHandler(this.BusquedaIndice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IndicePrimario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Direcciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IndiceSecundario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Registro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_IndicePrimario;
        private System.Windows.Forms.Label lbl_primario;
        private System.Windows.Forms.DataGridView dgv_Direcciones;
        private System.Windows.Forms.DataGridView dgv_IndiceSecundario;
        private System.Windows.Forms.Label lbl_secundario;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.ComboBox cb_Filtrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Registro;
        private System.Windows.Forms.Button btn_ActualizaIndice;
        private System.Windows.Forms.TextBox tb_primario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_secundario;
    }
}