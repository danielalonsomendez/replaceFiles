
namespace replaceFiles
{
    public partial class Formulario : Form
    {


        public Formulario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(572, 252);
        }

        public void cambiarLabel6(String texto)
        {
            label6.Text = texto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // Actualiza el TextBox con la ruta seleccionada
                textBoxProyecto.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Actualiza el TextBox con la ruta seleccionada
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void cambiarEstado(Boolean visible, String? texto)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 1;
            progressBar1.Visible = visible;
            label6.Visible = visible;
            label6.Text = texto;
            if (visible)
            {
                this.Size = new Size(572, 310);
            }
            else
            {
                this.Size = new Size(572, 252);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string DirectorioProyecto = textBoxProyecto.Text;
            string NombreArchivoBuscar = textBoxFileName.Text;
            string RutaArchivoReemplazo = textBox1.Text;
            string? NuevoNombreArchivo = textBox2.Text;

            Reemplazador reemplazador = new Reemplazador();
            // messagebox con todos los datos
            if (!Reemplazador.EsDirectorio(DirectorioProyecto))
            {
                MessageBox.Show("El directorio del proyecto no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Reemplazador.EsDirectorio(RutaArchivoReemplazo))
            {
                MessageBox.Show("El archivo para el reemplazo no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Reemplazador.EsNombreArchivo(NombreArchivoBuscar))
            {
                MessageBox.Show("El nombre de archivo a buscar no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Reemplazador.EsNombreArchivo(NuevoNombreArchivo) && !string.IsNullOrWhiteSpace(NuevoNombreArchivo))
            {
                MessageBox.Show("El nuevo nombre de archivo no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            try
            {
                cambiarEstado(true, "Buscando archivos...");
                reemplazador.crearDirectorioTemporal(DirectorioProyecto);
                await Task.Run(() =>
                     reemplazador.analizarcarpetas(DirectorioProyecto, NombreArchivoBuscar)
                 );
                cambiarEstado(false, null);

                if (reemplazador.archivosReemplazados.Count == 0)
                {
                    MessageBox.Show($"No se ha encontrado ningún archivo llamado {NombreArchivoBuscar} en {DirectorioProyecto}.", $"Reemplazar archivos ({NombreArchivoBuscar})", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult reemplazar = MessageBox.Show($"Se han encontrado {reemplazador.archivosReemplazados.Count} archivos en {DirectorioProyecto} llamados {NombreArchivoBuscar}, ¿deseas continuar con el reemplazo? ", $"Reemplazar archivos ({NombreArchivoBuscar})", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (reemplazar == DialogResult.Yes)
                {
                   // await reemplazador.reemplazarArchivos(reemplazador.archivosReemplazados);
                   // await reemplazador.combinarDirectorios(DirectorioProyecto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex, $"Reemplazar archivos ({NombreArchivoBuscar})", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar1.Visible = false; // Ocultar el ProgressBar al finalizar
            }
        }

        private void textBoxProyecto_TextChanged(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = textBoxProyecto.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            openFileDialog1.FileName = textBox1.Text;
        }
    }
}
