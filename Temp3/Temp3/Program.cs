﻿using System;
using System.Windows.Forms;

namespace Proiect
{
    static class Program
    {
        static void Main ( )
        {
            Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault (false);
            Application.Run (new IMDB.Login ());
        }
    }
}