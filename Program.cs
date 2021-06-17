using System.Security.AccessControl;


using System;
using System.IO;


namespace AppOrden
{
    class Program
    {
       public static void Main()
        {
            String cadenaPathDrive = "";
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine("Drive {0}", d.Name);
                Console.WriteLine("  Drive type: {0}", d.DriveType);
                if (d.IsReady == true)
                {
                    Console.WriteLine("  Etiqueta de volumen: {0}", d.VolumeLabel);
                    Console.WriteLine("  Sistema de archivos: {0}", d.DriveFormat);
                    Console.WriteLine(
                        "  Espacio disponible para la usuaria actual:{0, 15} bytes",
                        d.AvailableFreeSpace);

                    Console.WriteLine(" Espacio total disponible:          {0, 15} bytes",d.TotalFreeSpace);

                    Console.WriteLine("  Tamaño total de la unidad:            {0, 15} bytes ", d.TotalSize);
                }
            }

            Console.WriteLine(" ");
            Console.Write ("Indique el Drive deseado para listar su contenido,debe escribir la letra : ");
            cadenaPathDrive = Console.ReadLine();
            cadenaPathDrive += ":\\" ;
            Console.WriteLine("");
            Console.WriteLine(cadenaPathDrive);


            //

        }

    }
 }      
