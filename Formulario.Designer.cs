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
            folderBrowserDialog = new FolderBrowserDialog();
            label2 = new Label();
            label3 = new Label();
            textBoxNombreArchivoBuscar = new TextBox();
            label4 = new Label();
            textBoxRutaArchivoReemplazo = new TextBox();
            buttonNuevoArchivo = new Button();
            openFileDialog = new OpenFileDialog();
            label5 = new Label();
            textBoxNuevoNombre = new TextBox();
            buttonReemplazar = new Button();
            progressBar = new ProgressBar();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBoxProyecto
            // 
            textBoxProyecto.Location = new Point(12, 47);
            textBoxProyecto.Name = "textBoxProyecto";
            textBoxProyecto.Size = new Size(258, 25);
            textBoxProyecto.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(133, 18);
            label1.TabIndex = 1;
            label1.Text = "Ruta del proyecto:";
            // 
            // buttonProyecto
            // 
            buttonProyecto.Location = new Point(184, 14);
            buttonProyecto.Name = "buttonProyecto";
            buttonProyecto.Size = new Size(87, 25);
            buttonProyecto.TabIndex = 2;
            buttonProyecto.Text = "Examinar";
            buttonProyecto.UseVisualStyleBackColor = true;
            buttonProyecto.Click += buttonProyecto_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 18);
            label2.Name = "label2";
            label2.Size = new Size(0, 18);
            label2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lato", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(236, 18);
            label3.TabIndex = 5;
            label3.Text = "Nombre del archivo a reemplazar:";
            // 
            // textBoxNombreArchivoBuscar
            // 
            textBoxNombreArchivoBuscar.Location = new Point(12, 115);
            textBoxNombreArchivoBuscar.Name = "textBoxNombreArchivoBuscar";
            textBoxNombreArchivoBuscar.Size = new Size(258, 25);
            textBoxNombreArchivoBuscar.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lato", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(285, 18);
            label4.Name = "label4";
            label4.Size = new Size(165, 18);
            label4.TabIndex = 7;
            label4.Text = "Ruta del nuevo archivo";
            // 
            // textBoxRutaArchivoReemplazo
            // 
            textBoxRutaArchivoReemplazo.Location = new Point(285, 47);
            textBoxRutaArchivoReemplazo.Name = "textBoxRutaArchivoReemplazo";
            textBoxRutaArchivoReemplazo.Size = new Size(258, 25);
            textBoxRutaArchivoReemplazo.TabIndex = 6;
            // 
            // buttonNuevoArchivo
            // 
            buttonNuevoArchivo.Location = new Point(461, 14);
            buttonNuevoArchivo.Name = "buttonNuevoArchivo";
            buttonNuevoArchivo.Size = new Size(87, 25);
            buttonNuevoArchivo.TabIndex = 8;
            buttonNuevoArchivo.Text = "Examinar";
            buttonNuevoArchivo.UseVisualStyleBackColor = true;
            buttonNuevoArchivo.Click += buttonNuevoArchivo_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.InitialDirectory = "Desktop";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lato", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(285, 85);
            label5.Name = "label5";
            label5.Size = new Size(263, 18);
            label5.TabIndex = 10;
            label5.Text = "Nuevo nombre del archivo (opcional):";
            // 
            // textBoxNuevoNombre
            // 
            textBoxNuevoNombre.Location = new Point(285, 114);
            textBoxNuevoNombre.Name = "textBoxNuevoNombre";
            textBoxNuevoNombre.Size = new Size(258, 25);
            textBoxNuevoNombre.TabIndex = 9;
            // 
            // buttonReemplazar
            // 
            buttonReemplazar.Location = new Point(12, 162);
            buttonReemplazar.Name = "buttonReemplazar";
            buttonReemplazar.Size = new Size(531, 39);
            buttonReemplazar.TabIndex = 11;
            buttonReemplazar.Text = "Reemplazar archivos";
            buttonReemplazar.UseVisualStyleBackColor = true;
            buttonReemplazar.Click += buttonReemplazar_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 162);
            progressBar.MarqueeAnimationSpeed = 1;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(531, 39);
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 12;
            progressBar.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 216);
            label6.Name = "label6";
            label6.Size = new Size(93, 18);
            label6.TabIndex = 13;
            label6.Text = "Analizando ...";
            label6.Visible = false;
            // 
            // Formulario
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(556, 246);
            Controls.Add(label6);
            Controls.Add(progressBar);
            Controls.Add(buttonReemplazar);
            Controls.Add(label5);
            Controls.Add(textBoxNuevoNombre);
            Controls.Add(buttonNuevoArchivo);
            Controls.Add(label4);
            Controls.Add(textBoxRutaArchivoReemplazo);
            Controls.Add(label3);
            Controls.Add(textBoxNombreArchivoBuscar);
            Controls.Add(label2);
            Controls.Add(buttonProyecto);
            Controls.Add(label1);
            Controls.Add(textBoxProyecto);
            Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private FolderBrowserDialog folderBrowserDialog;
        private Label label2;
        private Label label3;
        private TextBox textBoxNombreArchivoBuscar;
        private Label label4;
        private TextBox textBoxRutaArchivoReemplazo;
        private Button buttonNuevoArchivo;
        private OpenFileDialog openFileDialog;
        private Label label5;
        private TextBox textBoxNuevoNombre;
        private Button buttonReemplazar;
        private ProgressBar progressBar;
        private Label label6;
    }
}
