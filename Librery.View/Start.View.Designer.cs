namespace Librery.View
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sporting Grotesque", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 52);
            label1.TabIndex = 0;
            label1.Text = "Inicio";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Sporting Grotesque", 12F);
            button1.Location = new Point(38, 85);
            button1.Name = "button1";
            button1.Size = new Size(178, 101);
            button1.TabIndex = 1;
            button1.Text = "Cliente";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Font = new Font("Sporting Grotesque", 12F);
            button2.Location = new Point(38, 233);
            button2.Name = "button2";
            button2.Size = new Size(178, 101);
            button2.TabIndex = 2;
            button2.Text = "Empleado";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Font = new Font("Sporting Grotesque", 12F);
            button3.Location = new Point(308, 85);
            button3.Name = "button3";
            button3.Size = new Size(178, 101);
            button3.TabIndex = 3;
            button3.Text = "Producto";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.Font = new Font("Sporting Grotesque", 12F);
            button4.Location = new Point(308, 233);
            button4.Name = "button4";
            button4.Size = new Size(178, 101);
            button4.TabIndex = 4;
            button4.Text = "Factura";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Transparent;
            button5.Location = new Point(229, 365);
            button5.Name = "button5";
            button5.Size = new Size(62, 60);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(537, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Start";
            Text = "Libreria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}