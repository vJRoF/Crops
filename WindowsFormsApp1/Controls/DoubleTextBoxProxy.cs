﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Controls
{
    /// <summary>
    /// Because can't create generic userControl directly
    /// </summary>
    class DoubleTextBoxProxy : NumberTextBox<double>
    {
    }
}
