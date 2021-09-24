using System;
using System.Windows.Forms;

namespace JNControls.Controles
{
    public partial class JNMenu : UserControl
    {



        private dynamic menuSource = null;

        public string subItem = null;

        public dynamic MenuSource { get => menuSource; set => menuSource = value; }
        //public string SubItem { get => subItem; set => subItem = value; }

        public JNMenu()
        {
            InitializeComponent();


        }

        protected override void OnLoad(EventArgs e)
        {
            //base.OnLoad(e);
            //if (menuSource != null)
            //{
            //    menuSource.Reverse();
            //    for (int i = 0; i < menuSource.Count; i++)
            //    {
            //        string item = menuSource[i].Item;

            //        NewButton(menuSource.Count, 0, $"btn{item}", item, "", "");
            //        //MessageBox.Show(MenuList[i].Item.ToString());
            //        {
            //            if (menuSource[i].SubItem != null)
            //                for (int j = 0; j < menuSource[i].SubItem.Length; j++)
            //                {
            //                    menuSource.Reverse();

            //                    string subitem = menuSource[i].SubItem[j];
            //                    NewButton(menuSource.Count, 0, subitem, subitem, "", "", false);
            //                    // MessageBox.Show(MenuList[i].SubItem[j].ToString());
            //                }
            //            menuSource.Reverse();

            //        }
            //    }
            //}
        }
        //protected virtual void OnLoad(EventArgs e)
        //{


        //}

        /// <summary>
        /// Crea un nuevo boton
        /// </summary>
        /// <param name="count">Cantidad total de valores se enviaran</param>
        /// <param name="indice">Numero actual del valor por el cual va en el instante en que se envia</param>
        /// <param name="name">Nombre con el que se identificara el boton en el sistema.</param>
        /// <param name="text">Texto que se mostrara en la pantalla.</param>
        /// <param name="colorItem">Color principal de los botones principales</param>
        /// <param name="colorSubItem">Color que contentra el boton de subItem</param>
        /// <param name="visible">Indica si el boton es visible o no</param>
        void NewButton(int count, int indice, string name, string text, string colorItem, string colorSubItem, bool visible = true)
        {
            JNButton[] button = new JNButton[count];
            button[indice] = new JNButton();
            //button1[0].Location = new Point(687, 197);
            button[indice].UseVisualStyleBackColor = true;
            //button1[0].Size = new Size(228, 200);
            button[indice].Visible = visible;
            button[indice].Dock = DockStyle.Top;
            button[indice].Name = name;
            button[indice].Text = text;
            button[indice].Click += new EventHandler(DynamicButton_Click);
            //panel1.Controls.Clear();
            this.Controls.Add(button[indice]);


            //Form oform = new Form();

            //oform = (Form)Activator.CreateInstance("sc", "sc." + "frmAbmPlan").Unwrap();

            //oform.Name = "frmAbmPlan";

            //oform.ShowDialog();
        }

        public void DynamicButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            //var buttonClick = ((JNButton)sender).Text;

            //            subItem= "jona";

            //menuSource.Reverse();
            //for (int i = 0; i < menuSource.Count; i++)
            //{
            //    if (menuSource[i].Item == buttonClick)
            //    {
            //        if (menuSource[i].SubItem.Length >= 0)
            //        {
            //            this.Controls.Add(((JNButton)sender).Visible = true);


            //            MessageBox.Show("Test");
            //        }
            //    }

            //}

            //foreach (var item in this.Controls)
            //{
            //    if (item is JNButton)
            //    {
            //        if (((JNButton)item).Text == buttonClick)
            //        {
            //            ((JNButton)item).Visible = true;
            //        }
            //    }
            //}



            //foreach (var item in this.jnMenu1.Controls)
            //{
            //if (item is JNButton)
            //{
            //    if (((JNButton)item).Visible == false)
            //    {
            //        //if (((JNButton)item).Text == )
            //        //{

            //        //}
            //        ((JNButton)item).Visible = true;
            //        //MessageBox.Show(Convert.ToString(((JNButton)item).Text));

            //    }
            //}
            //}
            //menuSource.Reverse();

            for (int i = 0; i < menuSource.Count; i++)
            {
                //if (menuSource[i].Item == this.Text)
                //{
                //    if (menuSource[i].SubItem.Length >= 0)
                //    {
                //        MessageBox.Show("Test");
                //    }
                //}



                //string item = menuSource[i].Item;

                //NewButton(menuSource.Count, 0, $"btn{item}", item, "", "");
                ////MessageBox.Show(MenuList[i].Item.ToString());
                //{
                //    if (menuSource[i].SubItem != null)
                //        for (int j = 0; j < menuSource[i].SubItem.Length; j++)
                //        {
                //            string subitem = menuSource[i].SubItem[j];
                //            NewButton(menuSource.Count, 0, subitem, subitem, "", "", false);
                //            // MessageBox.Show(MenuList[i].SubItem[j].ToString());
                //        }
                //}
            }

        }



        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
