using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoschoolAIS.Services.Auth
{
    public class AuthService
    {
        private DataRow _user;

        public event Action UserChanged;

        public DataRow User
        {
            get => _user;
            set
            {
                _user = value;
                OnUserChanged();
            }
        }

        public bool IsAuth => User != null;

        private void OnUserChanged()
        {
            UserChanged?.Invoke();
        }

        public void Logout()
        {
            User = null;
        }

        public bool HasRole(string role)
        {
            if (User == null)
            {
                return false;
            }

            return User["Role"].ToString() == role;
        }

        public bool TryAuthenticate(string email, string password)
        {
            var adapter = Env.Db.CreateDataAdapter(
                "SELECT * FROM [User] WHERE Email = @Email AND Password = @Password");
            
            adapter.SelectCommand.Parameters.AddWithValue("@Email", email);
            adapter.SelectCommand.Parameters.AddWithValue("@Password", password);

            var dataSet = new DataSet();
            adapter.Fill(dataSet);

            var table = dataSet.Tables[0];
            if (table.Rows.Count == 0)
            {
                return false;
            }

            User = table.Rows[0];
            return true;
        }
    }
}
