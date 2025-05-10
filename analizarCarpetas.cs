using System;
using System.Collections.Generic;
using System.IO;
using replaceFiles;
public class Reemplazador
{
    public List<string> archivosEncontrados = new List<string>();
    public List<string> archivosReemplazados = new List<string>();
    public string? temporaldir;

    public void analizarcarpetas(string ruta, string archivo)
    {

        DirectoryInfo dir_info = new DirectoryInfo(ruta);

        foreach (FileInfo file_info in dir_info.GetFiles())
        {
            string nombreArchivo = Path.GetFileName(file_info.FullName);
            string archivoTemporal = Path.Combine(temporaldir, nombreArchivo);
            File.Copy(file_info.FullName, archivoTemporal, true);

            if (nombreArchivo == archivo && file_info.IsReadOnly == false)
            {
                archivosEncontrados.Add(archivoTemporal);
            }

        }

        foreach (DirectoryInfo subdir_info in dir_info.GetDirectories())
        {
            String subdir = Path.Combine(temporaldir, subdir_info.Name);
            Directory.CreateDirectory(subdir);
            analizarcarpetas(subdir_info.FullName, archivo);
        }

    }

    public void crearDirectorioTemporal(string directorioProyecto)
    {
        string dirTemporal = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        Directory.CreateDirectory(dirTemporal);
        temporaldir = dirTemporal;
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

    public async void reemplazarArchivos(string rutanuevoArchivo, string nuevoNombre)
    {

        for (int i = 0; i < archivosEncontrados.Count; i++)
        {
            string archivo = archivosEncontrados[i];
            string nombreArchivo = Path.GetFileName(archivo);
            File.Replace(archivo, rutanuevoArchivo, null);
            string nuevaRuta = archivo;
            if (string.IsNullOrWhiteSpace(nuevoNombre) == false)
            {
                nombreArchivo = Path.GetFileName(rutanuevoArchivo);
                 nuevaRuta = Path.Combine(Path.GetDirectoryName(archivo), nuevoNombre);
                File.Move(archivo, nuevaRuta,true);
            }
            archivosReemplazados.Add(nuevaRuta);
        }
    }
}
