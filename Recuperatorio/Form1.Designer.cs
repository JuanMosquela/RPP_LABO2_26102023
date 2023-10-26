namespace Recuperatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pcbFabrica = new PictureBox();
            btnFabricar = new Button();
            cmbTipo = new ComboBox();
            listVehiculos = new ListBox();
            btnEliminar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).BeginInit();
            SuspendLayout();
            // 
            // pcbFabrica
            // 
            pcbFabrica.Image = Properties.Resources.icons8_vehicles_64;
            pcbFabrica.Location = new Point(790, 147);
            pcbFabrica.Name = "pcbFabrica";
            pcbFabrica.Size = new Size(288, 299);
            pcbFabrica.TabIndex = 0;
            pcbFabrica.TabStop = false;
            // 
            // btnFabricar
            // 
            btnFabricar.Location = new Point(790, 478);
            btnFabricar.Name = "btnFabricar";
            btnFabricar.Size = new Size(288, 48);
            btnFabricar.TabIndex = 1;
            btnFabricar.Text = "Fabricar";
            btnFabricar.UseVisualStyleBackColor = true;
            btnFabricar.Click += btnFabricar_Click;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(790, 75);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(288, 23);
            cmbTipo.TabIndex = 2;
            cmbTipo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listVehiculos
            // 
            listVehiculos.FormattingEnabled = true;
            listVehiculos.ItemHeight = 15;
            listVehiculos.Location = new Point(33, 102);
            listVehiculos.Name = "listVehiculos";
            listVehiculos.Size = new Size(660, 499);
            listVehiculos.TabIndex = 3;
            listVehiculos.SelectedIndexChanged += listVehiculos_SelectedIndexChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(790, 545);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(288, 56);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(790, 36);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 5;
            label1.Text = "Tipo de Vehiculo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 663);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(listVehiculos);
            Controls.Add(cmbTipo);
            Controls.Add(btnFabricar);
            Controls.Add(pcbFabrica);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbFabrica;
        private Button btnFabricar;
        private ComboBox cmbTipo;
        private ListBox listVehiculos;
        private Button btnEliminar;
        private Label label1;
    }
}