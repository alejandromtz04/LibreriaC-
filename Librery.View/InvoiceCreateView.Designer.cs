namespace Librery.view
{
    partial class InvoiceCreateView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBranchAddress = new System.Windows.Forms.TextBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.comboBoxProductList = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployeeName = new System.Windows.Forms.ComboBox();
            this.comboBoxClientName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva factura";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ubicacion de compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion de factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de articulos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de facturacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vendido por";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(636, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Facturado a (no registrado)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(636, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Facturado a (registrado)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Producto a vender";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(658, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 52);
            this.button2.TabIndex = 12;
            this.button2.Text = "Generar factura";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBranchAddress
            // 
            this.txtBranchAddress.Location = new System.Drawing.Point(273, 95);
            this.txtBranchAddress.Name = "txtBranchAddress";
            this.txtBranchAddress.Size = new System.Drawing.Size(250, 22);
            this.txtBranchAddress.TabIndex = 13;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(273, 237);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 22);
            this.numQuantity.TabIndex = 15;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(273, 321);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(250, 22);
            this.dtpDate.TabIndex = 16;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(871, 98);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(250, 22);
            this.txtGuestName.TabIndex = 18;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(871, 244);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(250, 22);
            this.txtDescription.TabIndex = 20;
            // 
            // comboBoxProductList
            // 
            this.comboBoxProductList.FormattingEnabled = true;
            this.comboBoxProductList.Location = new System.Drawing.Point(272, 169);
            this.comboBoxProductList.Name = "comboBoxProductList";
            this.comboBoxProductList.Size = new System.Drawing.Size(251, 24);
            this.comboBoxProductList.TabIndex = 22;
            this.comboBoxProductList.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductList_SelectedIndexChanged);
            // 
            // comboBoxEmployeeName
            // 
            this.comboBoxEmployeeName.FormattingEnabled = true;
            this.comboBoxEmployeeName.Location = new System.Drawing.Point(273, 393);
            this.comboBoxEmployeeName.Name = "comboBoxEmployeeName";
            this.comboBoxEmployeeName.Size = new System.Drawing.Size(250, 24);
            this.comboBoxEmployeeName.TabIndex = 23;
            this.comboBoxEmployeeName.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployeeName_SelectedIndexChanged);
            // 
            // comboBoxClientName
            // 
            this.comboBoxClientName.FormattingEnabled = true;
            this.comboBoxClientName.Location = new System.Drawing.Point(871, 160);
            this.comboBoxClientName.Name = "comboBoxClientName";
            this.comboBoxClientName.Size = new System.Drawing.Size(250, 24);
            this.comboBoxClientName.TabIndex = 24;
            this.comboBoxClientName.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientName_SelectedIndexChanged);
            // 
            // InvoiceCreateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 688);
            this.Controls.Add(this.comboBoxClientName);
            this.Controls.Add(this.comboBoxEmployeeName);
            this.Controls.Add(this.comboBoxProductList);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.txtBranchAddress);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InvoiceCreateView";
            this.Text = "InvoiceCreateView";
            this.Load += new System.EventHandler(this.InvoiceCreateView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBranchAddress;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox comboBoxProductList;
        private System.Windows.Forms.ComboBox comboBoxEmployeeName;
        private System.Windows.Forms.ComboBox comboBoxClientName;
    }
}