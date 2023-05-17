using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SistemaServitec.Controllers
{
    public static class Tools
    {
        public static void  ExtractToDirectory ( string pathZip , string pathExtract )
        {
            try
            {
                ZipFile.ExtractToDirectory ( pathZip , pathExtract );
            }
            catch ( Exception error)
            {

                MessageBox.Show ( error.Message );
            }
          
        }

        public static Task Esperar (  )
        { 
           
          return  Task.Delay(TimeSpan.FromSeconds(1.5));
           
          
        }
    }
}
