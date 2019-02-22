/////////////////////////////////////////////////////////////////////
// Copyright (c) Autodesk, Inc. All rights reserved
// Written by Forge Partner Development
//
// Permission to use, copy, modify, and distribute this software in
// object code form for any purpose and without fee is hereby granted,
// provided that the above copyright notice appears in all copies and
// that both that copyright notice and the limited warranty and
// restricted rights notice below appear in all supporting
// documentation.
//
// AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS.
// AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  AUTODESK, INC.
// DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
// UNINTERRUPTED OR ERROR FREE.
/////////////////////////////////////////////////////////////////////

using System.Diagnostics;
using System.Windows.Forms;

namespace ForgeViewpointPlugin
{
    public static class WindowsFormExtension
    {
        public static void ShowWithOwner(this Form form)
        {
            var process = Process.GetCurrentProcess();
            var h = process.MainWindowHandle;

            form.Show(new JtWindowHandle(h));
        }

        public static void ShowDialogWithOwner(this Form form)
        {
            var process = Process.GetCurrentProcess();
            var h = process.MainWindowHandle;

            form.ShowDialog(new JtWindowHandle(h));
            form.Focus();
            form.Enabled = false;
        }
    }
}
