﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace s6_2
{
    class EmailCheckException : ApplicationException
    {
        public EmailCheckException(string message): base(message)
        {
            MessageBox.Show(message, "出错提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
