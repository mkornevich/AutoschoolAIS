using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoschoolAIS.Controls
{
    public class TableView : DataGridView
    {
        private DataGridViewCheckBoxColumn _selectColumn = new DataGridViewCheckBoxColumn()
        {
            ValueType = typeof(bool),
            Name = "SelectColumn",
            HeaderText = "",
            Width = 30,
            Resizable = DataGridViewTriState.False,
        };

        public bool IsMultiselect { get; set; } = false;

        public event Action SelectBoxClick;

        private List<int> _ids = new List<int>();

        public List<int> Ids
        {
            get => _ids;
            set
            {
                _ids = value;
                LoadIdsToTable();
            }
        }

        public IEnumerable<dynamic> DataSourceDynamic
        {
            set
            {
                var rows = value.ToArray();

                if (rows.Count() == 0)
                {
                    return;
                }

                var dataTable = new DataTable();

                foreach (var pair in (IDictionary<string, object>)rows[0])
                {
                    dataTable.Columns.Add(pair.Key, pair.Value.GetType());
                }

                foreach (var row in rows)
                {
                    dataTable.Rows.Add(((IDictionary<string, object>)row).Values.ToArray());
                }

                DataSource = dataTable;
            }
        }

        public TableView()
        {
            BorderStyle = BorderStyle.None;
            BackgroundColor = SystemColors.Control;
            RowHeadersVisible = false;
            MultiSelect = false;
            ReadOnly = true;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToResizeRows = false;

            if (!Env.DesignMode)
            {
                Columns.Add(_selectColumn);
            }

            CellContentClick += CellContentClickAct;
            DataBindingComplete += (s, e) => LoadIdsToTable();
        }

        private void LoadIdsToTable()
        {
            foreach (DataGridViewRow row in Rows)
            {
                if (row.Cells["IdColumn"].Value != null)
                {
                    row.Cells["SelectColumn"].Value = Ids.Contains((int)row.Cells["IdColumn"].Value);
                }
            }
        }

        private void CellContentClickAct(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                return;
            }

            if (!IsMultiselect)
            {
                foreach (DataGridViewRow row in Rows)
                {
                    if (row.Index != e.RowIndex)
                    {
                        row.Cells["SelectColumn"].Value = false;
                    }
                }
                _ids.Clear();
            }

            var selectCell = Rows[e.RowIndex].Cells[e.ColumnIndex];
            selectCell.Value = !Convert.ToBoolean(selectCell.Value);
            int id = (int)Rows[selectCell.RowIndex].Cells["IdColumn"].Value;

            if (Convert.ToBoolean(selectCell.Value))
            {
                _ids.Add(id);
            }
            else
            {
                _ids.Remove(id);
            }

            OnSelectBoxClick();
        }

        private void OnSelectBoxClick() => SelectBoxClick?.Invoke();
    }
}
