namespace PS4Macro.Forms
{
    partial class RemapperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemapperForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.macrosGroupBox = new System.Windows.Forms.GroupBox();
            this.macrosDataGridView = new System.Windows.Forms.DataGridView();
            this.Browse = new System.Windows.Forms.DataGridViewButtonColumn();
            this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mappingsGroupBox = new System.Windows.Forms.GroupBox();
            this.mappingsDataGridView = new System.Windows.Forms.DataGridView();
            this.Button = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mouseInputGroupBox = new System.Windows.Forms.GroupBox();
            this.middleMouseComboBox = new System.Windows.Forms.ComboBox();
            this.middleMouseLabel = new System.Windows.Forms.Label();
            this.invertMouseYCheckBox = new System.Windows.Forms.CheckBox();
            this.invertMouseXCheckBox = new System.Windows.Forms.CheckBox();
            this.movementJoystickLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rightStickRadioButton = new System.Windows.Forms.RadioButton();
            this.leftStickRadioButton = new System.Windows.Forms.RadioButton();
            this.rightMouseComboBox = new System.Windows.Forms.ComboBox();
            this.rightMouseLabel = new System.Windows.Forms.Label();
            this.leftMouseComboBox = new System.Windows.Forms.ComboBox();
            this.leftMouseLabel = new System.Windows.Forms.Label();
            this.enableMouseCheckBox = new System.Windows.Forms.CheckBox();
            this.bordersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.frameRefreshNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sensitivityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bordersLabel = new System.Windows.Forms.Label();
            this.decayThresholdLabel = new System.Windows.Forms.Label();
            this.frameRefreshLabel = new System.Windows.Forms.Label();
            this.sensitivityLabel = new System.Windows.Forms.Label();
            this.axisDisplay = new PS4Macro.Controls.AxisDisplay();
            this.macrosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.macrosDataGridView)).BeginInit();
            this.mappingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mappingsDataGridView)).BeginInit();
            this.mouseInputGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bordersNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameRefreshNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(456, 10);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save Bindings";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // macrosGroupBox
            // 
            this.macrosGroupBox.Controls.Add(this.macrosDataGridView);
            this.macrosGroupBox.Location = new System.Drawing.Point(13, 273);
            this.macrosGroupBox.Name = "macrosGroupBox";
            this.macrosGroupBox.Size = new System.Drawing.Size(339, 168);
            this.macrosGroupBox.TabIndex = 4;
            this.macrosGroupBox.TabStop = false;
            this.macrosGroupBox.Text = "Macros";
            // 
            // macrosDataGridView
            // 
            this.macrosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.macrosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Browse,
            this._Name,
            this.dataGridViewTextBoxColumn1,
            this.Path});
            this.macrosDataGridView.Location = new System.Drawing.Point(6, 19);
            this.macrosDataGridView.Name = "macrosDataGridView";
            this.macrosDataGridView.Size = new System.Drawing.Size(327, 143);
            this.macrosDataGridView.TabIndex = 0;
            this.macrosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.macrosDataGridView_CellContentClick);
            this.macrosDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.macrosDataGridView_CellValidating);
            this.macrosDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.macrosDataGridView_CellValueChanged);
            this.macrosDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.macrosDataGridView_DataError);
            // 
            // Browse
            // 
            this.Browse.FillWeight = 40F;
            this.Browse.HeaderText = "...";
            this.Browse.Name = "Browse";
            this.Browse.Text = "...";
            this.Browse.UseColumnTextForButtonValue = true;
            this.Browse.Width = 40;
            // 
            // _Name
            // 
            this._Name.DataPropertyName = "Name";
            this._Name.HeaderText = "Name";
            this._Name.Name = "_Name";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Key";
            this.dataGridViewTextBoxColumn1.HeaderText = "Key";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            // 
            // mappingsGroupBox
            // 
            this.mappingsGroupBox.Controls.Add(this.mappingsDataGridView);
            this.mappingsGroupBox.Location = new System.Drawing.Point(13, 34);
            this.mappingsGroupBox.Name = "mappingsGroupBox";
            this.mappingsGroupBox.Size = new System.Drawing.Size(339, 233);
            this.mappingsGroupBox.TabIndex = 3;
            this.mappingsGroupBox.TabStop = false;
            this.mappingsGroupBox.Text = "Mappings";
            // 
            // mappingsDataGridView
            // 
            this.mappingsDataGridView.AllowUserToAddRows = false;
            this.mappingsDataGridView.AllowUserToDeleteRows = false;
            this.mappingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mappingsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Button,
            this.Key});
            this.mappingsDataGridView.Location = new System.Drawing.Point(6, 19);
            this.mappingsDataGridView.Name = "mappingsDataGridView";
            this.mappingsDataGridView.Size = new System.Drawing.Size(327, 208);
            this.mappingsDataGridView.TabIndex = 0;
            this.mappingsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mappingsDataGridView_CellContentClick);
            this.mappingsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.mappingsDataGridView_CellValidating);
            this.mappingsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.mappingsDataGridView_CellValueChanged);
            this.mappingsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.mappingsDataGridView_DataError);
            // 
            // Button
            // 
            this.Button.DataPropertyName = "Name";
            this.Button.HeaderText = "Button";
            this.Button.Name = "Button";
            this.Button.ReadOnly = true;
            // 
            // Key
            // 
            this.Key.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Key.DataPropertyName = "Key";
            this.Key.HeaderText = "Key";
            this.Key.Name = "Key";
            // 
            // mouseInputGroupBox
            // 
            this.mouseInputGroupBox.Controls.Add(this.middleMouseComboBox);
            this.mouseInputGroupBox.Controls.Add(this.middleMouseLabel);
            this.mouseInputGroupBox.Controls.Add(this.invertMouseYCheckBox);
            this.mouseInputGroupBox.Controls.Add(this.invertMouseXCheckBox);
            this.mouseInputGroupBox.Controls.Add(this.axisDisplay);
            this.mouseInputGroupBox.Controls.Add(this.movementJoystickLabel);
            this.mouseInputGroupBox.Controls.Add(this.panel1);
            this.mouseInputGroupBox.Controls.Add(this.rightMouseComboBox);
            this.mouseInputGroupBox.Controls.Add(this.rightMouseLabel);
            this.mouseInputGroupBox.Controls.Add(this.leftMouseComboBox);
            this.mouseInputGroupBox.Controls.Add(this.leftMouseLabel);
            this.mouseInputGroupBox.Controls.Add(this.enableMouseCheckBox);
            this.mouseInputGroupBox.Controls.Add(this.bordersNumericUpDown);
            this.mouseInputGroupBox.Controls.Add(this.frameRefreshNumericUpDown);
            this.mouseInputGroupBox.Controls.Add(this.sensitivityNumericUpDown);
            this.mouseInputGroupBox.Controls.Add(this.bordersLabel);
            this.mouseInputGroupBox.Controls.Add(this.decayThresholdLabel);
            this.mouseInputGroupBox.Controls.Add(this.frameRefreshLabel);
            this.mouseInputGroupBox.Controls.Add(this.sensitivityLabel);
            this.mouseInputGroupBox.Location = new System.Drawing.Point(358, 34);
            this.mouseInputGroupBox.Name = "mouseInputGroupBox";
            this.mouseInputGroupBox.Size = new System.Drawing.Size(194, 407);
            this.mouseInputGroupBox.TabIndex = 7;
            this.mouseInputGroupBox.TabStop = false;
            this.mouseInputGroupBox.Text = "Mouse Input";
            // 
            // middleMouseComboBox
            // 
            this.middleMouseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.middleMouseComboBox.FormattingEnabled = true;
            this.middleMouseComboBox.Location = new System.Drawing.Point(81, 375);
            this.middleMouseComboBox.Name = "middleMouseComboBox";
            this.middleMouseComboBox.Size = new System.Drawing.Size(104, 21);
            this.middleMouseComboBox.TabIndex = 21;
            this.middleMouseComboBox.SelectedIndexChanged += new System.EventHandler(this.middleMouseComboBox_SelectedIndexChanged);
            // 
            // middleMouseLabel
            // 
            this.middleMouseLabel.AutoSize = true;
            this.middleMouseLabel.Location = new System.Drawing.Point(9, 379);
            this.middleMouseLabel.Name = "middleMouseLabel";
            this.middleMouseLabel.Size = new System.Drawing.Size(64, 13);
            this.middleMouseLabel.TabIndex = 20;
            this.middleMouseLabel.Text = "Middle Click";
            // 
            // invertMouseYCheckBox
            // 
            this.invertMouseYCheckBox.AutoSize = true;
            this.invertMouseYCheckBox.Location = new System.Drawing.Point(100, 279);
            this.invertMouseYCheckBox.Name = "invertMouseYCheckBox";
            this.invertMouseYCheckBox.Size = new System.Drawing.Size(85, 17);
            this.invertMouseYCheckBox.TabIndex = 19;
            this.invertMouseYCheckBox.Text = "Invert Y-Axis";
            this.invertMouseYCheckBox.UseVisualStyleBackColor = true;
            this.invertMouseYCheckBox.CheckedChanged += new System.EventHandler(this.invertMouseYCheckBox_CheckedChanged);
            // 
            // invertMouseXCheckBox
            // 
            this.invertMouseXCheckBox.AutoSize = true;
            this.invertMouseXCheckBox.Location = new System.Drawing.Point(100, 256);
            this.invertMouseXCheckBox.Name = "invertMouseXCheckBox";
            this.invertMouseXCheckBox.Size = new System.Drawing.Size(85, 17);
            this.invertMouseXCheckBox.TabIndex = 18;
            this.invertMouseXCheckBox.Text = "Invert X-Axis";
            this.invertMouseXCheckBox.UseVisualStyleBackColor = true;
            this.invertMouseXCheckBox.CheckedChanged += new System.EventHandler(this.invertMouseXCheckBox_CheckedChanged);
            // 
            // movementJoystickLabel
            // 
            this.movementJoystickLabel.AutoSize = true;
            this.movementJoystickLabel.Location = new System.Drawing.Point(9, 199);
            this.movementJoystickLabel.Name = "movementJoystickLabel";
            this.movementJoystickLabel.Size = new System.Drawing.Size(98, 13);
            this.movementJoystickLabel.TabIndex = 9;
            this.movementJoystickLabel.Text = "Movement Joystick";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rightStickRadioButton);
            this.panel1.Controls.Add(this.leftStickRadioButton);
            this.panel1.Location = new System.Drawing.Point(9, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 24);
            this.panel1.TabIndex = 10;
            // 
            // rightStickRadioButton
            // 
            this.rightStickRadioButton.AutoSize = true;
            this.rightStickRadioButton.Checked = true;
            this.rightStickRadioButton.Location = new System.Drawing.Point(99, 3);
            this.rightStickRadioButton.Name = "rightStickRadioButton";
            this.rightStickRadioButton.Size = new System.Drawing.Size(77, 17);
            this.rightStickRadioButton.TabIndex = 1;
            this.rightStickRadioButton.TabStop = true;
            this.rightStickRadioButton.Text = "Right Stick";
            this.rightStickRadioButton.UseVisualStyleBackColor = true;
            this.rightStickRadioButton.CheckedChanged += new System.EventHandler(this.rightStickRadioButton_CheckedChanged);
            // 
            // leftStickRadioButton
            // 
            this.leftStickRadioButton.AutoSize = true;
            this.leftStickRadioButton.Location = new System.Drawing.Point(3, 3);
            this.leftStickRadioButton.Name = "leftStickRadioButton";
            this.leftStickRadioButton.Size = new System.Drawing.Size(70, 17);
            this.leftStickRadioButton.TabIndex = 0;
            this.leftStickRadioButton.Text = "Left Stick";
            this.leftStickRadioButton.UseVisualStyleBackColor = true;
            this.leftStickRadioButton.CheckedChanged += new System.EventHandler(this.leftStickRadioButton_CheckedChanged);
            // 
            // rightMouseComboBox
            // 
            this.rightMouseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rightMouseComboBox.FormattingEnabled = true;
            this.rightMouseComboBox.Location = new System.Drawing.Point(81, 349);
            this.rightMouseComboBox.Name = "rightMouseComboBox";
            this.rightMouseComboBox.Size = new System.Drawing.Size(104, 21);
            this.rightMouseComboBox.TabIndex = 14;
            this.rightMouseComboBox.SelectedIndexChanged += new System.EventHandler(this.rightMouseComboBox_SelectedIndexChanged);
            // 
            // rightMouseLabel
            // 
            this.rightMouseLabel.AutoSize = true;
            this.rightMouseLabel.Location = new System.Drawing.Point(9, 353);
            this.rightMouseLabel.Name = "rightMouseLabel";
            this.rightMouseLabel.Size = new System.Drawing.Size(58, 13);
            this.rightMouseLabel.TabIndex = 13;
            this.rightMouseLabel.Text = "Right Click";
            // 
            // leftMouseComboBox
            // 
            this.leftMouseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leftMouseComboBox.FormattingEnabled = true;
            this.leftMouseComboBox.Location = new System.Drawing.Point(81, 323);
            this.leftMouseComboBox.Name = "leftMouseComboBox";
            this.leftMouseComboBox.Size = new System.Drawing.Size(104, 21);
            this.leftMouseComboBox.TabIndex = 12;
            this.leftMouseComboBox.SelectedIndexChanged += new System.EventHandler(this.leftMouseComboBox_SelectedIndexChanged);
            // 
            // leftMouseLabel
            // 
            this.leftMouseLabel.AutoSize = true;
            this.leftMouseLabel.Location = new System.Drawing.Point(9, 327);
            this.leftMouseLabel.Name = "leftMouseLabel";
            this.leftMouseLabel.Size = new System.Drawing.Size(51, 13);
            this.leftMouseLabel.TabIndex = 11;
            this.leftMouseLabel.Text = "Left Click";
            // 
            // enableMouseCheckBox
            // 
            this.enableMouseCheckBox.AutoSize = true;
            this.enableMouseCheckBox.Location = new System.Drawing.Point(12, 27);
            this.enableMouseCheckBox.Name = "enableMouseCheckBox";
            this.enableMouseCheckBox.Size = new System.Drawing.Size(94, 17);
            this.enableMouseCheckBox.TabIndex = 0;
            this.enableMouseCheckBox.Text = "Enable Mouse";
            this.enableMouseCheckBox.UseVisualStyleBackColor = true;
            this.enableMouseCheckBox.CheckedChanged += new System.EventHandler(this.enableMouseCheckBox_CheckedChanged);
            // 
            // bordersNumericUpDown
            // 
            this.bordersNumericUpDown.Location = new System.Drawing.Point(132, 136);
            this.bordersNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bordersNumericUpDown.Name = "bordersNumericUpDown";
            this.bordersNumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.bordersNumericUpDown.TabIndex = 8;
            this.bordersNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.bordersNumericUpDown.ValueChanged += new System.EventHandler(this.bordersNumericUpDown_ValueChanged);
            // 
            // frameRefreshNumericUpDown
            // 
            this.frameRefreshNumericUpDown.Location = new System.Drawing.Point(132, 105);
            this.frameRefreshNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.frameRefreshNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frameRefreshNumericUpDown.Name = "frameRefreshNumericUpDown";
            this.frameRefreshNumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.frameRefreshNumericUpDown.TabIndex = 4;
            this.frameRefreshNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.frameRefreshNumericUpDown.ValueChanged += new System.EventHandler(this.frameRefreshNumericUpDown_ValueChanged);
            // 
            // sensitivityNumericUpDown
            // 
            this.sensitivityNumericUpDown.DecimalPlaces = 2;
            this.sensitivityNumericUpDown.Location = new System.Drawing.Point(132, 74);
            this.sensitivityNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sensitivityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.sensitivityNumericUpDown.Name = "sensitivityNumericUpDown";
            this.sensitivityNumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.sensitivityNumericUpDown.TabIndex = 2;
            this.sensitivityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sensitivityNumericUpDown.ValueChanged += new System.EventHandler(this.sensitivityNumericUpDown_ValueChanged);
            // 
            // bordersLabel
            // 
            this.bordersLabel.AutoSize = true;
            this.bordersLabel.Location = new System.Drawing.Point(9, 138);
            this.bordersLabel.Name = "bordersLabel";
            this.bordersLabel.Size = new System.Drawing.Size(78, 13);
            this.bordersLabel.TabIndex = 7;
            this.bordersLabel.Text = "Borders (pixels)";
            // 
            // decayThresholdLabel
            // 
            this.decayThresholdLabel.Location = new System.Drawing.Point(0, 0);
            this.decayThresholdLabel.Name = "decayThresholdLabel";
            this.decayThresholdLabel.Size = new System.Drawing.Size(100, 23);
            this.decayThresholdLabel.TabIndex = 22;
            // 
            // frameRefreshLabel
            // 
            this.frameRefreshLabel.AutoSize = true;
            this.frameRefreshLabel.Location = new System.Drawing.Point(9, 107);
            this.frameRefreshLabel.Name = "frameRefreshLabel";
            this.frameRefreshLabel.Size = new System.Drawing.Size(103, 13);
            this.frameRefreshLabel.TabIndex = 3;
            this.frameRefreshLabel.Text = "Mouse frame refresh";
            // 
            // sensitivityLabel
            // 
            this.sensitivityLabel.AutoSize = true;
            this.sensitivityLabel.Location = new System.Drawing.Point(9, 76);
            this.sensitivityLabel.Name = "sensitivityLabel";
            this.sensitivityLabel.Size = new System.Drawing.Size(54, 13);
            this.sensitivityLabel.TabIndex = 1;
            this.sensitivityLabel.Text = "Sensitivity";
            // 
            // axisDisplay
            // 
            this.axisDisplay.InnerColor = System.Drawing.Color.GhostWhite;
            this.axisDisplay.InnerSize = 12;
            this.axisDisplay.Location = new System.Drawing.Point(12, 245);
            this.axisDisplay.Name = "axisDisplay";
            this.axisDisplay.OuterColor = System.Drawing.Color.DodgerBlue;
            this.axisDisplay.Size = new System.Drawing.Size(60, 60);
            this.axisDisplay.TabIndex = 15;
            this.axisDisplay.Value = ((System.Drawing.PointF)(resources.GetObject("axisDisplay.Value")));
            // 
            // RemapperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.mouseInputGroupBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.macrosGroupBox);
            this.Controls.Add(this.mappingsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "RemapperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remapper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RemapperForm_FormClosed);
            this.Load += new System.EventHandler(this.RemapperForm_Load);
            this.macrosGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.macrosDataGridView)).EndInit();
            this.mappingsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mappingsDataGridView)).EndInit();
            this.mouseInputGroupBox.ResumeLayout(false);
            this.mouseInputGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bordersNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameRefreshNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivityNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox macrosGroupBox;
        private System.Windows.Forms.DataGridView macrosDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn Browse;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.GroupBox mappingsGroupBox;
        private System.Windows.Forms.DataGridView mappingsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.GroupBox mouseInputGroupBox;
        private System.Windows.Forms.Label sensitivityLabel;
        private System.Windows.Forms.Label frameRefreshLabel;
        private System.Windows.Forms.Label bordersLabel;
        private System.Windows.Forms.CheckBox enableMouseCheckBox;
        private System.Windows.Forms.NumericUpDown bordersNumericUpDown;
        private System.Windows.Forms.NumericUpDown frameRefreshNumericUpDown;
        private System.Windows.Forms.NumericUpDown sensitivityNumericUpDown;
        private System.Windows.Forms.ComboBox rightMouseComboBox;
        private System.Windows.Forms.Label rightMouseLabel;
        private System.Windows.Forms.ComboBox leftMouseComboBox;
        private System.Windows.Forms.Label leftMouseLabel;
        private System.Windows.Forms.Label movementJoystickLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rightStickRadioButton;
        private System.Windows.Forms.RadioButton leftStickRadioButton;
        private Controls.AxisDisplay axisDisplay;
        private System.Windows.Forms.CheckBox invertMouseYCheckBox;
        private System.Windows.Forms.CheckBox invertMouseXCheckBox;
        private System.Windows.Forms.ComboBox middleMouseComboBox;
        private System.Windows.Forms.Label middleMouseLabel;
        private System.Windows.Forms.Label decayThresholdLabel;
    }
}