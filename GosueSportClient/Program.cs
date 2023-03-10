using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GosueSportClient
{
    static class Program
    {
       

        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BlockScreen ObjBlockForm = new BlockScreen();
            TimeCounterForm ObjTimeForm = new TimeCounterForm();
            FormController ObjFormController = new FormController(ObjBlockForm, ObjTimeForm);
            
            
            Application.Run(ObjBlockForm);
        }
    }
}
