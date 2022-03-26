using Gestion.Colegial.Business.Services;
using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.Commons.Extensions;
using JNControls.Controles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion.Colegial.UI.FormsBase
{
    public partial class BaseMain : Form
    {
        List<SideBar> menuList = new List<SideBar>();

        private dynamic menuSource = null;

        public string subItem = null;

        public BaseMain()
        {
            InitializeComponent();


            List<SideBar> MenuList = new List<SideBar>()
            {
                new SideBar() { Item = "Inicio" },
                new SideBar() { Item = "Personas", SubItem = new[] { "Estudiantes", "Encargados", "Docentes", "Parentescos", "Cargos" } },
                new SideBar() { Item = "Horario", SubItem = new[] { "Horario Alumnos", "Horario Profesores", "Horas", "Dias" } },
                new SideBar() { Item = "Cursos", SubItem = new[] { "Cursos Niveles", "Cursos Nombres", "Duraciones", "Materias", "Modalidades", "Niveles Educativos", "Parciales", "Secciones", "Semestres" } },
                new SideBar() { Item = "Logistica" }

            };
            menuSource = MenuList;


            lblYear.Text = DateTime.Now.Year.ToString();

        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            nose(menuSource);

            Answer Alumnos = await HomeService.AlumnosList();
            Answer Encargados = await HomeService.EncargadosList();
            Answer Empleados = await HomeService.EmpleadosList();

            if (Alumnos.Access)
                lbCountAlumnos.Text = "0";

            if (Encargados.Access)
                lbCountEmpleados.Text = "0";

            if (Empleados.Access)
                lbCountAlumnos.Text = "0";



            lbCountAlumnos.Text = Alumnos.Data.Rows.Count.ToString();
            lbCountEncargados.Text = Encargados.Data.Rows.Count.ToString();
            lbCountEmpleados.Text = Empleados.Data.Rows.Count.ToString();


            OpenChildForm(new Forms.Home.Main());

        }


        public void DynamicButton_Click(object sender, EventArgs e)
        {
            //menuSource.Reverse();
            ShowHidenSubItems(menuSource, sender);
            ShowFormButton(sender);
        }

        /// <summary>
        /// Muestra el formulario especificado para cada boton.
        /// </summary>
        /// <param name="source"></param>
        private void ShowFormButton(object source)
        {

            //Verificamos que no venga nula para no provocar una excepcion
            if (source != null)
            {
                string valor = (((JNButton)source).Text);

                switch (valor)
                {
                    case "Inicio":
                        OpenChildForm(new Forms.Home.Main());
                        break;
                    case "Estados":
                        OpenChildForm(new Forms.Estados.List());
                        break;
                    case "HorarioAlumnos":
                        OpenChildForm(new Forms.HorarioAlumnos.List());
                        break;
                    case "HorarioProfesores":
                        OpenChildForm(new Forms.HorarioProfesores.List());
                        break;
                    case "Horas":
                        OpenChildForm(new Forms.Horas.List());
                        break;
                    case "Materias":
                        OpenChildForm(new Forms.Materias.List());
                        break;
                    case "Matricula":
                        OpenChildForm(new Forms.Matricula.List());
                        break;
                    case "Modalidades":
                        OpenChildForm(new Forms.Modalidades.List());
                        break;
                    case "NivelesEducativos":
                        OpenChildForm(new Forms.NivelesEducativos.List());
                        break;
                    case "Notas":
                        OpenChildForm(new Forms.Notas.List());
                        break;
                    case "Parciales":
                        OpenChildForm(new Forms.Parciales.List());
                        break;
                    case "Parentescos":
                        OpenChildForm(new Forms.Parentescos.List());
                        break;
                    case "Secciones":
                        OpenChildForm(new Forms.Secciones.List());
                        break;
                    case "Semestres":
                        OpenChildForm(new Forms.Semestres.List());
                        break;
                    case "Titulos":
                        OpenChildForm(new Forms.Titulos.List());
                        break;
                    case "Alumnos":
                        OpenChildForm(new Forms.Alumnos.List());
                        break;
                    case "Aulas":
                        OpenChildForm(new Forms.Aulas.List());
                        break;
                    case "Cargos":
                        OpenChildForm(new Forms.Cargos.List());
                        break;
                    case "Cursos":
                        OpenChildForm(new Forms.Cursos.List());
                        break;
                    case "CursosNiveles":
                        OpenChildForm(new Forms.CursosNiveles.List());
                        break;
                    case "Dias":
                        OpenChildForm(new Forms.Dias.List());
                        break;
                    case "Duraciones":
                        OpenChildForm(new Forms.Duraciones.List());
                        break;
                    case "Empleados":
                        OpenChildForm(new Forms.Empleados.List());
                        break;
                    case "Encargados":
                        OpenChildForm(new Forms.Encargados.List());
                        break;
                }



                //Form oform = new Form();

                //oform = (Form)Activator.CreateInstance("cs", "cs." + "formularioModalidades").Unwrap();

                //oform.Name = "formularioModalidades";

                //oform.ShowDialog();

                //Recorremos y agregamos los botones principales
                //for (int i = 0; i < ; i++)
                //{

                //}
            }
        }

        #region Menu

        public void nose(dynamic Source)
        {
            //Verificamos que no venga nula para no provocar una excepcion
            if (Source != null)
            {
                Source.Reverse();
                //Recorremos y agregamos los botones principales
                for (int i = 0; i < Source.Count; i++)
                {
                    string item = Source[i].Item;
                    if (Source[i].SubItem != null)
                    {
                        for (int j = 0; j < Source[i].SubItem.Length; j++)
                        {
                            // menuSource.Reverse();
                            string subitem = Source[i].SubItem[j];
                            JNButton boton2 = new JNButton();
                            boton2.Name = $"btn{subitem}";
                            boton2.Text = subitem;
                            boton2.ForeColor = Color.White;
                            boton2.BorderRadius = 14;
                            // boton2.BorderRadius = 5;
                            boton2.Padding = new Padding(16, 0, 0, 0);
                            boton2.BackColor = Color.FromArgb(44, 52, 59);
                            Visible = false;
                            NewButton(Source.Count, 0, boton2);
                        }
                        //menuSource.Reverse();
                    }
                    JNButton boton = new JNButton();
                    boton.Name = $"btn{item}";
                    boton.BorderRadius = 14;
                    boton.Text = item;
                    boton.ForeColor = Color.White;
                    boton.Padding = new Padding(7, 0, 0, 0);
                    boton.BackColor = Color.FromArgb(44, 52, 59);
                    Visible = true;


                    NewButton(Source.Count, 0, boton);
                    //si el subitem es diferente de null que si lo recorra, asi evitamos excepciones
                }
            }
        }

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
        void NewButton(int count, int indice, JNButton boton)
        {
            JNButton[] button = new JNButton[count];
            button[indice] = new JNButton();
            //button1[0].Location = new Point(687, 197);
            button[indice].UseVisualStyleBackColor = true;
            //button1[0].Size = new Size(228, 200);
            button[indice].Visible = boton.Visible;
            button[indice].BackColor = boton.BackColor;
            button[indice].BorderColor = boton.BackColor;
            button[indice].ForeColor = boton.ForeColor;
            button[indice].Height = 40;
            button[indice].BorderRadius = boton.BorderRadius;
            button[indice].Dock = DockStyle.Top;
            button[indice].Padding = boton.Padding;
            button[indice].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button[indice].Name = boton.Name;
            button[indice].Text = boton.Text;
            button[indice].Click += new EventHandler(DynamicButton_Click);
            //panel1.Controls.Clear();
            jnMenu1.Controls.Add(button[indice]);


            //Form oform = new Form();

            //oform = (Form)Activator.CreateInstance("sc", "sc." + "frmAbmPlan").Unwrap();

            //oform.Name = "frmAbmPlan";

            //oform.ShowDialog();
        }

        /// <summary>
        /// Muestra o esconde un boton del menu en base a su visibilidad.
        /// </summary>
        /// <param name="valor">Nombre del JNButton</param>
        void ShowHidenJNButton(string valor)
        {
            //Recorre los controles del menu
            foreach (var item in this.jnMenu1.Controls)
            {
                //verificamos si es un JNButton
                if (item is JNButton)
                {
                    //si los nombres coinciden se muestran u oculta segun la visibilidad actual del boton.
                    if (((JNButton)item).Text == valor)
                    {
                        if (((JNButton)item).Visible == false)
                        {
                            ((JNButton)item).Visible = true;
                        }
                        else
                        {
                            ((JNButton)item).Visible = false;
                        }
                    }

                }
            }
        }

        /// <summary>
        /// Muestra el submenu que pertenece a un boton
        /// </summary>
        /// <param name="Source">Lista con datos del menu.</param>
        /// <param name="sender">Nombre del item seleccionado.</param>
        void ShowHidenSubItems(dynamic Source, object sender)
        {
            for (int i = 0; i < Source.Count; i++)
            {
                if (Source[i].Item == ((JNButton)sender).Text)
                {
                    //verifica si tiene subitems
                    if (Source[i].SubItem != null)
                    {
                        for (int j = 0; j < Source[i].SubItem.Length; j++)
                        {
                            ShowHidenJNButton(Source[i].SubItem[j]);
                            //((JNButton)).Visible = true;
                        }
                        ///this.Controls.Add(((JNButton)sender).Visible = true;
                    }
                }
            }
        }
        #endregion Menu


        private void EfectoScroll(Panel panel)
        {
            //pnMenuBottom.HorizontalScroll.Maximum = 0;
            //pnMenuBottom.AutoScroll = false;
            //pnMenuBottom.VerticalScroll.Visible = false;
            //pnMenuBottom.AutoScroll = true;
        }

        #region BotonesdeRegion
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnMaximiza_Click(object sender, EventArgs e)
        {
            btnMaximiza.Visible = false;
            btnRestaura.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnItems2_Click(object sender, EventArgs e)
        {
            //ShowSubmenu(pnSubItems2);

        }

        private void btnRestaura_Click(object sender, EventArgs e)
        {
            btnMaximiza.Visible = true;
            btnRestaura.Visible = false;
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion BotonesdeRegion

        public void DynamicButton_Click11(object sender, EventArgs e)
        {

            var buttonText = ((JNButton)sender).Text;
            //Query using buttonText
        }


        //revisar
        private void BaseMain_Load(object sender, EventArgs e)
        {
            // Cargamos los datos.
            lblUserName.Text = GlobalVariable.Usuario.Usu_Nombre;
            lblRol.Text = GlobalVariable.Usuario.Usu_Rol;


            //var listaBtnVerdes = jnMenu1.Controls.OfType<Button>().Where(c => c.BackColor == Color.Green).ToList();
            foreach (var item in this.jnMenu1.Controls)
            {
                if (item is JNButton)
                {

                    if (((JNButton)item).Visible == false)
                    {
                        //if (((JNButton)item).Text == menuList)
                        //{

                        //}

                        ((JNButton)item).Visible = true;
                        //MessageBox.Show(Convert.ToString(((JNButton)item).Text));

                    }
                }
            }
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnChildForm.Controls.Add(childForm);
            pnChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void jnButton1_Click(object sender, EventArgs e)
        {
            Forms.Modalidades.List lis = new Forms.Modalidades.List();
            lis.Show();
        }

        private async void jnPanel2_Paint(object sender, PaintEventArgs e)
        {

            //for (int i = 0; i <= last200values; i++)
            //{
            //    lbCountAlumnos.Text = i.ToString();
            //    timer1.Enabled = false;

            //}


        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
