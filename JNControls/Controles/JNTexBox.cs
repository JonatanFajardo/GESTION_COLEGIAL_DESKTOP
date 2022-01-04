using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace JNControls.Controles
{
    public partial class JNTexBox : UserControl
    {

        //Default Event
        public event EventHandler _TextChanged;
        //TextBox-> TextChanged event
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }
        public JNTexBox()
        {
            InitializeComponent();
            //this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(10, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 15);
            this.textBox1.TabIndex = 0;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // RJTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.textBox1);
            this.Font = new Font("Microsoft Sans Serif", 9.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JNTextBox";
            this.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Size = new System.Drawing.Size(250, 30);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        //private void InitializeComponent()
        //{

        //}
        #endregion

        ///private System.Windows.Forms.TextBox textBox1;


        #region Fiels
        private Color borderColor = Color.FromArgb(224, 224, 224);
        private Color borderFocusColor = Color.Silver;
        private Color borderColorError = Color.Red;
        private int borderSize = 1;
        private bool underlinedStyle = false;
        private bool isFocused = false;

        private int borderRadius = 0;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;

        private Estados typeDate = Estados.Ninguno;




        private TrueFalse require = TrueFalse.False;


        /// <summary>
        /// Almacena el color del borde para que este no se pierda
        /// </summary>
        Color pivoteColorBorde;

        #endregion Fiels


        #region -> Private methods
        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = placeholderColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = false;
            }
        }
        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = true;
            }
        }
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        #endregion


        #region -> Properties
        [Category("JN Controls")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("JN Controls")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        [Category("JN Controls")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                if (value >= 1)
                {
                    borderSize = value;
                    this.Invalidate();
                }
            }
        }

        [Category("JN Controls")]
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("JN Controls")]
        public bool PasswordChar
        {
            get { return isPasswordChar; }
            set
            {
                isPasswordChar = value;
                if (!isPlaceholder)
                    textBox1.UseSystemPasswordChar = value;
            }
        }

        [Category("JN Controls")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        [Category("JN Controls")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("JN Controls")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("JN Controls")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("JN Controls")]
        public string Texts
        {
            get
            {
                if (isPlaceholder) return "";
                else return RemoveSpaces(textBox1.Text);
            }
            set
            {
                textBox1.Text = RemoveSpaces(value);
                SetPlaceholder();
            }
        }


        [Category("JN Controls")]
        [Description("")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();//Redraw control
                }
            }
        }

        [Category("JN Controls")]
        [Description("Indica el color del texto mostrado al estar vacio el control.")]
        public Color PlaceholderColor
        {
            get { return placeholderColor; }
            set
            {
                placeholderColor = value;
                if (isPlaceholder)
                    textBox1.ForeColor = value;
            }
        }

        [Category("JN Controls")]
        [Description("Muestra un texto cuando el control esta vacio")]
        public string PlaceholderText
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                textBox1.Text = "";
                SetPlaceholder();
            }
        }

        [Category("JN Controls")]
        [Description("Establecer como true si quiere que el control se limpie despues de una accion especificada.")]
        public bool CleanCompleted { get; set; }

        [Category("JN Controls")]
        [Description("Color que se muestra en el contorno del control si este no cumple con las validaciones indicadas.")]
        public Color BorderColorError { get { return borderColorError; } set { borderColorError = value; } }


        [Category("JN Controls Validation")]
        [Description("Indica si el control puede estar vacío.")]
        public TrueFalse Require { get { return require; } set { require = value; } }

        string valor;
        [Category("JN Controls Validation")]
        [Description("")]
        public Estados TypeDate
        {
            get { return typeDate; }
            set { typeDate = value; }
        }

        #endregion

        #region -> Overridden methods
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
            pivoteColorBorde = borderColor;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRadius > 1)//Rounded TextBox
            {
                //-Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //-Drawing
                    this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                    if (borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlinedStyle) //Line Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Normal Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else //Square/Normal TextBox
            {
                //Draw border
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlinedStyle) //Line Style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Normal Style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }
        #endregion


        /// <summary>
        /// Validamos si el campo es requerido
        /// </summary>
        //Intanciaciones
        ErrorProvider errorProvider = new ErrorProvider();//instancia para el empty
                                                          //int PivoteBorderSize = 0;


        //Evento que se activa cuando el cursor sale
        protected override void OnLeave(EventArgs e)
        {
            if (this.require == TrueFalse.True)
            {
                if (this.Texts == "")
                {
                    //pivoteColorBorde = borderColor;
                    borderColor = borderColorError;
                    errorProvider.SetError(this, "El campo es requerido");
                    //this.Texts = valor;
                }
                else
                {
                    borderColor = pivoteColorBorde;
                }

            }
            ////saber si cuando sale el esta vacio
            ////==EMPTY
            //if (require == TrueFalse.False)
            //{//base
            //    base.OnLeave(e);
            //}
            //else if (require == TrueFalse.True)
            //{
            //    if (string.IsNullOrEmpty(this.Text))
            //    {
            //        //PivoteBorderSize = BorderSize;
            //        //if (BorderSize == 0)
            //        //{
            //        //    BorderSize = 1;
            //        //}
            //        borderColor = Color.Red;
            //        //errorProvider.SetError(this, "Este Campo no puede estar vacio");
            //    }
            //    else if (!string.IsNullOrEmpty(this.Texts))
            //    {
            //        borderColor = Color.Gray;
            //        //errorProvider
            //        //errorProvider.Clear();
            //    }
            //}
        }




        /// <summary>
        /// Validamos el tipo de valor que aceptara el control
        /// </summary>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            if (typeDate == Estados.Ninguno)
            {
                //nos trae lo que hace el metodo de la clase base
                base.OnKeyPress(e);
            }
            else if (typeDate == Estados.Letters)
            {
                e.Handled = !Letters(e.KeyChar);//true o false
            }//recibimos true si son solo letras las que se reciben en el texbox
            else if (typeDate == Estados.Numbers)
            {
                //Moneda();
                e.Handled = !Numbers(e.KeyChar);
            }

        }




























        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceholder();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceholder();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }


        #region Enum
        public enum Estados
        {
            Ninguno,
            Numbers,
            Letters,
        }
        public enum TrueFalse
        {
            False,
            True,
        }
        #endregion Enum


        #region Helpers
        /// <summary>
        /// Remueve los espacios dobles de un string
        /// </summary>
        /// <param name="valor">Valor al que se desea preparar.</param>
        /// <returns>string: Valor formateado.</returns>
        static string RemoveSpaces(string valor)
        {
            while (valor.Contains("  "))
            {
                valor = valor.Replace("  ", " ");
            }

            return valor;
        }

        private Boolean Letters(char caracter)
        {
            if (char.IsLetter(caracter) || char.IsControl(caracter) || char.IsSeparator(caracter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private Boolean Numbers(char caracter)
        {
            if (char.IsDigit(caracter) || char.IsControl(caracter) || char.IsPunctuation(caracter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion Helpers


    }
}
