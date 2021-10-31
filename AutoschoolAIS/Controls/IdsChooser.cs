using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoschoolAIS.Controls
{
    public class IdsChooser : Chooser
    {
        private List<int> _ids = new List<int>();

        public List<int> Ids
        {
            get
            {
                if (_tableView != null)
                {
                    return _tableView.Ids;
                }
                return _ids;
            }
            set
            {
                if (_tableView != null)
                {
                    _tableView.Ids = value;
                }
                _ids = value;
                OnIdsChanged();
            }
        }

        public int? Id
        {
            get
            {
                if (Ids.Count != 1)
                {
                    return null;
                }
                return Ids[0];
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Id need to be not null.");
                }
                Ids = new List<int>() { (int)value };
            }
        }

        private bool _isMultiselect = false;

        public bool IsMultiselect
        {
            get
            {
                if (_tableView != null)
                {
                    return _tableView.IsMultiselect;
                }
                return _isMultiselect;
            }
            set
            {
                if (_tableView != null)
                {
                    _tableView.IsMultiselect = value;
                }
                _isMultiselect = value;
            }
        }

        public event Action IdsChanged;

        public Func<TableView> BuildTableViewFunction;

        public string SqlGetTextById { get; set; } = null;

        private TableView _tableView = null;

        public IdsChooser()
        {
            ClickChoose += ClickChooseAct;
            if (!Env.DesignMode)
            {
                Env.Change.DatabaseChanged += UpdateText;
            }
        }

        private void ClickChooseAct(object sender, EventArgs e)
        {
            if (_tableView == null)
            {
                _tableView = BuildTableViewFunction();
                _tableView.SelectBoxClick += OnIdsChanged;
                _tableView.Ids = _ids;
                _tableView.IsMultiselect = _isMultiselect;
                _tableView.FindForm().MdiParent = Env.MainForm;
                _tableView.FindForm().FormClosed += FormClosedAct;
            }

            _tableView.FindForm().Show();
        }

        private void FormClosedAct(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            _tableView.SelectBoxClick -= OnIdsChanged;
            _tableView = null;
        }

        protected void OnIdsChanged()
        {
            IdsChanged?.Invoke();
            UpdateText();
        }

        private void UpdateText()
        {
            Text = "Пусто";

            if (Ids.Count == 1 && SqlGetTextById != null)
            {
                var command = Env.Db.CreateCommand(SqlGetTextById);
                command.Parameters.AddWithValue("Id", Ids[0]);
                Text = (string)command.ExecuteScalar();
            }

            if (Ids.Count > 1)
            {
                Text = "Выбрано: " + Ids.Count.ToString();
            }
        }
    }
}
