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

        public event Action IdsChanged;

        public Func<TableView> BuildTableViewFunction;

        public string SqlGetTextById { get; set; } = null;

        private TableView _tableView = null;

        public IdsChooser()
        {
            ClickChoose += ClickChooseAct;
        }

        private void ClickChooseAct(object sender, EventArgs e)
        {
            if (_tableView == null)
            {
                _tableView = BuildTableViewFunction();
                _tableView.SelectBoxClick += OnIdsChanged;
                _tableView.Ids = _ids;
                _tableView.FindForm().MdiParent = Env.MainForm;
                _tableView.FindForm().FormClosed += FormClosedAct;
            }

            _tableView.FindForm().Show();
        }

        private void SelectBoxClickAct()
        {
            IdsChanged?.Invoke();
        }

        private void FormClosedAct(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            _tableView.SelectBoxClick -= SelectBoxClickAct;
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
                var command = Env.Database.CreateCommand(SqlGetTextById);
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
