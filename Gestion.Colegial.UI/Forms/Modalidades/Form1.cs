using JNControls.Controles;
using System;
using System.Windows.Forms;

namespace Gestion.Colegial.UI.Forms.Modalidades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            JNDataGridView2 jNDataGridView2 = new JNDataGridView2();
            jNDataGridView2.CLICLEADO += new EventHandler(JNDataGridView2_CLICLEADO);
            
            
            
        }

        private void JNDataGridView2_CLICLEADO(object sender, EventArgs e)
        {
            MessageBox.Show("Test2");

        }

        private void jNDataGridView2_cliqueado(object sender, EventHandler e)
        {

        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
