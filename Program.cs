using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Create a Form
        Form mainForm = new Form
        {
            Text = "Image Viewer",
            Size = new System.Drawing.Size(400, 300)
        };



        // Run the application
        Application.Run(mainForm);
    }
}