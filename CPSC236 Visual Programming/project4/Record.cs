﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_ListBox
{
    class Record
    {
        public string Title { get; set; }

        public int Year { get; set; }

        public string Genre { get; set; }

        public RecordType RecordType { get; set; }
    }

    enum RecordType { Book, Movie, Game }
}
