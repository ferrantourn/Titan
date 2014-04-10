using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web;

namespace Titan
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        static void GenerateHTML()
        {

        }

        /// <summary>
        /// Levanta el contenido del archivo que pasamos por parametros, el cual
        /// deberia estar en la carpeta HTMLTemplates.
        /// </summary>
        /// <param name="FileNameTemplate">Nombre del archivo a levantar. Recordar se levantan desde la carpeta TemplatesMails en el raiz.</param>
        /// <returns>HTML devuelto.</returns>
        public static String GetTemplate(String FileNameTemplate)
        {
            //-----------------------------------------------
            //- Aquí levanto el archivo de template.         
            //-----------------------------------------------
            string fileName = string.Format("{0}\\{1}");
                                                //HttpContext.Current.Server.MapPath("~/Admin/HTMLTemplates"), FileNameTemplate);

            string contenido = "";

            using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    contenido = reader.ReadToEnd();
                }
            }
            return contenido;
        }
        
    }
}
