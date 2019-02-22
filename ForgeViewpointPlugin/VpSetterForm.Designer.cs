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

using System.Windows.Forms;

namespace ForgeViewpointPlugin
{
    partial class VpSetterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMainTitle = new System.Windows.Forms.Label();
            this.lbLmvCameraPosTitle = new System.Windows.Forms.Label();
            this.lbLmvCameraPosX = new System.Windows.Forms.Label();
            this.tbLmvCameraPosX = new System.Windows.Forms.TextBox();
            this.tbLmvCameraPosY = new System.Windows.Forms.TextBox();
            this.lbLmvCameraPosY = new System.Windows.Forms.Label();
            this.tbLmvCameraPosZ = new System.Windows.Forms.TextBox();
            this.lbLmvCameraPosZ = new System.Windows.Forms.Label();
            this.tbLmvCameraTargetZ = new System.Windows.Forms.TextBox();
            this.lbLmvCameraTargetZ = new System.Windows.Forms.Label();
            this.tbLmvCameraTargetY = new System.Windows.Forms.TextBox();
            this.lbLmvCameraTargetY = new System.Windows.Forms.Label();
            this.tbLmvCameraTargetX = new System.Windows.Forms.TextBox();
            this.lbLmvCameraTargetX = new System.Windows.Forms.Label();
            this.lbLmvCameraTargetTitle = new System.Windows.Forms.Label();
            this.tbLmvCameraUpZ = new System.Windows.Forms.TextBox();
            this.lbLmvCameraUpZ = new System.Windows.Forms.Label();
            this.tbLmvCameraUpY = new System.Windows.Forms.TextBox();
            this.lbLmvCameraUpY = new System.Windows.Forms.Label();
            this.tbLmvCameraUpX = new System.Windows.Forms.TextBox();
            this.lbLmvCameraUpX = new System.Windows.Forms.Label();
            this.lbLmvCameraUpTitle = new System.Windows.Forms.Label();
            this.btnVpSetter = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbLmvModelOffsetsX = new System.Windows.Forms.Label();
            this.lbLmvModelOffsetsTitle = new System.Windows.Forms.Label();
            this.tbLmvModelOffsetsX = new System.Windows.Forms.TextBox();
            this.tbLmvModelOffsetsY = new System.Windows.Forms.TextBox();
            this.tbLmvModelOffsetsZ = new System.Windows.Forms.TextBox();
            this.lbLmvModelOffsetsY = new System.Windows.Forms.Label();
            this.lbLmvModelOffsetsZ = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMainTitle
            // 
            this.lbMainTitle.AutoSize = true;
            this.lbMainTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMainTitle.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbMainTitle.Location = new System.Drawing.Point(3, 0);
            this.lbMainTitle.Name = "lbMainTitle";
            this.lbMainTitle.Size = new System.Drawing.Size(719, 50);
            this.lbMainTitle.TabIndex = 0;
            this.lbMainTitle.Text = "Forge Viewer Camera Definition";
            this.lbMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLmvCameraPosTitle
            // 
            this.lbLmvCameraPosTitle.AutoSize = true;
            this.lbLmvCameraPosTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLmvCameraPosTitle.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbLmvCameraPosTitle.Location = new System.Drawing.Point(3, 0);
            this.lbLmvCameraPosTitle.Name = "lbLmvCameraPosTitle";
            this.lbLmvCameraPosTitle.Size = new System.Drawing.Size(74, 25);
            this.lbLmvCameraPosTitle.TabIndex = 1;
            this.lbLmvCameraPosTitle.Text = "Position:";
            this.lbLmvCameraPosTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbLmvCameraPosX
            // 
            this.lbLmvCameraPosX.AutoSize = true;
            this.lbLmvCameraPosX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLmvCameraPosX.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbLmvCameraPosX.Location = new System.Drawing.Point(83, 0);
            this.lbLmvCameraPosX.Name = "lbLmvCameraPosX";
            this.lbLmvCameraPosX.Size = new System.Drawing.Size(14, 25);
            this.lbLmvCameraPosX.TabIndex = 2;
            this.lbLmvCameraPosX.Text = "x";
            this.lbLmvCameraPosX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLmvCameraPosX
            // 
            this.tbLmvCameraPosX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLmvCameraPosX.Location = new System.Drawing.Point(103, 3);
            this.tbLmvCameraPosX.Name = "tbLmvCameraPosX";
            this.tbLmvCameraPosX.Size = new System.Drawing.Size(187, 22);
            this.tbLmvCameraPosX.TabIndex = 3;
            this.tbLmvCameraPosX.Text = "0.0";
            // 
            // tbLmvCameraPosY
            // 
            this.tbLmvCameraPosY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLmvCameraPosY.Location = new System.Drawing.Point(316, 3);
            this.tbLmvCameraPosY.Name = "tbLmvCameraPosY";
            this.tbLmvCameraPosY.Size = new System.Drawing.Size(187, 22);
            this.tbLmvCameraPosY.TabIndex = 5;
            this.tbLmvCameraPosY.Text = "0.0";
            // 
            // lbLmvCameraPosY
            // 
            this.lbLmvCameraPosY.AutoSize = true;
            this.lbLmvCameraPosY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLmvCameraPosY.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbLmvCameraPosY.Location = new System.Drawing.Point(296, 0);
            this.lbLmvCameraPosY.Name = "lbLmvCameraPosY";
            this.lbLmvCameraPosY.Size = new System.Drawing.Size(14, 25);
            this.lbLmvCameraPosY.TabIndex = 4;
            this.lbLmvCameraPosY.Text = "y";
            this.lbLmvCameraPosY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLmvCameraPosZ
            // 
            this.tbLmvCameraPosZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLmvCameraPosZ.Location = new System.Drawing.Point(529, 3);
            this.tbLmvCameraPosZ.Name = "tbLmvCameraPosZ";
            this.tbLmvCameraPosZ.Size = new System.Drawing.Size(187, 22);
            this.tbLmvCameraPosZ.TabIndex = 7;
            this.tbLmvCameraPosZ.Text = "0.0";
            // 
            // lbLmvCameraPosZ
            // 
            this.lbLmvCameraPosZ.AutoSize = true;
            this.lbLmvCameraPosZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLmvCameraPosZ.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbLmvCameraPosZ.Location = new System.Drawing.Point(509, 0);
            this.lbLmvCameraPosZ.Name = "lbLmvCameraPosZ";
            this.lbLmvCameraPosZ.Size = new System.Drawing.Size(14, 25);
            this.lbLmvCameraPosZ.TabIndex = 6;
            this.lbLmvCameraPosZ.Text = "z";
            this.lbLmvCameraPosZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLmvCameraTargetZ
            // 
            this.tbLmvCameraTargetZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLmvCameraTargetZ.Location = new System.Drawing.Point(529, 28);
            this.tbLmvCameraTargetZ.Name = "tbLmvCameraTargetZ";
            this.tbLmvCameraTargetZ.Size = new System.Drawing.Size(187, 22);
            this.tbLmvCameraTargetZ.TabIndex = 14;
            this.tbLmvCameraTargetZ.Text = "0.0";
            // 
            // lbLmvCameraTargetZ
            // 
            this.lbLmvCameraTargetZ.AutoSize = true;
            this.lbLmvCameraTargetZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLmvCameraTargetZ.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbLmvCameraTargetZ.Location = new System.Drawing.Point(509, 25);
            this.lbLmvCameraTargetZ.Name = "lbLmvCameraTargetZ";
            this.lbLmvCameraTargetZ.Size = new System.Drawing.Size(14, 25);
            this.lbLmvCameraTargetZ.TabIndex = 13;
            this.lbLmvCameraTargetZ.Text = "z";
            this.lbLmvCameraTargetZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLmvCameraTargetY
            // 
            this.tbLmvCameraTargetY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLmvCameraTargetY.Location = new System.Drawing.Point(316, 28);
            this.tbLmvCameraTargetY.Name = "tbLmvCameraTargetY";
            this.tbLmvCameraTargetY.Size = new System.Drawing.Size(187, 22);
            this.tbLmvCameraTargetY.TabIndex = 12;
            this.tbLmvCameraTargetY.Text = "0.0";
            // 
            // lbLmvCameraTargetY
            // 
            this.lbLmvCameraTargetY.AutoSize = true;
            this.lbLmvCameraTargetY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLmvCameraTargetY.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbLmvCameraTargetY.Location = new System.Drawing.Point(296, 25);
            this.lbLmvCameraTargetY.Name = "lbLmvCameraTargetY";
            this.lbLmvCameraTargetY.Size = new System.Drawing.Size(14, 25);
            this.lbLmvCameraTargetY.TabIndex = 11;
            this.lbLmvCameraTargetY.Text = "y";
            this.lbLmvCameraTargetY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLmvCameraTargetX
            // 
            this.tbLmvCameraTargetX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLmvCameraTargetX.Location = new System.Drawing.Point(103, 28);
            this.tbLmvCameraTargetX.Name = "tbLmvCameraTargetX";
            this.tbLmvCameraTargetX.Size = new System.Drawing.Size(187, 22);
            this.tbLmvCameraTargetX.TabIndex = 10;
            this.tbLmvCameraTargetX.Text = "0.0";
            // 
            // lbLmvCameraTargetX
            // 
            this.lbLmvCameraTargetX.AutoSize = true;
            this.lbLmvCameraTargetX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLmvCameraTargetX.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbLmvCameraTargetX.Location = new System.Drawing.Point(83, 25);
            this.lbLmvCameraTargetX.Name = "lbLmvCameraTargetX";
            this.lbLmvCameraTargetX.Size = new System.Drawing.Size(14, 25);
            this.lbLmvCameraTargetX.TabIndex = 9;
            this.lbLmvCameraTargetX.Text = "x";
            this.lbLmvCameraTargetX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbLmvCameraTargetTitle
            // 
            this.lbLmvCameraTargetTitle.AutoSize = true;
            this.lbLmvCameraTargetTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLmvCameraTargetTitle.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbLmvCameraTargetTitle.Location = new System.Drawing.Point(3, 25);
            this.lbLmvCameraTargetTitle.Name = "lbLmvCameraTargetTitle";
            this.lbLmvCameraTargetTitle.Size = new System.Drawing.Size(74, 25);
            this.lbLmvCameraTargetTitle.TabIndex = 8;
            this.lbLmvCameraTargetTitle.Text = "Target:";
            this.lbLmvCameraTargetTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLmvCameraUpZ
            // 
            this.tbLmvCameraUpZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLmvCameraUpZ.Location = new System.Drawing.Point(529, 53);
            this.tbLmvCameraUpZ.Name = "tbLmvCameraUpZ";
            this.tbLmvCameraUpZ.Size = new System.Drawing.Size(187, 22);
            this.tbLmvCameraUpZ.TabIndex = 21;
            this.tbLmvCameraUpZ.Text = "1.0";
            // 
            // lbLmvCameraUpZ
            // 
            this.lbLmvCameraUpZ.AutoSize = true;
            this.lbLmvCameraUpZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLmvCameraUpZ.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbLmvCameraUpZ.Location = new System.Drawing.Point(509, 50);
            this.lbLmvCameraUpZ.Name = "lbLmvCameraUpZ";
            this.lbLmvCameraUpZ.Size = new System.Drawing.Size(14, 25);
            this.lbLmvCameraUpZ.TabIndex = 20;
            this.lbLmvCameraUpZ.Text = "z";
            this.lbLmvCameraUpZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLmvCameraUpY
            // 
            this.tbLmvCameraUpY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLmvCameraUpY.Location = new System.Drawing.Point(316, 53);
            this.tbLmvCameraUpY.Name = "tbLmvCameraUpY";
            this.tbLmvCameraUpY.Size = new System.Drawing.Size(187, 22);
            this.tbLmvCameraUpY.TabIndex = 19;
            this.tbLmvCameraUpY.Text = "0.0";
            // 
            // lbLmvCameraUpY
            // 
            this.lbLmvCameraUpY.AutoSize = true;
            this.lbLmvCameraUpY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLmvCameraUpY.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbLmvCameraUpY.Location = new System.Drawing.Point(296, 50);
            this.lbLmvCameraUpY.Name = "lbLmvCameraUpY";
            this.lbLmvCameraUpY.Size = new System.Drawing.Size(14, 25);
            this.lbLmvCameraUpY.TabIndex = 18;
            this.lbLmvCameraUpY.Text = "y";
            this.lbLmvCameraUpY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLmvCameraUpX
            // 
            this.tbLmvCameraUpX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLmvCameraUpX.Location = new System.Drawing.Point(103, 53);
            this.tbLmvCameraUpX.Name = "tbLmvCameraUpX";
            this.tbLmvCameraUpX.Size = new System.Drawing.Size(187, 22);
            this.tbLmvCameraUpX.TabIndex = 17;
            this.tbLmvCameraUpX.Text = "0.0";
            // 
            // lbLmvCameraUpX
            // 
            this.lbLmvCameraUpX.AutoSize = true;
            this.lbLmvCameraUpX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLmvCameraUpX.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbLmvCameraUpX.Location = new System.Drawing.Point(83, 50);
            this.lbLmvCameraUpX.Name = "lbLmvCameraUpX";
            this.lbLmvCameraUpX.Size = new System.Drawing.Size(14, 25);
            this.lbLmvCameraUpX.TabIndex = 16;
            this.lbLmvCameraUpX.Text = "x";
            this.lbLmvCameraUpX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbLmvCameraUpTitle
            // 
            this.lbLmvCameraUpTitle.AutoSize = true;
            this.lbLmvCameraUpTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLmvCameraUpTitle.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbLmvCameraUpTitle.Location = new System.Drawing.Point(3, 50);
            this.lbLmvCameraUpTitle.Name = "lbLmvCameraUpTitle";
            this.lbLmvCameraUpTitle.Size = new System.Drawing.Size(74, 25);
            this.lbLmvCameraUpTitle.TabIndex = 15;
            this.lbLmvCameraUpTitle.Text = "Up:";
            this.lbLmvCameraUpTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnVpSetter
            // 
            this.btnVpSetter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVpSetter.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVpSetter.Location = new System.Drawing.Point(3, 163);
            this.btnVpSetter.Name = "btnVpSetter";
            this.btnVpSetter.Size = new System.Drawing.Size(719, 52);
            this.btnVpSetter.TabIndex = 22;
            this.btnVpSetter.Text = "Set";
            this.btnVpSetter.UseVisualStyleBackColor = true;
            this.btnVpSetter.Click += new System.EventHandler(this.btnVpSetter_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnVpSetter, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbMainTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(725, 218);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.lbLmvModelOffsetsX, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbLmvModelOffsetsTitle, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbLmvCameraPosTitle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbLmvCameraUpZ, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbLmvCameraUpZ, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbLmvCameraTargetZ, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbLmvCameraTargetTitle, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbLmvCameraUpTitle, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbLmvCameraTargetZ, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbLmvCameraUpY, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbLmvCameraPosX, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbLmvCameraPosZ, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbLmvCameraUpY, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbLmvCameraPosZ, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbLmvCameraTargetX, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbLmvCameraTargetY, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbLmvCameraUpX, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbLmvCameraUpX, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbLmvCameraPosX, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbLmvCameraPosY, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbLmvCameraTargetY, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbLmvCameraTargetX, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbLmvCameraPosY, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbLmvModelOffsetsX, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbLmvModelOffsetsY, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbLmvModelOffsetsZ, 6, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbLmvModelOffsetsY, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbLmvModelOffsetsZ, 5, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(719, 104);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // lbLmvModelOffsetsX
            // 
            this.lbLmvModelOffsetsX.AutoSize = true;
            this.lbLmvModelOffsetsX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLmvModelOffsetsX.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbLmvModelOffsetsX.Location = new System.Drawing.Point(83, 75);
            this.lbLmvModelOffsetsX.Name = "lbLmvModelOffsetsX";
            this.lbLmvModelOffsetsX.Size = new System.Drawing.Size(14, 29);
            this.lbLmvModelOffsetsX.TabIndex = 24;
            this.lbLmvModelOffsetsX.Text = "x";
            this.lbLmvModelOffsetsX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbLmvModelOffsetsTitle
            // 
            this.lbLmvModelOffsetsTitle.AutoSize = true;
            this.lbLmvModelOffsetsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLmvModelOffsetsTitle.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbLmvModelOffsetsTitle.Location = new System.Drawing.Point(3, 75);
            this.lbLmvModelOffsetsTitle.Name = "lbLmvModelOffsetsTitle";
            this.lbLmvModelOffsetsTitle.Size = new System.Drawing.Size(74, 29);
            this.lbLmvModelOffsetsTitle.TabIndex = 22;
            this.lbLmvModelOffsetsTitle.Text = "Offsets:";
            this.lbLmvModelOffsetsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLmvModelOffsetsX
            // 
            this.tbLmvModelOffsetsX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLmvModelOffsetsX.Location = new System.Drawing.Point(103, 78);
            this.tbLmvModelOffsetsX.Name = "tbLmvModelOffsetsX";
            this.tbLmvModelOffsetsX.Size = new System.Drawing.Size(187, 22);
            this.tbLmvModelOffsetsX.TabIndex = 26;
            this.tbLmvModelOffsetsX.Text = "0.0";
            // 
            // tbLmvModelOffsetsY
            // 
            this.tbLmvModelOffsetsY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLmvModelOffsetsY.Location = new System.Drawing.Point(316, 78);
            this.tbLmvModelOffsetsY.Name = "tbLmvModelOffsetsY";
            this.tbLmvModelOffsetsY.Size = new System.Drawing.Size(187, 22);
            this.tbLmvModelOffsetsY.TabIndex = 25;
            this.tbLmvModelOffsetsY.Text = "0.0";
            // 
            // tbLmvModelOffsetsZ
            // 
            this.tbLmvModelOffsetsZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLmvModelOffsetsZ.Location = new System.Drawing.Point(529, 78);
            this.tbLmvModelOffsetsZ.Name = "tbLmvModelOffsetsZ";
            this.tbLmvModelOffsetsZ.Size = new System.Drawing.Size(187, 22);
            this.tbLmvModelOffsetsZ.TabIndex = 27;
            this.tbLmvModelOffsetsZ.Text = "0.0";
            // 
            // lbLmvModelOffsetsY
            // 
            this.lbLmvModelOffsetsY.AutoSize = true;
            this.lbLmvModelOffsetsY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLmvModelOffsetsY.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbLmvModelOffsetsY.Location = new System.Drawing.Point(296, 75);
            this.lbLmvModelOffsetsY.Name = "lbLmvModelOffsetsY";
            this.lbLmvModelOffsetsY.Size = new System.Drawing.Size(14, 29);
            this.lbLmvModelOffsetsY.TabIndex = 28;
            this.lbLmvModelOffsetsY.Text = "y";
            this.lbLmvModelOffsetsY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbLmvModelOffsetsZ
            // 
            this.lbLmvModelOffsetsZ.AutoSize = true;
            this.lbLmvModelOffsetsZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLmvModelOffsetsZ.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbLmvModelOffsetsZ.Location = new System.Drawing.Point(509, 75);
            this.lbLmvModelOffsetsZ.Name = "lbLmvModelOffsetsZ";
            this.lbLmvModelOffsetsZ.Size = new System.Drawing.Size(14, 29);
            this.lbLmvModelOffsetsZ.TabIndex = 29;
            this.lbLmvModelOffsetsZ.Text = "z";
            this.lbLmvModelOffsetsZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VpSetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 218);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "VpSetterForm";
            this.Text = "Autodesk Forge Viewpoint Setter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private Label lbMainTitle;
        private Label lbLmvCameraPosTitle;
        private Label lbLmvCameraPosX;
        private TextBox tbLmvCameraPosX;
        private TextBox tbLmvCameraPosY;
        private Label lbLmvCameraPosY;
        private TextBox tbLmvCameraPosZ;
        private Label lbLmvCameraPosZ;
        private TextBox tbLmvCameraTargetZ;
        private Label lbLmvCameraTargetZ;
        private TextBox tbLmvCameraTargetY;
        private Label lbLmvCameraTargetY;
        private TextBox tbLmvCameraTargetX;
        private Label lbLmvCameraTargetX;
        private Label lbLmvCameraTargetTitle;
        private TextBox tbLmvCameraUpZ;
        private Label lbLmvCameraUpZ;
        private TextBox tbLmvCameraUpY;
        private Label lbLmvCameraUpY;
        private TextBox tbLmvCameraUpX;
        private Label lbLmvCameraUpX;
        private Label lbLmvCameraUpTitle;
        private Button btnVpSetter;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lbLmvModelOffsetsX;
        private Label lbLmvModelOffsetsTitle;
        private TextBox tbLmvModelOffsetsX;
        private TextBox tbLmvModelOffsetsY;
        private TextBox tbLmvModelOffsetsZ;
        private Label lbLmvModelOffsetsY;
        private Label lbLmvModelOffsetsZ;

        #endregion
    }
}