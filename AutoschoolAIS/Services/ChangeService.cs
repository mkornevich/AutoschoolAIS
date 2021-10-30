﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoschoolAIS.Services
{
    public class ChangeService
    {
        public event Action DatabaseChanged;

        public void OnDatabaseChanged()
        {
            DatabaseChanged?.Invoke();
        }
    }
}
