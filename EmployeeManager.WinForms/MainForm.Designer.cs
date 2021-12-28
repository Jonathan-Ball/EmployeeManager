namespace EmployeeManager.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.headerControl1 = new EmployeeManager.WinForms.Controls.HeaderControl();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.lblJobRole = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.cboJobRole = new System.Windows.Forms.ComboBox();
            this.chkIsCoffeeDrinker = new System.Windows.Forms.CheckBox();
            this.pnlMainArea = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.lsbEmployees = new System.Windows.Forms.ListBox();
            this.pnlRefresh = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlMainArea.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.pnlRefresh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.headerControl1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(873, 128);
            this.pnlHeader.TabIndex = 0;
            // 
            // headerControl1
            // 
            this.headerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(90)))), ((int)(((byte)(40)))));
            this.headerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerControl1.Location = new System.Drawing.Point(0, 0);
            this.headerControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(873, 128);
            this.headerControl1.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(63, 41);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(89, 25);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Firstname";
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.AutoSize = true;
            this.lblEntryDate.Location = new System.Drawing.Point(63, 137);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(94, 25);
            this.lblEntryDate.TabIndex = 1;
            this.lblEntryDate.Text = "Entry Date";
            // 
            // lblJobRole
            // 
            this.lblJobRole.AutoSize = true;
            this.lblJobRole.Location = new System.Drawing.Point(63, 236);
            this.lblJobRole.Name = "lblJobRole";
            this.lblJobRole.Size = new System.Drawing.Size(79, 25);
            this.lblJobRole.TabIndex = 2;
            this.lblJobRole.Text = "Job Role";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(63, 84);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(249, 31);
            this.txtFirstName.TabIndex = 3;
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEntryDate.Location = new System.Drawing.Point(63, 186);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(249, 31);
            this.dtpEntryDate.TabIndex = 4;
            // 
            // cboJobRole
            // 
            this.cboJobRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboJobRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJobRole.FormattingEnabled = true;
            this.cboJobRole.Location = new System.Drawing.Point(63, 287);
            this.cboJobRole.Name = "cboJobRole";
            this.cboJobRole.Size = new System.Drawing.Size(249, 31);
            this.cboJobRole.TabIndex = 5;
            // 
            // chkIsCoffeeDrinker
            // 
            this.chkIsCoffeeDrinker.AutoSize = true;
            this.chkIsCoffeeDrinker.Location = new System.Drawing.Point(63, 350);
            this.chkIsCoffeeDrinker.Name = "chkIsCoffeeDrinker";
            this.chkIsCoffeeDrinker.Size = new System.Drawing.Size(163, 29);
            this.chkIsCoffeeDrinker.TabIndex = 6;
            this.chkIsCoffeeDrinker.Text = "Is Coffee Drinker";
            this.chkIsCoffeeDrinker.UseVisualStyleBackColor = true;
            // 
            // pnlMainArea
            // 
            this.pnlMainArea.Controls.Add(this.btnSave);
            this.pnlMainArea.Controls.Add(this.chkIsCoffeeDrinker);
            this.pnlMainArea.Controls.Add(this.cboJobRole);
            this.pnlMainArea.Controls.Add(this.dtpEntryDate);
            this.pnlMainArea.Controls.Add(this.txtFirstName);
            this.pnlMainArea.Controls.Add(this.lblJobRole);
            this.pnlMainArea.Controls.Add(this.lblEntryDate);
            this.pnlMainArea.Controls.Add(this.lblFirstName);
            this.pnlMainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainArea.Location = new System.Drawing.Point(271, 128);
            this.pnlMainArea.Name = "pnlMainArea";
            this.pnlMainArea.Size = new System.Drawing.Size(602, 493);
            this.pnlMainArea.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(63, 421);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 38);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Controls.Add(this.lsbEmployees);
            this.pnlNavigation.Controls.Add(this.pnlRefresh);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 128);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(271, 493);
            this.pnlNavigation.TabIndex = 1;
            // 
            // lsbEmployees
            // 
            this.lsbEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbEmployees.FormattingEnabled = true;
            this.lsbEmployees.ItemHeight = 23;
            this.lsbEmployees.Location = new System.Drawing.Point(0, 66);
            this.lsbEmployees.Name = "lsbEmployees";
            this.lsbEmployees.Size = new System.Drawing.Size(271, 427);
            this.lsbEmployees.TabIndex = 1;
            // 
            // pnlRefresh
            // 
            this.pnlRefresh.Controls.Add(this.btnRefresh);
            this.pnlRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRefresh.Location = new System.Drawing.Point(0, 0);
            this.pnlRefresh.Name = "pnlRefresh";
            this.pnlRefresh.Size = new System.Drawing.Size(271, 66);
            this.pnlRefresh.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRefresh.Location = new System.Drawing.Point(24, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(227, 33);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 621);
            this.Controls.Add(this.pnlMainArea);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlMainArea.ResumeLayout(false);
            this.pnlMainArea.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlRefresh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlHeader;
        private Controls.HeaderControl headerControl1;
        private Label lblFirstName;
        private Label lblEntryDate;
        private Label lblJobRole;
        private TextBox txtFirstName;
        private DateTimePicker dtpEntryDate;
        private ComboBox cboJobRole;
        private CheckBox chkIsCoffeeDrinker;
        private Panel pnlMainArea;
        private Button btnSave;
        private Panel pnlNavigation;
        private ListBox lsbEmployees;
        private Panel pnlRefresh;
        private Button btnRefresh;
        private BindingSource employeeBindingSource;
    }
}