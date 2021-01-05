﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public interface IViewBookstores
    {
        TreeView TreeViewBookstores { get; set; }

        event EventHandler Load;
        event TreeViewEventHandler _TreeViewBookstores_AfterSelect;
    }
}
