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

using Autodesk.Navisworks.Api;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ForgeViewpointPlugin
{
    public partial class VpSetterForm : Form
    {
        public VpSetterForm()
        {
            InitializeComponent();

            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width * 2, base.Height);
            this.MinimumSize = new Size(0, base.Height);
        }

        private void btnVpSetter_Click(object sender, EventArgs e)
        {
            Document doc = Autodesk.Navisworks.Api.Application.ActiveDocument;
            Viewpoint vp = doc.CurrentViewpoint.CreateCopy();
            string offsetX = this.tbLmvModelOffsetsX.Text;
            string offsetY = this.tbLmvModelOffsetsY.Text;
            string offsetZ = this.tbLmvModelOffsetsZ.Text;
            Point3D offset = this.validateInput(offsetX, offsetY, offsetZ);

            if (offset == null)
            {
                MessageBox.Show("Invalid model offset (e.g. Global Offsets)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            offset = offset.ToVector3D().Negate().ToPoint3D();

            string posX = this.tbLmvCameraPosX.Text;
            string posY = this.tbLmvCameraPosY.Text;
            string posZ = this.tbLmvCameraPosZ.Text;
            Point3D pos = this.validateInput(posX, posY, posZ);

            if (pos == null)
            {
                MessageBox.Show("Invalid camera position", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            pos = pos.Subtract(offset).ToPoint3D();

            string targetX = this.tbLmvCameraTargetX.Text;
            string targetY = this.tbLmvCameraTargetY.Text;
            string targetZ = this.tbLmvCameraTargetZ.Text;
            Point3D target = this.validateInput(targetX, targetY, targetZ);

            if (target == null)
            {
                MessageBox.Show("Invalid camera target", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            target = target.Subtract(offset).ToPoint3D();

            string upX = this.tbLmvCameraUpX.Text;
            string upY = this.tbLmvCameraUpY.Text;
            string upZ = this.tbLmvCameraUpZ.Text;
            Point3D up = this.validateInput(upX, upY, upZ);

            if (up == null)
            {
                MessageBox.Show("Invalid camera up", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            vp.Position = pos;
            vp.PointAt(target);
            vp.AlignUp(up.ToVector3D());
            doc.CurrentViewpoint.CopyFrom(vp);
        }

        private Point3D validateInput(string xVal, string yVal, string zVal)
        {
            try
            {
                double x = double.Parse(xVal);
                double y = double.Parse(yVal);
                double z = double.Parse(zVal);
                return new Point3D(x, y, z);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
