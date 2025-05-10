namespace replaceFiles
{
    partial class Formulario
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
            textBoxProyecto = new TextBox();
            label1 = new Label();
            buttonProyecto = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label2 = new Label();
            label3 = new Label();
            textBoxFileName = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            label5 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBoxProyecto
            // 
            textBoxProyecto.Location = new Point(12, 47);
            textBoxProyecto.Name = "textBoxProyecto";
            textBoxProyecto.Size = new Size(258, 22);
            textBoxProyecto.TabIndex = 0;
            textBoxProyecto.TextChanged += textBoxProyecto_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 1;
            label1.Text = "Ruta del proyecto:";
            // 
            // buttonProyecto
            // 
            buttonProyecto.Location = new Point(195, 14);
            buttonProyecto.Name = "buttonProyecto";
            buttonProyecto.Size = new Size(75, 23);
            buttonProyecto.TabIndex = 2;
            buttonProyecto.Text = "Examinar";
            buttonProyecto.UseVisualStyleBackColor = true;
            buttonProyecto.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 18);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lato", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(184, 15);
            label3.TabIndex = 5;
            label3.Text = "Nombre del archivo a reemplazar:";
            // 
            // textBoxFileName
            // 
            textBoxFileName.Location = new Point(12, 115);
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.Size = new Size(258, 22);
            textBoxFileName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lato", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(285, 18);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 7;
            label4.Text = "Ruta del nuevo archivo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(285, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 22);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(468, 13);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Examinar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lato", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(285, 85);
            label5.Name = "label5";
            label5.Size = new Size(205, 15);
            label5.TabIndex = 10;
            label5.Text = "Nuevo nombre del archivo (opcional):";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(285, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 22);
            textBox2.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(12, 162);
            button2.Name = "button2";
            button2.Size = new Size(531, 39);
            button2.TabIndex = 11;
            button2.Text = "Reemplazar archivos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 207);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(531, 28);
            progressBar1.TabIndex = 12;
            progressBar1.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 246);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 13;
            label6.Text = "Analizando ...";
            label6.Visible = false;
            // 
            // Formulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 270);
            Controls.Add(label6);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(textBoxFileName);
            Controls.Add(label2);
            Controls.Add(buttonProyecto);
            Controls.Add(label1);
            Controls.Add(textBoxProyecto);
            Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "Formulario";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reemplazar archivos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProyecto;
        private Label label1;
        private Button buttonProyecto;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label2;
        private Label label3;
        private TextBox textBoxFileName;
        private Label label4;
        private TextBox textBox1;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Label label5;
        private TextBox textBox2;
        private Button button2;
        private ProgressBar progressBar1;
        private Label label6;
    }
}
