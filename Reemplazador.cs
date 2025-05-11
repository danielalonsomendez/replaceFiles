using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using replaceFiles;
public class Reemplazador
{
    public string DirectorioProyecto;
    public string NombreArchivoBuscar;
    public string RutaArchivoReemplazo;
    public string NuevoNombreArchivo;
    public string? DirTemporal;
    public List<string> ArchivosEncontrados = new List<string>();

    public Reemplazador(string DirectorioProyecto, string NombreArchivoBuscar, string RutaArchivoReemplazo, string NuevoNombreArchivo)
    {
        this.DirectorioProyecto = DirectorioProyecto;
        this.NombreArchivoBuscar = NombreArchivoBuscar;
        this.RutaArchivoReemplazo = RutaArchivoReemplazo;
        this.NuevoNombreArchivo = NuevoNombreArchivo;
        // Crear directorio temporal
        DirTemporal = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        Directory.CreateDirectory(DirTemporal);
    }

    public void analizarArchivos()
    {
        DirectoryInfo dirInfo = new DirectoryInfo(DirectorioProyecto);

        foreach (FileInfo file_info in dirInfo.GetFiles("*", SearchOption.AllDirectories))
        {
            // Copia temporal de las carpetas y archivos
            string nombreArchivo = Path.GetFileName(file_info.FullName);
            string subRuta = Path.GetRelativePath(DirectorioProyecto, file_info.DirectoryName);
            string archivoTemporal = Path.Combine(DirTemporal, subRuta, nombreArchivo);
            string? directorioTemporal = Path.GetDirectoryName(archivoTemporal);
            if (!string.IsNullOrEmpty(directorioTemporal))
            {
                Directory.CreateDirectory(directorioTemporal);
            }
            File.Copy(file_info.FullName, archivoTemporal, true);

            // Búsqueda del archivo  
            if (nombreArchivo == NombreArchivoBuscar)
            {

                if (file_info.IsReadOnly == false)
                {
                    ArchivosEncontrados.Add(file_info.FullName);
                }
                else
                {
                    MessageBox.Show($"El archivo {file_info.FullName} es de solo lectura y ha sido evitado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }






    public void reemplazarArchivos()
    {
        foreach (string archivo in ArchivosEncontrados)
        {
            // Reemplazar el contenido del archivo
            using (FileStream origenStream = new FileStream(RutaArchivoReemplazo, FileMode.Open, FileAccess.Read))
            using (FileStream destinoStream = new FileStream(archivo, FileMode.Create, FileAccess.Write))
            {
                origenStream.CopyTo(destinoStream);
            }

            // Cambiar el nombre del archivo si se especifica un nuevo nombre
            if (!string.IsNullOrWhiteSpace(NuevoNombreArchivo))
            {
                string nuevaRuta = Path.Combine(Path.GetDirectoryName(archivo), NuevoNombreArchivo);
                File.Move(archivo, nuevaRuta, true);
            }
        }
    }
    public void borrarDirectorioTemporal()
    {
        if (!Directory.Exists(DirTemporal)) return;
        // Borrar archivos
        foreach (string archivo in Directory.GetFiles(DirTemporal, "*", SearchOption.AllDirectories))
        {
            File.SetAttributes(archivo, FileAttributes.Normal);
            File.Delete(archivo);
        }
        // Borrar carpetas
        Directory.Delete(DirTemporal, true);
    }

    public void restaurarDesdeTemporal()
    {
        DirectoryInfo dirTemporalInfo = new DirectoryInfo(DirTemporal);
        DirectoryInfo dirOriginalInfo = new DirectoryInfo(DirectorioProyecto);

        // Restaurar archivos desde el temporal al original
        foreach (FileInfo file_info in dirTemporalInfo.GetFiles("*", SearchOption.AllDirectories))
        {
            string subRuta = Path.GetRelativePath(DirTemporal, file_info.FullName);
            string archivoOriginal = Path.Combine(DirectorioProyecto, subRuta);
            string? directorioOriginal = Path.GetDirectoryName(archivoOriginal);

            if (!string.IsNullOrEmpty(directorioOriginal))
            {
                Directory.CreateDirectory(directorioOriginal);
            }

            File.Copy(file_info.FullName, archivoOriginal, true);

        }

        // Eliminar archivos que están en el original pero no en el temporal
        foreach (FileInfo file_info in dirOriginalInfo.GetFiles("*", SearchOption.AllDirectories))
        {
            string subRuta = Path.GetRelativePath(DirectorioProyecto, file_info.FullName);
            string archivoTemporal = Path.Combine(DirTemporal, subRuta);

            if (!File.Exists(archivoTemporal))
            {
                File.Delete(file_info.FullName);
            }
        }
    }

    public static bool EsNombreArchivo(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return false;

        if (input.Contains(Path.DirectorySeparatorChar) || input.Contains(Path.AltDirectorySeparatorChar))
            return false;

        char[] invalidChars = Path.GetInvalidFileNameChars();
        return !input.Any(c => invalidChars.Contains(c));
    }
    public static bool EsDirectorio(string ruta)
    {
        if (string.IsNullOrWhiteSpace(ruta))
            return false;
        return Directory.Exists(ruta);
    }

    public static bool EsArchivo(string ruta)
    {
        if (string.IsNullOrWhiteSpace(ruta))
            return false;
        return File.Exists(ruta);
    }

}
