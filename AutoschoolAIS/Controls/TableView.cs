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

        public int? SelectedId
        {
            get
            {
                if (SelectedRows.Count > 0)
                {
                    return Convert.ToInt32(((DataRowView)SelectedRows[0].DataBoundItem).Row["Id"]);
                }
                return null;
            }
            set
            {
                if (value == null)
                {
                    return;
                }

                var row = Rows.Cast<DataGridViewRow>().ToList()
                    .Find(r => Convert.ToInt32(((DataRowView)r.DataBoundItem).Row["Id"]) == value);

                if (row != null)
                {
                    row.Selected = true;
                }
            }
        }

        public IEnumerable<dynamic> DataSourceDynamic
        {
            set
            {
                var selectedId = SelectedId;

                var rows = value.ToArray();

                if (rows.Count() == 0)
                {
                    Rows.Cast<DataGridViewRow>().ToList().ForEach(row => Rows.Remove(row));
                    return;
                }

                var dataTable = new DataTable();

                foreach (var pair in (IDictionary<string, object>)rows[0])
                {
                    dataTable.Columns.Add(pair.Key);
                }

                foreach (var row in rows)
                {
                    dataTable.Rows.Add(((IDictionary<string, object>)row).Values.ToArray());
                }

                DataSource = dataTable;

                SelectedId = selectedId;
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
                    row.Cells["SelectColumn"].Value = Ids.Contains(Convert.ToInt32(row.Cells["IdColumn"].Value));
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
            int id = Convert.ToInt32(Rows[selectCell.RowIndex].Cells["IdColumn"].Value);

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
