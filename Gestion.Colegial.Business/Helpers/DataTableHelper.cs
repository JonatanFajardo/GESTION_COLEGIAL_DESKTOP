using Gestion.Colegial.Commons.Entities;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestion.Colegial.Business.Helpers
{
    public static class DataTableHelper
    {
        public static void DataGridViewLengthLoad(ComboBox dataGridViewLength = null)
        {
            //cbAmount.Items.Clear();
            if (dataGridViewLength != null)
            {
                List<ComboboxValue> comboboxValues = new List<ComboboxValue>()
                {
                    new ComboboxValue() { Index = 10, Value = 10 },
                    new ComboboxValue() { Index = 25, Value = 25 },
                    new ComboboxValue() { Index = 50, Value = 50 },
                    new ComboboxValue() { Index = 100, Value = 100 }
                };
                dataGridViewLength.DataSource = comboboxValues;
                dataGridViewLength.ValueMember = "Index";
                dataGridViewLength.DisplayMember = "Value";
                //dataGridViewLength.DataBindings();
            }
        }
    }
}
