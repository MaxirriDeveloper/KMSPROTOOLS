using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace KMSPROTOOLS
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
 
        }

        private void btnAACT_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\KMS Tools Unpack\AAct Network\AAct_Network_x64.exe");
            }
            catch (Exception )
            { 
            MessageBox.Show("Archivo no encontrado","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnConsole_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\KMS Tools Unpack\ConsoleAct\ConsoleAct_x64.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDefender_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\KMS Tools Unpack\Defender Tools\Defender Tools.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGarbage_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\KMS Tools Unpack\Garbage Collector\GarbageCollector_x64.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnKmsAuto_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\KMS Tools Unpack\KMSAuto Lite Portable\KMSAuto x64.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnKmsOffline_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\KMS Tools Unpack\KMSoffline\KMSoffline_x64.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnMSAct_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\KMS Tools Unpack\MSAct\MSAct++ x64.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnOffice_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\KMS Tools Unpack\Office 2013-2021\OInstall.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPidKey_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\KMS Tools Unpack\PIDKey Lite\PIDKey Lite x64.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnW10_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\KMS Tools Unpack\W10 Digital\W10DigitalActivation_x64.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnReloader_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\KMS Tools Unpack\Reloader\Re-Loader.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnKmspico_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\KMS Tools Unpack\KmsPico\KMSpico_setup.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnMSA32bits_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\KMS Tools Unpack\MSAct\MSAct++.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnConsole32bits_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\KMS Tools Unpack\ConsoleAct\ConsoleAct_x64.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGarbage32bits_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\KMS Tools Unpack\Garbage Collector\GarbageCollector.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnKmsAuto32bits_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\KMS Tools Unpack\KMSAuto Lite Portable\KMSAuto.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnKmsOffline32bits_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\KMS Tools Unpack\KMSoffline\KMSoffline.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPidKey32bits_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\KMS Tools Unpack\PIDKey Lite\PIDKey Lite.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.Start(@"C:\DeleteKMS");
        }
    }
}
