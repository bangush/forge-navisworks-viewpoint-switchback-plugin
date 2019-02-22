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

using System;
using System.Windows.Forms;
using Autodesk.Navisworks.Api.Plugins;

namespace ForgeViewpointPlugin
{
    [Plugin("ForgeViewpointPlugin", "ADN")]
    [RibbonLayout("ForgeViewpointPluginRibbon.xaml")]
    [RibbonTab("ID_ForgeViewpointPluginTab_1", DisplayName = "Autodesk Forge")]
    [Command("ID_SetCurrentVP", Icon = "viewpoint.png", LargeIcon = "viewpoint.png", CanToggle = false, DisplayName = " Set VP ")]
    public class Main : CommandHandlerPlugin
    {
        public override bool CanExecuteRibbonTab(string name)
        {
            return true;
        }

        public override int ExecuteCommand(string name, params string[] parameters)
        {
            try
            {
                if (name == "ID_SetCurrentVP")
                {
                    var form = new VpSetterForm();
                    form.ShowWithOwner();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            return 0;
        }
    }
}
