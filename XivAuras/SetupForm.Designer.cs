namespace XivAuras {
    partial class SetupForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Auras");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.newAuraButton = new System.Windows.Forms.Button();
            this.setupTreeView = new System.Windows.Forms.TreeView();
            this.auraTabs = new System.Windows.Forms.TabControl();
            this.displayTab = new System.Windows.Forms.TabPage();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.displayTextCheckBox = new System.Windows.Forms.CheckBox();
            this.displayTextFontButton = new System.Windows.Forms.Button();
            this.displayTextAlignment = new System.Windows.Forms.ComboBox();
            this.displayTextDescription = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.resetButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.displayTextFontDialog = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.displayTextFontColorButton = new System.Windows.Forms.Button();
            this.displayColorDialog = new System.Windows.Forms.ColorDialog();
            this.displayOpacitySpinner = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.aboutNameTextBox = new System.Windows.Forms.TextBox();
            this.aboutActiveAlwaysCheckbox = new System.Windows.Forms.CheckBox();
            this.displayAnchor = new System.Windows.Forms.ComboBox();
            this.displayScreenAnchor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.displayXOffsetSpinner = new System.Windows.Forms.NumericUpDown();
            this.displayYOffsetSpinner = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.auraTabs.SuspendLayout();
            this.displayTab.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayOpacitySpinner)).BeginInit();
            this.aboutTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayXOffsetSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayYOffsetSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(759, 516);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.auraTabs);
            this.splitContainer1.Size = new System.Drawing.Size(753, 460);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.setupTreeView);
            this.splitContainer2.Size = new System.Drawing.Size(250, 460);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.newAuraButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 25);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // newAuraButton
            // 
            this.newAuraButton.Location = new System.Drawing.Point(0, 0);
            this.newAuraButton.Margin = new System.Windows.Forms.Padding(0);
            this.newAuraButton.Name = "newAuraButton";
            this.newAuraButton.Size = new System.Drawing.Size(75, 23);
            this.newAuraButton.TabIndex = 0;
            this.newAuraButton.Text = "New";
            this.newAuraButton.Click += new System.EventHandler(this.newAuraButton_Click);
            // 
            // setupTreeView
            // 
            this.setupTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setupTreeView.FullRowSelect = true;
            this.setupTreeView.HideSelection = false;
            this.setupTreeView.Location = new System.Drawing.Point(0, 0);
            this.setupTreeView.Name = "setupTreeView";
            treeNode3.Name = "Auras";
            treeNode3.Tag = "auras-root";
            treeNode3.Text = "Auras";
            this.setupTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.setupTreeView.Size = new System.Drawing.Size(250, 431);
            this.setupTreeView.TabIndex = 0;
            this.setupTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.setupTreeView_AfterSelect);
            // 
            // auraTabs
            // 
            this.auraTabs.Controls.Add(this.aboutTab);
            this.auraTabs.Controls.Add(this.displayTab);
            this.auraTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auraTabs.Location = new System.Drawing.Point(0, 0);
            this.auraTabs.Name = "auraTabs";
            this.auraTabs.SelectedIndex = 0;
            this.auraTabs.Size = new System.Drawing.Size(499, 460);
            this.auraTabs.TabIndex = 0;
            this.auraTabs.Visible = false;
            // 
            // displayTab
            // 
            this.displayTab.AutoScroll = true;
            this.displayTab.Controls.Add(this.displayYOffsetSpinner);
            this.displayTab.Controls.Add(this.label7);
            this.displayTab.Controls.Add(this.displayXOffsetSpinner);
            this.displayTab.Controls.Add(this.label6);
            this.displayTab.Controls.Add(this.label5);
            this.displayTab.Controls.Add(this.label4);
            this.displayTab.Controls.Add(this.displayScreenAnchor);
            this.displayTab.Controls.Add(this.displayAnchor);
            this.displayTab.Controls.Add(this.label2);
            this.displayTab.Controls.Add(this.displayOpacitySpinner);
            this.displayTab.Controls.Add(this.displayTextFontColorButton);
            this.displayTab.Controls.Add(this.label1);
            this.displayTab.Controls.Add(this.displayTextBox);
            this.displayTab.Controls.Add(this.displayTextCheckBox);
            this.displayTab.Controls.Add(this.displayTextFontButton);
            this.displayTab.Controls.Add(this.displayTextAlignment);
            this.displayTab.Controls.Add(this.displayTextDescription);
            this.displayTab.Location = new System.Drawing.Point(4, 22);
            this.displayTab.Name = "displayTab";
            this.displayTab.Padding = new System.Windows.Forms.Padding(3);
            this.displayTab.Size = new System.Drawing.Size(491, 434);
            this.displayTab.TabIndex = 0;
            this.displayTab.Text = "Display";
            this.displayTab.UseVisualStyleBackColor = true;
            // 
            // displayTextBox
            // 
            this.displayTextBox.AcceptsReturn = true;
            this.displayTextBox.Location = new System.Drawing.Point(6, 258);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayTextBox.Size = new System.Drawing.Size(479, 50);
            this.displayTextBox.TabIndex = 7;
            this.displayTextBox.TextChanged += new System.EventHandler(this.displayTextBox_TextChanged);
            // 
            // displayTextCheckBox
            // 
            this.displayTextCheckBox.AutoSize = true;
            this.displayTextCheckBox.Location = new System.Drawing.Point(6, 6);
            this.displayTextCheckBox.Name = "displayTextCheckBox";
            this.displayTextCheckBox.Size = new System.Drawing.Size(47, 17);
            this.displayTextCheckBox.TabIndex = 5;
            this.displayTextCheckBox.Text = "Text";
            this.displayTextCheckBox.UseVisualStyleBackColor = true;
            this.displayTextCheckBox.CheckedChanged += new System.EventHandler(this.displayTextCheckBox_CheckedChanged);
            // 
            // displayTextFontButton
            // 
            this.displayTextFontButton.Location = new System.Drawing.Point(6, 56);
            this.displayTextFontButton.Name = "displayTextFontButton";
            this.displayTextFontButton.Size = new System.Drawing.Size(479, 38);
            this.displayTextFontButton.TabIndex = 9;
            this.displayTextFontButton.Text = "Font...";
            this.displayTextFontButton.UseVisualStyleBackColor = true;
            this.displayTextFontButton.Click += new System.EventHandler(this.displayTextFontButton_Click);
            // 
            // displayTextAlignment
            // 
            this.displayTextAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displayTextAlignment.Enabled = false;
            this.displayTextAlignment.FormattingEnabled = true;
            this.displayTextAlignment.Items.AddRange(new object[] {
            "Left",
            "Center",
            "Right"});
            this.displayTextAlignment.Location = new System.Drawing.Point(6, 29);
            this.displayTextAlignment.Name = "displayTextAlignment";
            this.displayTextAlignment.Size = new System.Drawing.Size(479, 21);
            this.displayTextAlignment.TabIndex = 6;
            this.displayTextAlignment.SelectedIndexChanged += new System.EventHandler(this.displayTextAlignment_SelectedIndexChanged);
            // 
            // displayTextDescription
            // 
            this.displayTextDescription.BackColor = System.Drawing.SystemColors.Window;
            this.displayTextDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayTextDescription.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTextDescription.Location = new System.Drawing.Point(6, 132);
            this.displayTextDescription.Name = "displayTextDescription";
            this.displayTextDescription.ReadOnly = true;
            this.displayTextDescription.Size = new System.Drawing.Size(479, 120);
            this.displayTextDescription.TabIndex = 8;
            this.displayTextDescription.Text = resources.GetString("displayTextDescription.Text");
            this.displayTextDescription.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.displayTextDescription_LinkClicked);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.resetButton);
            this.flowLayoutPanel2.Controls.Add(this.applyButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 466);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(759, 50);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // resetButton
            // 
            this.resetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetButton.Location = new System.Drawing.Point(681, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(600, 3);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 0;
            this.applyButton.Text = "Apply";
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Color:";
            // 
            // displayTextFontColorButton
            // 
            this.displayTextFontColorButton.Location = new System.Drawing.Point(46, 100);
            this.displayTextFontColorButton.Name = "displayTextFontColorButton";
            this.displayTextFontColorButton.Size = new System.Drawing.Size(42, 26);
            this.displayTextFontColorButton.TabIndex = 11;
            this.displayTextFontColorButton.UseVisualStyleBackColor = true;
            this.displayTextFontColorButton.Click += new System.EventHandler(this.displayTextFontColorButton_Click);
            // 
            // displayOpacitySpinner
            // 
            this.displayOpacitySpinner.DecimalPlaces = 2;
            this.displayOpacitySpinner.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.displayOpacitySpinner.Location = new System.Drawing.Point(160, 105);
            this.displayOpacitySpinner.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.displayOpacitySpinner.Name = "displayOpacitySpinner";
            this.displayOpacitySpinner.Size = new System.Drawing.Size(62, 20);
            this.displayOpacitySpinner.TabIndex = 12;
            this.displayOpacitySpinner.ValueChanged += new System.EventHandler(this.displayOpacitySpinner_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Opacity:";
            // 
            // aboutTab
            // 
            this.aboutTab.AutoScroll = true;
            this.aboutTab.Controls.Add(this.aboutActiveAlwaysCheckbox);
            this.aboutTab.Controls.Add(this.aboutNameTextBox);
            this.aboutTab.Controls.Add(this.label3);
            this.aboutTab.Location = new System.Drawing.Point(4, 22);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.aboutTab.Size = new System.Drawing.Size(491, 359);
            this.aboutTab.TabIndex = 1;
            this.aboutTab.Text = "About";
            this.aboutTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // aboutNameTextBox
            // 
            this.aboutNameTextBox.Location = new System.Drawing.Point(50, 6);
            this.aboutNameTextBox.Name = "aboutNameTextBox";
            this.aboutNameTextBox.Size = new System.Drawing.Size(265, 20);
            this.aboutNameTextBox.TabIndex = 1;
            this.aboutNameTextBox.TextChanged += new System.EventHandler(this.aboutNameTextBox_TextChanged);
            // 
            // aboutActiveAlwaysCheckbox
            // 
            this.aboutActiveAlwaysCheckbox.AutoSize = true;
            this.aboutActiveAlwaysCheckbox.Location = new System.Drawing.Point(9, 52);
            this.aboutActiveAlwaysCheckbox.Name = "aboutActiveAlwaysCheckbox";
            this.aboutActiveAlwaysCheckbox.Size = new System.Drawing.Size(56, 17);
            this.aboutActiveAlwaysCheckbox.TabIndex = 2;
            this.aboutActiveAlwaysCheckbox.Text = "Active";
            this.aboutActiveAlwaysCheckbox.UseVisualStyleBackColor = true;
            this.aboutActiveAlwaysCheckbox.CheckedChanged += new System.EventHandler(this.aboutActiveAlwaysCheckbox_CheckedChanged);
            // 
            // displayAnchor
            // 
            this.displayAnchor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displayAnchor.FormattingEnabled = true;
            this.displayAnchor.Items.AddRange(new object[] {
            "Top Left",
            "Top Middle",
            "Top Right",
            "Left Middle",
            "Center",
            "Right Middle",
            "Bottom Left",
            "Bottom Middle",
            "Bottom Right"});
            this.displayAnchor.Location = new System.Drawing.Point(46, 322);
            this.displayAnchor.Name = "displayAnchor";
            this.displayAnchor.Size = new System.Drawing.Size(121, 21);
            this.displayAnchor.TabIndex = 14;
            this.displayAnchor.SelectedIndexChanged += new System.EventHandler(this.displayAnchor_SelectedIndexChanged);
            // 
            // displayScreenAnchor
            // 
            this.displayScreenAnchor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displayScreenAnchor.FormattingEnabled = true;
            this.displayScreenAnchor.Items.AddRange(new object[] {
            "Top Left",
            "Top Middle",
            "Top Right",
            "Left Middle",
            "Center",
            "Right Middle",
            "Bottom Left",
            "Bottom Middle",
            "Bottom Right"});
            this.displayScreenAnchor.Location = new System.Drawing.Point(237, 322);
            this.displayScreenAnchor.Name = "displayScreenAnchor";
            this.displayScreenAnchor.Size = new System.Drawing.Size(121, 21);
            this.displayScreenAnchor.TabIndex = 15;
            this.displayScreenAnchor.SelectedIndexChanged += new System.EventHandler(this.displayScreenAnchor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Anchor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "to screen\'s";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "X Offset:";
            // 
            // displayXOffsetSpinner
            // 
            this.displayXOffsetSpinner.Location = new System.Drawing.Point(60, 356);
            this.displayXOffsetSpinner.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.displayXOffsetSpinner.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.displayXOffsetSpinner.Name = "displayXOffsetSpinner";
            this.displayXOffsetSpinner.Size = new System.Drawing.Size(73, 20);
            this.displayXOffsetSpinner.TabIndex = 19;
            this.displayXOffsetSpinner.ValueChanged += new System.EventHandler(this.displayXOffsetSpinner_ValueChanged);
            // 
            // displayYOffsetSpinner
            // 
            this.displayYOffsetSpinner.Location = new System.Drawing.Point(193, 356);
            this.displayYOffsetSpinner.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.displayYOffsetSpinner.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.displayYOffsetSpinner.Name = "displayYOffsetSpinner";
            this.displayYOffsetSpinner.Size = new System.Drawing.Size(73, 20);
            this.displayYOffsetSpinner.TabIndex = 21;
            this.displayYOffsetSpinner.ValueChanged += new System.EventHandler(this.displayYOffsetSpinner_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Y Offset:";
            // 
            // SetupForm
            // 
            this.AcceptButton = this.applyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 524);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SetupForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "XivAuras";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.auraTabs.ResumeLayout(false);
            this.displayTab.ResumeLayout(false);
            this.displayTab.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayOpacitySpinner)).EndInit();
            this.aboutTab.ResumeLayout(false);
            this.aboutTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayXOffsetSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayYOffsetSpinner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button newAuraButton;
        private System.Windows.Forms.TreeView setupTreeView;
        private System.Windows.Forms.TabControl auraTabs;
        private System.Windows.Forms.TabPage displayTab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.FontDialog displayTextFontDialog;
        private System.Windows.Forms.Button displayTextFontButton;
        private System.Windows.Forms.ComboBox displayTextAlignment;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.RichTextBox displayTextDescription;
        private System.Windows.Forms.CheckBox displayTextCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button displayTextFontColorButton;
        private System.Windows.Forms.ColorDialog displayColorDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown displayOpacitySpinner;
        private System.Windows.Forms.TabPage aboutTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aboutNameTextBox;
        private System.Windows.Forms.CheckBox aboutActiveAlwaysCheckbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox displayScreenAnchor;
        private System.Windows.Forms.ComboBox displayAnchor;
        private System.Windows.Forms.NumericUpDown displayYOffsetSpinner;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown displayXOffsetSpinner;
        private System.Windows.Forms.Label label6;

    }
}