using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dtCleanOldFiles
{
    public partial class dtMainForm : Form
    {
        private string tempPath = string.Empty;
        private bool jaApagou = false;
        private DateTime hoje = DateTime.Now;

        public dtMainForm()
        {
            InitializeComponent();
        }

        private void dtTimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now >= new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(maskTime.Text.Substring(0, 2)), int.Parse(maskTime.Text.Substring(3, 2)),0) & !jaApagou)
            {
                dtTimer.Enabled = false;
                apagar(txtInicialPath.Text);
                dtTimer.Enabled = true;
            }

            if (DateTime.Now.Date > hoje.Date)
            {
                hoje = DateTime.Now;
                jaApagou = false;
            }
        }

        private void dtMainForm_Load(object sender, EventArgs e)
        {
            //dtTimer.Enabled = true;
            //int hora = 0;
            //int minuto = 0;

            //hora = int.Parse(maskTime.Text.Substring(0, 2));
            //minuto = int.Parse(maskTime.Text.Substring(3, 2));
            
            
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {

            if (btIniciar.Text.Equals("Iniciar"))
            {
                btIniciar.Enabled = false;
                dtTimer.Enabled = false;
                btIniciar.Text = "Executando";
                btIniciar.ForeColor = Color.ForestGreen;
                Application.DoEvents();
                apagar(txtInicialPath.Text);
                Application.DoEvents();
                dtTimer.Enabled = true;
                btIniciar.Text = "Iniciar";
                btIniciar.ForeColor = Color.Red;
                btIniciar.Enabled = true;
            }
            else
            {
                
                dtTimer.Enabled = false;
            }
        }

        private void apagar(string path)
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(path);
            //dtProgressBar.Maximum = di.GetDirectories().Count();
            
            foreach (DirectoryInfo dir in di.GetDirectories("temp",SearchOption.AllDirectories))
            {
                if (dir.Name.Equals("temp"))
                {
                    foreach (DirectoryInfo dire in dir.GetDirectories())
                    {
                        try
                        {
                            dire.Delete(true);
                            //dtProgressBar.PerformStep();
                        }
                        catch (Exception)
                        {

                        }
                    }

                    foreach (FileInfo file in dir.GetFiles())
                    {
                        try
                        {
                            file.Delete();
                        }
                        catch (Exception)
                        {

                        }
                    }

                    
                }
            }
            jaApagou = true;
        }

        private void btAgendar_Click(object sender, EventArgs e)
        {
            if (btAgendar.Text.Equals("Agendar"))
            {
                btAgendar.Text = "Agendado";
                btAgendar.ForeColor = Color.ForestGreen;
                dtTimer.Enabled = true;
            }
            else
            {
                btAgendar.Text = "Agendar";
                btAgendar.ForeColor = Color.Red;
                dtTimer.Enabled = false;
            }

        }
     
    }
}
