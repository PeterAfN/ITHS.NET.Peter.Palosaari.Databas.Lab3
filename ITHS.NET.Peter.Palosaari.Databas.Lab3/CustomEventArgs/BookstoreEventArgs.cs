﻿using System;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.CustomEventArgs
{
    public class BookstoreEventArgs : EventArgs
    {
        public Butiker Butik { get; set; }
        public int IndexSelectedChildNode { get; set; } = -1; //value of -1 means no childnode is selected.
        public int IndexSelectedParentNode { get; set; }

        public BookstoreEventArgs(Butiker Butik)
        {
            this.Butik = Butik;
        }
    }
}
