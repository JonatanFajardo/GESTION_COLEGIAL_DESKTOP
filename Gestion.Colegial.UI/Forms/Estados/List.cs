﻿using Gestion.Colegial.Business.Helpers.Alert;
using Gestion.Colegial.Business.Helpers.Export;
using Gestion.Colegial.Business.Helpers.ExportCustom;
using Gestion.Colegial.Business.Messagebox;
using Gestion.Colegial.Business.Services;
using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.Commons.Extensions;
using Gestion.Colegial.UI.FormsBase;
using Gestion.Colegial.UI.Helpers.Controles;
using JNControls.Controles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestion.Colegial.UI.Forms.Estados
{
    public partial class List : FormBase
    {
        public List()
        {
            InitializeComponent();

            //Estilos DataGridView
            dataGridViewJN1.RowTemplate.DividerHeight = 1;
            dataGridViewJN1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewJN1.ColumnHeadersHeight = 45;
            dataGridViewJN1.RowTemplate.DividerHeight = 1 / 3;//tamaño de linea row;
            dataGridViewJN1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewFill();

            // Configuraciones DGV

            // Agregado de botones de accion.
            List<DGVHeader> actionButtons = new List<DGVHeader>()
            {
                new DGVHeader(){Name = " ", Size = 65 },
                new DGVHeader(){Name = "Acciones", Size = 65 },
                new DGVHeader(){Name = "  ", Size = 65 },
            };
            dataGridViewJN1.AddBtn(actionButtons);

        }

        /// <summary>
        /// Carga los datos al datagridview con los datos especificados.
        /// </summary>
        /// <param name="buscar"></param>
        /// <param name="selected"></param>
        /// <param name="numberPagina"></param>
        public async void DataGridViewFill(string buscar = "")
        {
            // Cargamos DataGridView.
            ListResult listResult = new ListResult()
            {
                //numberPagina = numberPagina,
                //amount = selected,
                search = buscar
            };
            // Peticion de la data
            Answer data = await EstadosServices.List(buscar);
            if (!data.Access)
                dataGridViewJN1.DataSource = data.Data;// obj.Data;
            else
                MessageBox.Show(data.Message);

        }


        #region FuncionalidadesDGV
        private void jnButton1_Click(object sender, EventArgs e)
        {
            ///var obj = EstadosServices.List("");
            PdfCustom.DataSource(this.Text, dataGridViewJN1);
        }

        private void jnButton2_Click(object sender, EventArgs e)
        {
            //string[] ignore = new string[] { "Editar", "Detalle", "Eliminar" };
            Excel excel = new Excel();
            ///var obj = EstadosServices.List("");
            ////excel.DataSource(obj);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataGridViewFill(txtBuscar.Text);
        }
        #endregion  FuncionalidadesDGV


        #region AccionesCRUD

        /// <summary>
        /// Agrega un nuevo registro.
        /// </summary>
        public async override void Agregar()
        {
            Add add = new Add(this);
            ShowForm(add);
        }

        /// <summary>
        /// Edita o elimina registros en funcion de lo seleccionado en el DGV.
        /// </summary>
        /// <param name="e">Evento.</param>
        public async override void CellContentDGV(DataGridViewCellEventArgs e)
        {

            // Editamos registro.
            if (dataGridViewJN1.Rows[e.RowIndex].Cells[0].Selected)
            {
                // Objeto con la data que se selecciono.
                tbEstados objEstados = new tbEstados()
                {
                    Est_Id = Convert.ToInt32(dataGridViewJN1.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Value),
                    Est_Descripcion = dataGridViewJN1.Rows[e.RowIndex].Cells[e.ColumnIndex + 4].Value.ToString()
                };
                Add.Send(objEstados);
            }

            // Eliminamos registro.
            if (dataGridViewJN1.Rows[e.RowIndex].Cells[2].Selected)
            {
                Warning.ShowDialog("Desea eliminar esta fila?");
                if (Warning.isOk())
                {
                    tbEstados objEstados = new tbEstados()
                    {
                        Est_Id = (int)dataGridViewJN1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value,
                        //Est_Descripcion = dataGridViewJN1.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString()
                    };
                    Boolean resultService = await EstadosServices.Remove(objEstados.Est_Id);
                    DataGridViewFill();
                    if (resultService)
                    {
                        Alert.Show(Alert.enmType.Error, "No se ha podido eliminar la fila.", "Error");
                    }
                }
            }

        }

        #endregion AccionesCRUD

        #region Eventos
        private void button1_Click(object sender, EventArgs e)
        {
            Boolean CamposVacios;
            CamposVacios = Validation.CamposVacios(this);
            MessageBox.Show(CamposVacios.ToString());
        }

        #endregion Eventos

    }
}
