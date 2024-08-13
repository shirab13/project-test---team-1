using System;
using System.Windows.Forms;
using OfficeOpenXml; // ודא שהייבוא נכון

namespace HebrewLearningApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // הגדרת הקשר לרישיון
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainFormInstance = new MainForm(null); // יצירת MainForm ראשון עם null או ארגומנט אחר שמתאים
            Application.Run(new MainForm(mainFormInstance)); // הרצת MainForm עם העברת האובייקט
        }
    }
}
