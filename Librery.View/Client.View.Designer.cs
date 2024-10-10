namespace Librery.View
{
    partial class Client
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            nombre = new TextBox();
            apellido = new TextBox();
            email = new TextBox();
            edad = new TextBox();
            direccon = new TextBox();
            btnelminar = new Button();
            btnnuevo = new Button();
            btnagregar = new Button();
            btnmodifiicar = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 14.25F);
            label6.Location = new Point(23, 269);
            label6.Name = "label6";
            label6.Size = new Size(109, 22);
            label6.TabIndex = 11;
            label6.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 14.25F);
            label5.Location = new Point(23, 212);
            label5.Name = "label5";
            label5.Size = new Size(57, 22);
            label5.TabIndex = 10;
            label5.Text = "edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 14.25F);
            label4.Location = new Point(23, 158);
            label4.Name = "label4";
            label4.Size = new Size(66, 22);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 14.25F);
            label3.Location = new Point(23, 119);
            label3.Name = "label3";
            label3.Size = new Size(97, 22);
            label3.TabIndex = 8;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 14.25F);
            label2.Location = new Point(23, 73);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 7;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Terminator Real NFI", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 18);
            label1.Name = "label1";
            label1.Size = new Size(387, 21);
            label1.TabIndex = 6;
            label1.Text = "Registro de Clientes";
            // 
            // nombre
            // 
            nombre.Location = new Point(152, 77);
            nombre.Name = "nombre";
            nombre.Size = new Size(220, 23);
            nombre.TabIndex = 12;
            // 
            // apellido
            // 
            apellido.Location = new Point(152, 121);
            apellido.Name = "apellido";
            apellido.Size = new Size(220, 23);
            apellido.TabIndex = 13;
            // 
            // email
            // 
            email.Location = new Point(152, 160);
            email.Name = "email";
            email.Size = new Size(220, 23);
            email.TabIndex = 14;
            // 
            // edad
            // 
            edad.Location = new Point(152, 211);
            edad.Name = "edad";
            edad.Size = new Size(220, 23);
            edad.TabIndex = 15;
            // 
            // direccon
            // 
            direccon.Location = new Point(152, 271);
            direccon.Name = "direccon";
            direccon.Size = new Size(220, 23);
            direccon.TabIndex = 16;
            // 
            // btnelminar
            // 
            btnelminar.Location = new Point(208, 385);
            btnelminar.Name = "btnelminar";
            btnelminar.Size = new Size(75, 23);
            btnelminar.TabIndex = 17;
            btnelminar.Text = "Eliminar";
            btnelminar.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            btnnuevo.Location = new Point(75, 385);
            btnnuevo.Name = "btnnuevo";
            btnnuevo.Size = new Size(75, 23);
            btnnuevo.TabIndex = 18;
            btnnuevo.Text = "Nuevo";
            btnnuevo.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(75, 336);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(75, 23);
            btnagregar.TabIndex = 19;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            // 
            // btnmodifiicar
            // 
            btnmodifiicar.Location = new Point(208, 336);
            btnmodifiicar.Name = "btnmodifiicar";
            btnmodifiicar.Size = new Size(75, 23);
            btnmodifiicar.TabIndex = 20;
            btnmodifiicar.Text = "Modificar";
            btnmodifiicar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(401, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 357);
            groupBox1.TabIndex = 21;
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
            // Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
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
            Name = "Client";
            Text = "Client";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox nombre;
        private TextBox apellido;
        private TextBox email;
        private TextBox edad;
        private TextBox direccon;
        private Button btnelminar;
        private Button btnnuevo;
        private Button btnagregar;
        private Button btnmodifiicar;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
    }
}