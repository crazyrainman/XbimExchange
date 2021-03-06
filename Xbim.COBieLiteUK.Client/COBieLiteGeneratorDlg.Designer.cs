﻿using Xbim.CobieLiteUk.FilterHelper;

namespace Xbim.CobieLiteUk.Client
{
    partial class COBieLiteGeneratorDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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
            this.groupBox1 = new global::System.Windows.Forms.GroupBox();
            this.txtPath = new global::System.Windows.Forms.TextBox();
            this.btnFederate = new global::System.Windows.Forms.Button();
            this.btnBrowseTemplate = new global::System.Windows.Forms.Button();
            this.txtTemplate = new global::System.Windows.Forms.ComboBox();
            this.label2 = new global::System.Windows.Forms.Label();
            this.btnBrowse = new global::System.Windows.Forms.Button();
            this.label1 = new global::System.Windows.Forms.Label();
            this.cmboxFiletype = new global::System.Windows.Forms.ComboBox();
            this.btnClear = new global::System.Windows.Forms.Button();
            this.btnGenerate = new global::System.Windows.Forms.Button();
            this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
            this.ProgressBar = new global::System.Windows.Forms.ToolStripProgressBar();
            this.StatusMsg = new global::System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
            this.txtOutput = new global::System.Windows.Forms.RichTextBox();
            this.btnClassFilter = new global::System.Windows.Forms.Button();
            this.chkBoxFlipFilter = new global::System.Windows.Forms.CheckBox();
            this.chkBoxOpenFile = new global::System.Windows.Forms.CheckBox();
            this.btnMergeFilter = new global::System.Windows.Forms.Button();
            this.chkBoxNoFilter = new global::System.Windows.Forms.CheckBox();
            this.groupBox2 = new global::System.Windows.Forms.GroupBox();
            this.btnPropMaps = new global::System.Windows.Forms.Button();
            this.chkBoxIds = new global::System.Windows.Forms.CheckBox();
            this.checkedListSys = new global::System.Windows.Forms.CheckedListBox();
            this.chkBoxLog = new global::System.Windows.Forms.CheckBox();
            this.rolesList = new Xbim.CobieLiteUk.Client.RolesList();
            this.groupBox3 = new global::System.Windows.Forms.GroupBox();
            this.grpIfcGenerationMaps = new global::System.Windows.Forms.GroupBox();
            this.groupBox4 = new global::System.Windows.Forms.GroupBox();
            this.cmBoxCOBieType = new global::System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpIfcGenerationMaps.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.btnFederate);
            this.groupBox1.Controls.Add(this.btnBrowseTemplate);
            this.groupBox1.Controls.Add(this.txtTemplate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new global::System.Drawing.Point(158, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new global::System.Drawing.Size(530, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Location";
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new global::System.Drawing.Point(74, 19);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new global::System.Drawing.Size(316, 20);
            this.txtPath.TabIndex = 6;
            // 
            // btnFederate
            // 
            this.btnFederate.Anchor = ((global::System.Windows.Forms.AnchorStyles)((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right)));
            this.btnFederate.Location = new global::System.Drawing.Point(456, 20);
            this.btnFederate.Name = "btnFederate";
            this.btnFederate.Size = new global::System.Drawing.Size(62, 23);
            this.btnFederate.TabIndex = 5;
            this.btnFederate.Text = "Federate";
            this.btnFederate.UseVisualStyleBackColor = true;
            this.btnFederate.Click += new global::System.EventHandler(this.btnFederate_Click);
            // 
            // btnBrowseTemplate
            // 
            this.btnBrowseTemplate.Anchor = ((global::System.Windows.Forms.AnchorStyles)((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseTemplate.Enabled = false;
            this.btnBrowseTemplate.Location = new global::System.Drawing.Point(394, 44);
            this.btnBrowseTemplate.Name = "btnBrowseTemplate";
            this.btnBrowseTemplate.Size = new global::System.Drawing.Size(124, 23);
            this.btnBrowseTemplate.TabIndex = 4;
            this.btnBrowseTemplate.Text = "&Browse...";
            this.btnBrowseTemplate.UseVisualStyleBackColor = true;
            this.btnBrowseTemplate.Click += new global::System.EventHandler(this.btnBrowseTemplate_Click);
            // 
            // txtTemplate
            // 
            this.txtTemplate.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.txtTemplate.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTemplate.FormattingEnabled = true;
            this.txtTemplate.Location = new global::System.Drawing.Point(74, 46);
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.Size = new global::System.Drawing.Size(314, 21);
            this.txtTemplate.TabIndex = 3;
            this.txtTemplate.SelectedIndexChanged += new global::System.EventHandler(this.txtTemplate_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new global::System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Template:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((global::System.Windows.Forms.AnchorStyles)((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new global::System.Drawing.Point(394, 20);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new global::System.Drawing.Size(63, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "&Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new global::System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new global::System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select file:";
            // 
            // cmboxFiletype
            // 
            this.cmboxFiletype.Anchor = ((global::System.Windows.Forms.AnchorStyles)((global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right)));
            this.cmboxFiletype.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxFiletype.FormattingEnabled = true;
            this.cmboxFiletype.Location = new global::System.Drawing.Point(514, 480);
            this.cmboxFiletype.Name = "cmboxFiletype";
            this.cmboxFiletype.Size = new global::System.Drawing.Size(174, 21);
            this.cmboxFiletype.TabIndex = 18;
            this.cmboxFiletype.SelectedIndexChanged += new global::System.EventHandler(this.cmboxFiletype_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((global::System.Windows.Forms.AnchorStyles)((global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new global::System.Drawing.Point(15, 507);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new global::System.Drawing.Size(112, 26);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new global::System.EventHandler(this.btnClear_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((global::System.Windows.Forms.AnchorStyles)((global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new global::System.Drawing.Point(514, 507);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new global::System.Drawing.Size(174, 26);
            this.btnGenerate.TabIndex = 16;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new global::System.EventHandler(this.btnGenerate_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new global::System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.StatusMsg,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new global::System.Drawing.Point(0, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new global::System.Drawing.Size(696, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgressBar
            // 
            this.ProgressBar.AutoSize = false;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new global::System.Drawing.Size(150, 16);
            this.ProgressBar.Visible = false;
            // 
            // StatusMsg
            // 
            this.StatusMsg.Name = "StatusMsg";
            this.StatusMsg.Size = new global::System.Drawing.Size(681, 17);
            this.StatusMsg.Spring = true;
            this.StatusMsg.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new global::System.Drawing.Size(0, 17);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((global::System.Windows.Forms.AnchorStyles)((((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom) 
            | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new global::System.Drawing.Point(15, 97);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new global::System.Drawing.Size(493, 404);
            this.txtOutput.TabIndex = 20;
            this.txtOutput.Text = "";
            // 
            // btnClassFilter
            // 
            this.btnClassFilter.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.btnClassFilter.Location = new global::System.Drawing.Point(7, 62);
            this.btnClassFilter.Name = "btnClassFilter";
            this.btnClassFilter.Size = new global::System.Drawing.Size(148, 26);
            this.btnClassFilter.TabIndex = 21;
            this.btnClassFilter.Text = "Set Filter Defaults";
            this.btnClassFilter.UseVisualStyleBackColor = true;
            this.btnClassFilter.Click += new global::System.EventHandler(this.btnClassFilter_Click);
            // 
            // chkBoxFlipFilter
            // 
            this.chkBoxFlipFilter.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.chkBoxFlipFilter.AutoSize = true;
            this.chkBoxFlipFilter.Location = new global::System.Drawing.Point(5, 39);
            this.chkBoxFlipFilter.Name = "chkBoxFlipFilter";
            this.chkBoxFlipFilter.Size = new global::System.Drawing.Size(67, 17);
            this.chkBoxFlipFilter.TabIndex = 22;
            this.chkBoxFlipFilter.Text = "Flip Filter";
            this.chkBoxFlipFilter.UseVisualStyleBackColor = true;
            this.chkBoxFlipFilter.CheckedChanged += new global::System.EventHandler(this.chkBoxFlipFilter_CheckedChanged);
            // 
            // chkBoxOpenFile
            // 
            this.chkBoxOpenFile.Anchor = ((global::System.Windows.Forms.AnchorStyles)((global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right)));
            this.chkBoxOpenFile.AutoSize = true;
            this.chkBoxOpenFile.Checked = true;
            this.chkBoxOpenFile.CheckState = global::System.Windows.Forms.CheckState.Checked;
            this.chkBoxOpenFile.Location = new global::System.Drawing.Point(427, 513);
            this.chkBoxOpenFile.Name = "chkBoxOpenFile";
            this.chkBoxOpenFile.Size = new global::System.Drawing.Size(81, 17);
            this.chkBoxOpenFile.TabIndex = 23;
            this.chkBoxOpenFile.Text = "Open Excel";
            this.chkBoxOpenFile.UseVisualStyleBackColor = true;
            // 
            // btnMergeFilter
            // 
            this.btnMergeFilter.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.btnMergeFilter.Location = new global::System.Drawing.Point(7, 92);
            this.btnMergeFilter.Name = "btnMergeFilter";
            this.btnMergeFilter.Size = new global::System.Drawing.Size(148, 26);
            this.btnMergeFilter.TabIndex = 24;
            this.btnMergeFilter.Text = "Applied Filter";
            this.btnMergeFilter.UseVisualStyleBackColor = true;
            this.btnMergeFilter.Click += new global::System.EventHandler(this.btnMergeFilter_Click);
            // 
            // chkBoxNoFilter
            // 
            this.chkBoxNoFilter.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.chkBoxNoFilter.AutoSize = true;
            this.chkBoxNoFilter.Location = new global::System.Drawing.Point(5, 18);
            this.chkBoxNoFilter.Name = "chkBoxNoFilter";
            this.chkBoxNoFilter.Size = new global::System.Drawing.Size(70, 17);
            this.chkBoxNoFilter.TabIndex = 25;
            this.chkBoxNoFilter.Text = "No Filters";
            this.chkBoxNoFilter.UseVisualStyleBackColor = true;
            this.chkBoxNoFilter.CheckedChanged += new global::System.EventHandler(this.chkBoxNoFilter_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkBoxNoFilter);
            this.groupBox2.Controls.Add(this.btnClassFilter);
            this.groupBox2.Controls.Add(this.btnMergeFilter);
            this.groupBox2.Controls.Add(this.chkBoxFlipFilter);
            this.groupBox2.Location = new global::System.Drawing.Point(6, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new global::System.Drawing.Size(162, 126);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // btnPropMaps
            // 
            this.btnPropMaps.Anchor = ((global::System.Windows.Forms.AnchorStyles)((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right)));
            this.btnPropMaps.Location = new global::System.Drawing.Point(7, 19);
            this.btnPropMaps.Name = "btnPropMaps";
            this.btnPropMaps.Size = new global::System.Drawing.Size(148, 26);
            this.btnPropMaps.TabIndex = 27;
            this.btnPropMaps.Text = "Edit";
            this.btnPropMaps.UseVisualStyleBackColor = true;
            this.btnPropMaps.Click += new global::System.EventHandler(this.btnPropMaps_Click);
            // 
            // chkBoxIds
            // 
            this.chkBoxIds.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.chkBoxIds.AutoSize = true;
            this.chkBoxIds.Location = new global::System.Drawing.Point(11, 299);
            this.chkBoxIds.Name = "chkBoxIds";
            this.chkBoxIds.Size = new global::System.Drawing.Size(121, 17);
            this.chkBoxIds.TabIndex = 28;
            this.chkBoxIds.Text = "Use ExId as EntityId";
            this.chkBoxIds.UseVisualStyleBackColor = true;
            // 
            // checkedListSys
            // 
            this.checkedListSys.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListSys.CheckOnClick = true;
            this.checkedListSys.FormattingEnabled = true;
            this.checkedListSys.Location = new global::System.Drawing.Point(7, 19);
            this.checkedListSys.Name = "checkedListSys";
            this.checkedListSys.Size = new global::System.Drawing.Size(148, 34);
            this.checkedListSys.TabIndex = 29;
            // 
            // chkBoxLog
            // 
            this.chkBoxLog.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.chkBoxLog.AutoSize = true;
            this.chkBoxLog.Location = new global::System.Drawing.Point(11, 278);
            this.chkBoxLog.Name = "chkBoxLog";
            this.chkBoxLog.Size = new global::System.Drawing.Size(126, 17);
            this.chkBoxLog.TabIndex = 32;
            this.chkBoxLog.Text = "Create validation Log";
            this.chkBoxLog.UseVisualStyleBackColor = true;
            // 
            // rolesList
            // 
            this.rolesList.Location = new global::System.Drawing.Point(15, 8);
            this.rolesList.Margin = new global::System.Windows.Forms.Padding(4);
            this.rolesList.Name = "rolesList";
            this.rolesList.Roles = Xbim.CobieLiteUk.FilterHelper.RoleFilter.Unknown;
            this.rolesList.Size = new global::System.Drawing.Size(137, 83);
            this.rolesList.TabIndex = 31;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((global::System.Windows.Forms.AnchorStyles)((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.grpIfcGenerationMaps);
            this.groupBox3.Controls.Add(this.chkBoxLog);
            this.groupBox3.Controls.Add(this.chkBoxIds);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new global::System.Drawing.Point(514, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new global::System.Drawing.Size(174, 322);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // grpIfcGenerationMaps
            // 
            this.grpIfcGenerationMaps.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.grpIfcGenerationMaps.Controls.Add(this.btnPropMaps);
            this.grpIfcGenerationMaps.Enabled = true;
            this.grpIfcGenerationMaps.Location = new global::System.Drawing.Point(6, 215);
            this.grpIfcGenerationMaps.Name = "grpIfcGenerationMaps";
            this.grpIfcGenerationMaps.Size = new global::System.Drawing.Size(162, 57);
            this.grpIfcGenerationMaps.TabIndex = 28;
            this.grpIfcGenerationMaps.TabStop = false;
            this.grpIfcGenerationMaps.Text = "Ifc Generation Maps";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.checkedListSys);
            this.groupBox4.Location = new global::System.Drawing.Point(6, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new global::System.Drawing.Size(162, 57);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "System modes";
            // 
            // cmBoxCOBieType
            // 
            this.cmBoxCOBieType.Anchor = ((global::System.Windows.Forms.AnchorStyles)((global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right)));
            this.cmBoxCOBieType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxCOBieType.FormattingEnabled = true;
            this.cmBoxCOBieType.Location = new global::System.Drawing.Point(514, 453);
            this.cmBoxCOBieType.Name = "cmBoxCOBieType";
            this.cmBoxCOBieType.Size = new global::System.Drawing.Size(174, 21);
            this.cmBoxCOBieType.TabIndex = 34;
            // 
            // global::global::System
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new global::System.Drawing.Size(696, 558);
            this.Controls.Add(this.cmBoxCOBieType);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.rolesList);
            this.Controls.Add(this.chkBoxOpenFile);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmboxFiletype);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new global::System.Drawing.Size(638, 545);
            this.Name = "global::global::System";
            this.Text = "XBim COBieLiteUK Test Harness";
            this.Load += new global::System.EventHandler(this.COBieLiteGenerator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpIfcGenerationMaps.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.GroupBox groupBox1;
        private global::System.Windows.Forms.Button btnBrowseTemplate;
        private global::System.Windows.Forms.ComboBox txtTemplate;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.Button btnBrowse;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.ComboBox cmboxFiletype;
        private global::System.Windows.Forms.Button btnClear;
        private global::System.Windows.Forms.Button btnGenerate;
        private global::System.Windows.Forms.StatusStrip statusStrip1;
        private global::System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private global::System.Windows.Forms.ToolStripStatusLabel StatusMsg;
        private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private global::System.Windows.Forms.RichTextBox txtOutput;
        private global::System.Windows.Forms.Button btnClassFilter;
        private global::System.Windows.Forms.CheckBox chkBoxFlipFilter;
        private global::System.Windows.Forms.CheckBox chkBoxOpenFile;
        private global::System.Windows.Forms.Button btnMergeFilter;
        private global::System.Windows.Forms.CheckBox chkBoxNoFilter;
        private global::System.Windows.Forms.GroupBox groupBox2;
        private global::System.Windows.Forms.Button btnPropMaps;
        private global::System.Windows.Forms.CheckBox chkBoxIds;
        private global::System.Windows.Forms.CheckedListBox checkedListSys;
        private RolesList rolesList;
        private global::System.Windows.Forms.Button btnFederate;
        private global::System.Windows.Forms.TextBox txtPath;
        private global::System.Windows.Forms.CheckBox chkBoxLog;
        private global::System.Windows.Forms.GroupBox groupBox3;
        private global::System.Windows.Forms.GroupBox grpIfcGenerationMaps;
        private global::System.Windows.Forms.GroupBox groupBox4;
        private global::System.Windows.Forms.ComboBox cmBoxCOBieType;
    }
}

