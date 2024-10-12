namespace Librery.View
{
    partial class Invoce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoce));
            button1 = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
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
            btnmodifiicar = new Button();
            btnagregar = new Button();
            btnnuevo = new Button();
            btnelminar = new Button();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Location = new Point(14, 11);
            button1.Name = "button1";
            button1.Size = new Size(41, 41);
            button1.TabIndex = 56;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(398, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 357);
            groupBox1.TabIndex = 54;
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
            // edad
            // 
            edad.Location = new Point(149, 216);
            edad.Name = "edad";
            edad.Size = new Size(220, 23);
            edad.TabIndex = 49;
            // 
            // email
            // 
            email.Location = new Point(149, 165);
            email.Name = "email";
            email.Size = new Size(220, 23);
            email.TabIndex = 48;
            email.KeyPress += email_KeyPress;
            // 
            // apellido
            // 
            apellido.Location = new Point(149, 126);
            apellido.Name = "apellido";
            apellido.Size = new Size(220, 23);
            apellido.TabIndex = 47;
            // 
            // nombre
            // 
            nombre.Location = new Point(149, 82);
            nombre.Name = "nombre";
            nombre.Size = new Size(220, 23);
            nombre.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stilu", 14.25F);
            label6.Location = new Point(20, 259);
            label6.Name = "label6";
            label6.Size = new Size(61, 24);
            label6.TabIndex = 45;
            label6.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stilu", 14.25F);
            label5.Location = new Point(20, 217);
            label5.Name = "label5";
            label5.Size = new Size(98, 24);
            label5.TabIndex = 44;
            label5.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stilu", 14.25F);
            label4.Location = new Point(20, 163);
            label4.Name = "label4";
            label4.Size = new Size(68, 24);
            label4.TabIndex = 43;
            label4.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stilu", 14.25F);
            label3.Location = new Point(20, 124);
            label3.Name = "label3";
            label3.Size = new Size(118, 24);
            label3.TabIndex = 42;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stilu", 14.25F);
            label2.Location = new Point(20, 78);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 41;
            label2.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(254, 19);
            label7.Name = "label7";
            label7.Size = new Size(258, 33);
            label7.TabIndex = 40;
            label7.Text = "Registro de Facturas";
            // 
            // btnmodifiicar
            // 
            btnmodifiicar.BackgroundImage = (Image)resources.GetObject("btnmodifiicar.BackgroundImage");
            btnmodifiicar.BackgroundImageLayout = ImageLayout.None;
            btnmodifiicar.Location = new Point(192, 344);
            btnmodifiicar.Name = "btnmodifiicar";
            btnmodifiicar.Size = new Size(41, 41);
            btnmodifiicar.TabIndex = 60;
            btnmodifiicar.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            btnagregar.BackgroundImage = (Image)resources.GetObject("btnagregar.BackgroundImage");
            btnagregar.BackgroundImageLayout = ImageLayout.None;
            btnagregar.Location = new Point(136, 344);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(41, 41);
            btnagregar.TabIndex = 59;
            btnagregar.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            btnnuevo.BackgroundImage = (Image)resources.GetObject("btnnuevo.BackgroundImage");
            btnnuevo.BackgroundImageLayout = ImageLayout.None;
            btnnuevo.Location = new Point(136, 393);
            btnnuevo.Name = "btnnuevo";
            btnnuevo.Size = new Size(41, 41);
            btnnuevo.TabIndex = 58;
            btnnuevo.UseVisualStyleBackColor = true;
            // 
            // btnelminar
            // 
            btnelminar.BackgroundImage = (Image)resources.GetObject("btnelminar.BackgroundImage");
            btnelminar.BackgroundImageLayout = ImageLayout.None;
            btnelminar.Location = new Point(192, 393);
            btnelminar.Name = "btnelminar";
            btnelminar.Size = new Size(41, 41);
            btnelminar.TabIndex = 57;
            btnelminar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 259);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 23);
            textBox1.TabIndex = 61;
            // 
            // Invoce
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(818, 471);
            Controls.Add(textBox1);
            Controls.Add(btnmodifiicar);
            Controls.Add(btnagregar);
            Controls.Add(btnnuevo);
            Controls.Add(btnelminar);
            Controls.Add(button1);
            Controls.Add(groupBox1);
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
            Name = "Invoce";
            Text = "Invoce";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
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
        private Button btnmodifiicar;
        private Button btnagregar;
        private Button btnnuevo;
        private Button btnelminar;
        private TextBox textBox1;
    }
}