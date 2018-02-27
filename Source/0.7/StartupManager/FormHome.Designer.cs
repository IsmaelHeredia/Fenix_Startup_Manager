namespace StartupManager
{
    partial class FormHome
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.gbStartupFiles = new System.Windows.Forms.GroupBox();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.lblSearchIn = new System.Windows.Forms.Label();
            this.lbValues = new System.Windows.Forms.ListBox();
            this.lbNames = new System.Windows.Forms.ListBox();
            this.lvStartupFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ListValues = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateValue = new System.Windows.Forms.ToolStripMenuItem();
            this.EditValue = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteValue = new System.Windows.Forms.ToolStripMenuItem();
            this.ReadValue = new System.Windows.Forms.ToolStripMenuItem();
            this.ReadName = new System.Windows.Forms.ToolStripMenuItem();
            this.ReadTheValue = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyName = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyValue = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tmUpdateProcess = new System.Windows.Forms.Timer(this.components);
            this.gbStartupFiles.SuspendLayout();
            this.cmsOpciones.SuspendLayout();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStartupFiles
            // 
            this.gbStartupFiles.BackColor = System.Drawing.Color.Transparent;
            this.gbStartupFiles.Controls.Add(this.cmbTypes);
            this.gbStartupFiles.Controls.Add(this.lblSearchIn);
            this.gbStartupFiles.Controls.Add(this.lbValues);
            this.gbStartupFiles.Controls.Add(this.lbNames);
            this.gbStartupFiles.Controls.Add(this.lvStartupFiles);
            this.gbStartupFiles.ForeColor = System.Drawing.Color.Lime;
            this.gbStartupFiles.Location = new System.Drawing.Point(27, 115);
            this.gbStartupFiles.Name = "gbStartupFiles";
            this.gbStartupFiles.Size = new System.Drawing.Size(590, 231);
            this.gbStartupFiles.TabIndex = 0;
            this.gbStartupFiles.TabStop = false;
            this.gbStartupFiles.Text = "Startup Files";
            // 
            // cmbTypes
            // 
            this.cmbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Items.AddRange(new object[] {
            "HKEY_LOCAL_MACHINE",
            "HKEY_CURRENT_USER"});
            this.cmbTypes.Location = new System.Drawing.Point(85, 193);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(148, 21);
            this.cmbTypes.TabIndex = 5;
            // 
            // lblSearchIn
            // 
            this.lblSearchIn.AutoSize = true;
            this.lblSearchIn.Location = new System.Drawing.Point(18, 196);
            this.lblSearchIn.Name = "lblSearchIn";
            this.lblSearchIn.Size = new System.Drawing.Size(61, 13);
            this.lblSearchIn.TabIndex = 4;
            this.lblSearchIn.Text = "Search in : ";
            // 
            // lbValues
            // 
            this.lbValues.FormattingEnabled = true;
            this.lbValues.Location = new System.Drawing.Point(284, 66);
            this.lbValues.Name = "lbValues";
            this.lbValues.Size = new System.Drawing.Size(120, 95);
            this.lbValues.TabIndex = 3;
            this.lbValues.Visible = false;
            // 
            // lbNames
            // 
            this.lbNames.FormattingEnabled = true;
            this.lbNames.Location = new System.Drawing.Point(134, 66);
            this.lbNames.Name = "lbNames";
            this.lbNames.Size = new System.Drawing.Size(120, 95);
            this.lbNames.TabIndex = 2;
            this.lbNames.Visible = false;
            // 
            // lvStartupFiles
            // 
            this.lvStartupFiles.BackColor = System.Drawing.Color.Black;
            this.lvStartupFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvStartupFiles.ContextMenuStrip = this.cmsOpciones;
            this.lvStartupFiles.ForeColor = System.Drawing.Color.Lime;
            this.lvStartupFiles.FullRowSelect = true;
            this.lvStartupFiles.Location = new System.Drawing.Point(21, 31);
            this.lvStartupFiles.Name = "lvStartupFiles";
            this.lvStartupFiles.Size = new System.Drawing.Size(549, 147);
            this.lvStartupFiles.TabIndex = 1;
            this.lvStartupFiles.UseCompatibleStateImageBehavior = false;
            this.lvStartupFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 158;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 600;
            // 
            // cmsOpciones
            // 
            this.cmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListValues,
            this.CreateValue,
            this.EditValue,
            this.DeleteValue,
            this.ReadValue,
            this.CopyToClipboard});
            this.cmsOpciones.Name = "contextMenuStrip1";
            this.cmsOpciones.Size = new System.Drawing.Size(172, 136);
            // 
            // ListValues
            // 
            this.ListValues.Name = "ListValues";
            this.ListValues.Size = new System.Drawing.Size(171, 22);
            this.ListValues.Text = "List Values";
            this.ListValues.Click += new System.EventHandler(this.ListValues_Click);
            // 
            // CreateValue
            // 
            this.CreateValue.Name = "CreateValue";
            this.CreateValue.Size = new System.Drawing.Size(171, 22);
            this.CreateValue.Text = "Create Value";
            this.CreateValue.Click += new System.EventHandler(this.CreateValue_Click);
            // 
            // EditValue
            // 
            this.EditValue.Name = "EditValue";
            this.EditValue.Size = new System.Drawing.Size(171, 22);
            this.EditValue.Text = "Edit Value";
            this.EditValue.Click += new System.EventHandler(this.EditValue_Click);
            // 
            // DeleteValue
            // 
            this.DeleteValue.Name = "DeleteValue";
            this.DeleteValue.Size = new System.Drawing.Size(171, 22);
            this.DeleteValue.Text = "Delete Value";
            this.DeleteValue.Click += new System.EventHandler(this.DeleteValue_Click);
            // 
            // ReadValue
            // 
            this.ReadValue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReadName,
            this.ReadTheValue});
            this.ReadValue.Name = "ReadValue";
            this.ReadValue.Size = new System.Drawing.Size(171, 22);
            this.ReadValue.Text = "Read Value";
            // 
            // ReadName
            // 
            this.ReadName.Name = "ReadName";
            this.ReadName.Size = new System.Drawing.Size(106, 22);
            this.ReadName.Text = "Name";
            this.ReadName.Click += new System.EventHandler(this.ReadName_Click);
            // 
            // ReadTheValue
            // 
            this.ReadTheValue.Name = "ReadTheValue";
            this.ReadTheValue.Size = new System.Drawing.Size(106, 22);
            this.ReadTheValue.Text = "Value";
            this.ReadTheValue.Click += new System.EventHandler(this.ReadTheValue_Click);
            // 
            // CopyToClipboard
            // 
            this.CopyToClipboard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyName,
            this.CopyValue});
            this.CopyToClipboard.Name = "CopyToClipboard";
            this.CopyToClipboard.Size = new System.Drawing.Size(171, 22);
            this.CopyToClipboard.Text = "Copy to Clipboard";
            // 
            // CopyName
            // 
            this.CopyName.Name = "CopyName";
            this.CopyName.Size = new System.Drawing.Size(106, 22);
            this.CopyName.Text = "Name";
            this.CopyName.Click += new System.EventHandler(this.CopyName_Click);
            // 
            // CopyValue
            // 
            this.CopyValue.Name = "CopyValue";
            this.CopyValue.Size = new System.Drawing.Size(106, 22);
            this.CopyValue.Text = "Value";
            this.CopyValue.Click += new System.EventHandler(this.CopyValue_Click);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Black;
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.status.Location = new System.Drawing.Point(0, 366);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(640, 22);
            this.status.TabIndex = 4;
            this.status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Lime;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(71, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(493, 88);
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // tmUpdateProcess
            // 
            this.tmUpdateProcess.Enabled = true;
            this.tmUpdateProcess.Interval = 60000;
            this.tmUpdateProcess.Tick += new System.EventHandler(this.tmUpdateProcess_Tick);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(640, 388);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.status);
            this.Controls.Add(this.gbStartupFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.Text = " - Fenix Startup Manager 0.7 - © Ismael Heredia , Argentina , 2017 -";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.gbStartupFiles.ResumeLayout(false);
            this.gbStartupFiles.PerformLayout();
            this.cmsOpciones.ResumeLayout(false);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStartupFiles;
        private System.Windows.Forms.ListView lvStartupFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListBox lbNames;
        private System.Windows.Forms.ContextMenuStrip cmsOpciones;
        private System.Windows.Forms.ToolStripMenuItem CreateValue;
        private System.Windows.Forms.ToolStripMenuItem EditValue;
        private System.Windows.Forms.ToolStripMenuItem DeleteValue;
        private System.Windows.Forms.ToolStripMenuItem ListValues;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem ReadValue;
        private System.Windows.Forms.ToolStripMenuItem ReadName;
        private System.Windows.Forms.ToolStripMenuItem ReadTheValue;
        private System.Windows.Forms.ToolStripMenuItem CopyToClipboard;
        private System.Windows.Forms.ToolStripMenuItem CopyName;
        private System.Windows.Forms.ToolStripMenuItem CopyValue;
        private System.Windows.Forms.ListBox lbValues;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.Label lblSearchIn;
        private System.Windows.Forms.Timer tmUpdateProcess;

    }
}

