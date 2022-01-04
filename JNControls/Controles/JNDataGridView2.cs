using System;
using System.Windows.Forms;

namespace JNControls.Controles
{
    public partial class JNDataGridView2 : UserControl
    {
        public JNDataGridView2()
        {
            InitializeComponent();

        }

        //public delegate EventHandler(object sender, EventArgs e);
        //public event EventHandler SomeEvent;

        public event EventHandler CLICLEADO;
        //public event EventArgs CLICLEADO;

        private void pnBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void JNDataGridView2_Load(object sender, EventArgs e)
        {

        }

        protected virtual void OnCLICLEADO(object sender, EventArgs e)
        {

            //EventHandler eventHandler = CLICLEADO;
            CLICLEADO?.Invoke(sender, e);
            MessageBox.Show("Test");

            //if (CLICLEADO != null)
            //{
            //    CLICLEADO(sender, e);
            //}
            //eventHandler(this, e);
        }

    }
}
