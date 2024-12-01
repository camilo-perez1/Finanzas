namespace Proyecto_de_ingenieria_economica
{
    partial class Menu
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
            panelChildForm = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.LightSteelBlue;
            panelChildForm.Controls.Add(pictureBox1);
            panelChildForm.Controls.Add(label1);
            panelChildForm.Location = new Point(218, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1308, 799);
            panelChildForm.TabIndex = 5;
            panelChildForm.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkMagenta;
            label1.Location = new Point(64, 104);
            label1.Name = "label1";
            label1.Size = new Size(528, 32);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a nuestro proyecto de Finanzas 1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 598);
            panel2.TabIndex = 6;
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.Olive;
            button8.Location = new Point(16, 152);
            button8.Name = "button8";
            button8.Size = new Size(186, 61);
            button8.TabIndex = 8;
            button8.Text = "Razones Financieras";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaption;
            button7.Dock = DockStyle.Bottom;
            button7.FlatStyle = FlatStyle.System;
            button7.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ActiveCaption;
            button7.Location = new Point(0, 530);
            button7.Name = "button7";
            button7.Size = new Size(224, 68);
            button7.TabIndex = 7;
            button7.Text = "Salir";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Olive;
            button6.Location = new Point(16, 388);
            button6.Name = "button6";
            button6.Size = new Size(186, 41);
            button6.TabIndex = 6;
            button6.Text = "Rentabilidad";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Olive;
            button5.Location = new Point(16, 335);
            button5.Name = "button5";
            button5.Size = new Size(186, 47);
            button5.TabIndex = 5;
            button5.Text = "Endeudamiento";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Olive;
            button4.Location = new Point(16, 273);
            button4.Name = "button4";
            button4.Size = new Size(186, 56);
            button4.TabIndex = 4;
            button4.Text = "Actividad";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Olive;
            button3.Location = new Point(16, 219);
            button3.Name = "button3";
            button3.Size = new Size(186, 48);
            button3.TabIndex = 3;
            button3.Text = "LIquidez";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Olive;
            button2.Location = new Point(16, 78);
            button2.Name = "button2";
            button2.Size = new Size(186, 68);
            button2.TabIndex = 2;
            button2.Text = "Estado de Resultado";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Olive;
            button1.Location = new Point(16, 12);
            button1.Name = "button1";
            button1.Size = new Size(186, 60);
            button1.TabIndex = 1;
            button1.Text = "Balance General";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 136);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Olive;
            label2.Location = new Point(30, 93);
            label2.Name = "label2";
            label2.Size = new Size(161, 23);
            label2.TabIndex = 1;
            label2.Text = "Menu de opciones";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 724);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelChildForm);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            panelChildForm.ResumeLayout(false);
            panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChildForm;
        private Panel panel2;
        private Panel panel3;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button7;
        private Button button6;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private Button button8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}