
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
            this.Size = new Size(572, 255);
        }


        private void buttonProyecto_Click(object sender, EventArgs e)
        {

            folderBrowserDialog.InitialDirectory = (Directory.Exists(textBoxProyecto.Text)) ? textBoxProyecto.Text : Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxProyecto.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonNuevoArchivo_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = (Directory.Exists(textBoxRutaArchivoReemplazo.Text)) ? textBoxRutaArchivoReemplazo.Text : Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxRutaArchivoReemplazo.Text = openFileDialog.FileName;
            }
        }

        private void cambiarEstado(Boolean visible, String? texto)
        {
            progressBar.Visible = visible;
            buttonReemplazar.Visible = !visible;
            label6.Visible = visible;
            label6.Text = texto;
            this.Size = (visible) ? new Size(572, 285) : new Size(572, 255);
        }

        private async void buttonReemplazar_Click(object sender, EventArgs e)
        {
            Reemplazador r = new Reemplazador(textBoxProyecto.Text, textBoxNombreArchivoBuscar.Text, textBoxRutaArchivoReemplazo.Text, textBoxNuevoNombre.Text);
            if (!Reemplazador.EsDirectorio(r.DirectorioProyecto))
            {
                MessageBox.Show("El directorio del proyecto no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Reemplazador.EsArchivo(r.RutaArchivoReemplazo))
            {
                MessageBox.Show("El archivo para el reemplazo no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Reemplazador.EsNombreArchivo(r.NombreArchivoBuscar))
            {
                MessageBox.Show("El nombre de archivo a buscar no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Reemplazador.EsNombreArchivo(r.NuevoNombreArchivo) && !string.IsNullOrWhiteSpace(r.NuevoNombreArchivo))
            {
                MessageBox.Show("El nuevo nombre de archivo no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            try
            {
                cambiarEstado(true, $"Buscando archivos {r.NombreArchivoBuscar}");
                await Task.Run(() =>
                r.analizarArchivos()
                 );

                if (r.ArchivosEncontrados.Count == 0)
                {
                    MessageBox.Show($"No se ha encontrado ningún archivo llamado {r.NombreArchivoBuscar} en {r.DirectorioProyecto}.", $"Reemplazar archivos ({r.NombreArchivoBuscar})", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cambiarEstado(true, "");
                DialogResult reemplazar = MessageBox.Show($"Se han encontrado {r.ArchivosEncontrados.Count} archivos en {r.DirectorioProyecto} llamados {r.NombreArchivoBuscar}, ¿deseas continuar con el reemplazo? ", $"Reemplazar archivos ({r.NombreArchivoBuscar})", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reemplazar == DialogResult.Yes)
                {
                    cambiarEstado(true, "Reemplazando archivos...");
                    r.reemplazarArchivos();
                    cambiarEstado(false, "");
                    MessageBox.Show($"¡Todos los archivos se han reemplazado con éxito!", $"Reemplazar archivos ({r.NombreArchivoBuscar})", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex, $"Reemplazar archivos ({r.NombreArchivoBuscar})", MessageBoxButtons.OK, MessageBoxIcon.Error);
                r.restaurarDesdeTemporal();
            }
            finally
            {
                cambiarEstado(false, null);
                r.borrarDirectorioTemporal();
            }
        }


    }
}
