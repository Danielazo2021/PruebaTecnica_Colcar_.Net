namespace PruebaTecnica_Colcar
{
    partial class Multas_Form
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
            label1 = new Label();
            label2 = new Label();
            txtDni = new TextBox();
            groupBox1 = new GroupBox();
            btnLimpiarFiltro = new Button();
            btnFiltrar = new Button();
            label4 = new Label();
            dgvMultas = new DataGridView();
            PonerFechaPago = new DataGridViewButtonColumn();
            label3 = new Label();
            gbxDatosPago = new GroupBox();
            calendar = new MonthCalendar();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMultas).BeginInit();
            gbxDatosPago.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(304, 11);
            label1.Name = "label1";
            label1.Size = new Size(251, 41);
            label1.TabIndex = 0;
            label1.Text = "Listado de multas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(175, 140);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 1;
            label2.Text = "Filtrar por DNI";
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(321, 140);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(156, 29);
            txtDni.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLimpiarFiltro);
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dgvMultas);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Location = new Point(12, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(969, 626);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // btnLimpiarFiltro
            // 
            btnLimpiarFiltro.Location = new Point(668, 140);
            btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            btnLimpiarFiltro.Size = new Size(119, 31);
            btnLimpiarFiltro.TabIndex = 6;
            btnLimpiarFiltro.Text = "Borrar Filtro";
            btnLimpiarFiltro.UseVisualStyleBackColor = true;
            btnLimpiarFiltro.Click += btnLimpiarFiltro_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(521, 138);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(119, 31);
            btnFiltrar.TabIndex = 5;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(200, 83);
            label4.Name = "label4";
            label4.Size = new Size(481, 25);
            label4.TabIndex = 4;
            label4.Text = "Atención!! seleccione la fecha antes de registrar el pago";
            // 
            // dgvMultas
            // 
            dgvMultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMultas.Columns.AddRange(new DataGridViewColumn[] { PonerFechaPago });
            dgvMultas.Location = new Point(28, 175);
            dgvMultas.Name = "dgvMultas";
            dgvMultas.RowTemplate.Height = 25;
            dgvMultas.Size = new Size(853, 432);
            dgvMultas.TabIndex = 3;
            // 
            // PonerFechaPago
            // 
            PonerFechaPago.HeaderText = "MARCAR COMO PAGADA";
            PonerFechaPago.Name = "PonerFechaPago";
            PonerFechaPago.Text = "Poner pagado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 28);
            label3.Name = "label3";
            label3.Size = new Size(243, 21);
            label3.TabIndex = 5;
            label3.Text = "Ingrese la fecha en la que se pagó";
            // 
            // gbxDatosPago
            // 
            gbxDatosPago.Controls.Add(calendar);
            gbxDatosPago.Controls.Add(label3);
            gbxDatosPago.Location = new Point(1020, 114);
            gbxDatosPago.Name = "gbxDatosPago";
            gbxDatosPago.Size = new Size(325, 295);
            gbxDatosPago.TabIndex = 6;
            gbxDatosPago.TabStop = false;
            gbxDatosPago.Text = "Fecha de pago";
            // 
            // calendar
            // 
            calendar.Location = new Point(43, 94);
            calendar.Name = "calendar";
            calendar.TabIndex = 6;
            // 
            // Multas_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 669);
            Controls.Add(gbxDatosPago);
            Controls.Add(groupBox1);
            Name = "Multas_Form";
            Text = "Entrevista Técnica Colcar - Grecco Daniel";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMultas).EndInit();
            gbxDatosPago.ResumeLayout(false);
            gbxDatosPago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDni;
        private GroupBox groupBox1;
        private DataGridView dgvMultas;
        private Label label3;
        private GroupBox gbxDatosPago;
        private MonthCalendar calendar;
        private Label label4;
        private Button btnFiltrar;
        private Button btnLimpiarFiltro;
        private DataGridViewButtonColumn PonerFechaPago;
    }
}