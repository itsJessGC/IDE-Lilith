using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lilith
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0){ //Si no se agregó un archivo en la consola
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new editorPrin());
            }
            else{ //Si se está ejecutando en la consola con archivo
                string[] lineas = System.IO.File.ReadAllLines(@".\" + args[0]);
                analizadorLexico analizador = new analizadorLexico();
                int lineaP = 1;
                foreach (string linea in lineas){
                    analizador.Analizado_Lexico(linea, lineaP);
                    lineaP++;
                }
                analizador.obtenerTokens2();
                Console.WriteLine(analizador.tokensResultados());
            }
        }
    }
}
