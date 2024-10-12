namespace Librery.View
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnmodifiicar = new Button();
            btnagregar = new Button();
            btnnuevo = new Button();
            btnelminar = new Button();
            direccon = new TextBox();
            edad = new TextBox();
            email = new TextBox();
            apellido = new TextBox();
            nombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            telefono = new TextBox();
            lbltel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(396, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 357);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro actual";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(353, 313);
            dataGridView1.TabIndex = 0;
            // 
            // btnmodifiicar
            // 
            btnmodifiicar.BackgroundImage = (Image)resources.GetObject("btnmodifiicar.BackgroundImage");
            btnmodifiicar.BackgroundImageLayout = ImageLayout.None;
            btnmodifiicar.Location = new Point(203, 333);
            btnmodifiicar.Name = "btnmodifiicar";
            btnmodifiicar.Size = new Size(42, 40);
            btnmodifiicar.TabIndex = 36;
            btnmodifiicar.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            btnagregar.BackgroundImage = (Image)resources.GetObject("btnagregar.BackgroundImage");
            btnagregar.BackgroundImageLayout = ImageLayout.None;
            btnagregar.Location = new Point(135, 333);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(41, 41);
            btnagregar.TabIndex = 35;
            btnagregar.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            btnnuevo.BackgroundImage = (Image)resources.GetObject("btnnuevo.BackgroundImage");
            btnnuevo.BackgroundImageLayout = ImageLayout.None;
            btnnuevo.Location = new Point(135, 385);
            btnnuevo.Name = "btnnuevo";
            btnnuevo.Size = new Size(41, 41);
            btnnuevo.TabIndex = 34;
            btnnuevo.UseVisualStyleBackColor = true;
            // 
            // btnelminar
            // 
            btnelminar.BackgroundImage = (Image)resources.GetObject("btnelminar.BackgroundImage");
            btnelminar.BackgroundImageLayout = ImageLayout.None;
            btnelminar.Location = new Point(203, 385);
            btnelminar.Name = "btnelminar";
            btnelminar.Size = new Size(41, 41);
            btnelminar.TabIndex = 33;
            btnelminar.UseVisualStyleBackColor = true;
            // 
            // direccon
            // 
            direccon.Location = new Point(147, 246);
            direccon.Name = "direccon";
            direccon.Size = new Size(220, 23);
            direccon.TabIndex = 32;
            // 
            // edad
            // 
            edad.Location = new Point(147, 206);
            edad.Name = "edad";
            edad.Size = new Size(220, 23);
            edad.TabIndex = 31;
            // 
            // email
            // 
            email.Location = new Point(147, 166);
            email.Name = "email";
            email.Size = new Size(220, 23);
            email.TabIndex = 30;
            // 
            // apellido
            // 
            apellido.Location = new Point(147, 127);
            apellido.Name = "apellido";
            apellido.Size = new Size(220, 23);
            apellido.TabIndex = 29;
            // 
            // nombre
            // 
            nombre.Location = new Point(147, 83);
            nombre.Name = "nombre";
            nombre.Size = new Size(220, 23);
            nombre.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stilu", 14.25F);
            label6.Location = new Point(18, 244);
            label6.Name = "label6";
            label6.Size = new Size(97, 24);
            label6.TabIndex = 27;
            label6.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stilu", 14.25F);
            label5.Location = new Point(18, 207);
            label5.Name = "label5";
            label5.Size = new Size(56, 24);
            label5.TabIndex = 26;
            label5.Text = "edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stilu", 14.25F);
            label4.Location = new Point(18, 164);
            label4.Name = "label4";
            label4.Size = new Size(59, 24);
            label4.TabIndex = 25;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stilu", 14.25F);
            label3.Location = new Point(18, 125);
            label3.Name = "label3";
            label3.Size = new Size(84, 24);
            label3.TabIndex = 24;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stilu", 14.25F);
            label2.Location = new Point(18, 79);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 23;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 12);
            label1.Name = "label1";
            label1.Size = new Size(287, 33);
            label1.TabIndex = 22;
            label1.Text = "Registro de Empleados";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(41, 41);
            button1.TabIndex = 38;
            button1.UseVisualStyleBackColor = true;
            // 
            // telefono
            // 
            telefono.Location = new Point(147, 285);
            telefono.Name = "telefono";
            telefono.Size = new Size(220, 23);
            telefono.TabIndex = 40;
            // 
            // lbltel
            // 
            lbltel.AutoSize = true;
            lbltel.Font = new Font("Stilu", 14.25F);
            lbltel.Location = new Point(18, 283);
            lbltel.Name = "lbltel";
            lbltel.Size = new Size(85, 24);
            lbltel.TabIndex = 39;
            lbltel.Text = "telefono";
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(telefono);
            Controls.Add(lbltel);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(btnmodifiicar);
            Controls.Add(btnagregar);
            Controls.Add(btnnuevo);
            Controls.Add(btnelminar);
            Controls.Add(direccon);
            Controls.Add(edad);
            Controls.Add(email);
            Controls.Add(apellido);
            Controls.Add(nombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Employee";
            Text = "Employee";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button btnmodifiicar;
        private Button btnagregar;
        private Button btnnuevo;
        private Button btnelminar;
        private TextBox direccon;
        private TextBox edad;
        private TextBox email;
        private TextBox apellido;
        private TextBox nombre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox telefono;
        private Label lbltel;
    }
}
