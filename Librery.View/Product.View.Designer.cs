namespace Librery.View
{
    partial class Producto
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
            btnmodifiicar = new Button();
            btnagregar = new Button();
            btnelminar = new Button();
            edad = new TextBox();
            email = new TextBox();
            apellido = new TextBox();
            nombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnmodifiicar
            // 
            btnmodifiicar.Location = new Point(261, 456);
            btnmodifiicar.Margin = new Padding(3, 4, 3, 4);
            btnmodifiicar.Name = "btnmodifiicar";
            btnmodifiicar.Size = new Size(86, 31);
            btnmodifiicar.TabIndex = 36;
            btnmodifiicar.Text = "Modificar";
            btnmodifiicar.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(102, 456);
            btnagregar.Margin = new Padding(3, 4, 3, 4);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(86, 31);
            btnagregar.TabIndex = 35;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            // 
            // btnelminar
            // 
            btnelminar.Location = new Point(182, 539);
            btnelminar.Margin = new Padding(3, 4, 3, 4);
            btnelminar.Name = "btnelminar";
            btnelminar.Size = new Size(86, 31);
            btnelminar.TabIndex = 33;
            btnelminar.Text = "Eliminar";
            btnelminar.UseVisualStyleBackColor = true;
            // 
            // edad
            // 
            edad.Location = new Point(197, 308);
            edad.Margin = new Padding(3, 4, 3, 4);
            edad.Name = "edad";
            edad.Size = new Size(251, 27);
            edad.TabIndex = 31;
            // 
            // email
            // 
            email.Location = new Point(197, 241);
            email.Margin = new Padding(3, 4, 3, 4);
            email.Name = "email";
            email.Size = new Size(251, 27);
            email.TabIndex = 30;
            // 
            // apellido
            // 
            apellido.Location = new Point(197, 170);
            apellido.Margin = new Padding(3, 4, 3, 4);
            apellido.Name = "apellido";
            apellido.Size = new Size(251, 27);
            apellido.TabIndex = 29;
            // 
            // nombre
            // 
            nombre.Location = new Point(197, 105);
            nombre.Margin = new Padding(3, 4, 3, 4);
            nombre.Name = "nombre";
            nombre.Size = new Size(251, 27);
            nombre.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 14.25F);
            label6.Location = new Point(21, 376);
            label6.Name = "label6";
            label6.Size = new Size(87, 29);
            label6.TabIndex = 27;
            label6.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 14.25F);
            label5.Location = new Point(21, 305);
            label5.Name = "label5";
            label5.Size = new Size(142, 29);
            label5.TabIndex = 26;
            label5.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 14.25F);
            label4.Location = new Point(21, 238);
            label4.Name = "label4";
            label4.Size = new Size(98, 29);
            label4.TabIndex = 25;
            label4.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 14.25F);
            label3.Location = new Point(21, 167);
            label3.Name = "label3";
            label3.Size = new Size(167, 29);
            label3.TabIndex = 24;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 14.25F);
            label2.Location = new Point(21, 105);
            label2.Name = "label2";
            label2.Size = new Size(110, 29);
            label2.TabIndex = 23;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Terminator Real NFI", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(217, 32);
            label7.Name = "label7";
            label7.Size = new Size(545, 27);
            label7.TabIndex = 22;
            label7.Text = "Registro de Productos";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(197, 380);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 38;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(542, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(395, 462);
            dataGridView1.TabIndex = 39;
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 658);
            Controls.Add(dataGridView1);
            Controls.Add(numericUpDown1);
            Controls.Add(btnmodifiicar);
            Controls.Add(btnagregar);
            Controls.Add(btnelminar);
            Controls.Add(edad);
            Controls.Add(email);
            Controls.Add(apellido);
            Controls.Add(nombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Producto";
            Text = "Producto";
            Load += Producto_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnmodifiicar;
        private Button btnagregar;
        private Button btnelminar;
        private TextBox edad;
        private TextBox email;
        private TextBox apellido;
        private TextBox nombre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView1;
    }
}