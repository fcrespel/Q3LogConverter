namespace Q3LogConverter.gui
{
    partial class FormMain
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
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.buttonOutputBrowse = new System.Windows.Forms.Button();
            this.textBoxOutputFile = new System.Windows.Forms.TextBox();
            this.labelOutputFile = new System.Windows.Forms.Label();
            this.buttonInputBrowse = new System.Windows.Forms.Button();
            this.textBoxInputFile = new System.Windows.Forms.TextBox();
            this.labelInputFile = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.progressBarConvert = new System.Windows.Forms.ProgressBar();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.groupBoxFormat = new System.Windows.Forms.GroupBox();
            this.radioButtonFormatBBCode = new System.Windows.Forms.RadioButton();
            this.radioButtonFormatHTML = new System.Windows.Forms.RadioButton();
            this.radioButtonFormatPlain = new System.Windows.Forms.RadioButton();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.radioButtonColorConvert = new System.Windows.Forms.RadioButton();
            this.radioButtonColorRemove = new System.Windows.Forms.RadioButton();
            this.radioButtonColorKeep = new System.Windows.Forms.RadioButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panelMain = new System.Windows.Forms.Panel();
            this.conversionBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBoxFiles.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.groupBoxFormat.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFiles.Controls.Add(this.buttonOutputBrowse);
            this.groupBoxFiles.Controls.Add(this.textBoxOutputFile);
            this.groupBoxFiles.Controls.Add(this.labelOutputFile);
            this.groupBoxFiles.Controls.Add(this.buttonInputBrowse);
            this.groupBoxFiles.Controls.Add(this.textBoxInputFile);
            this.groupBoxFiles.Controls.Add(this.labelInputFile);
            this.groupBoxFiles.Location = new System.Drawing.Point(12, 6);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Size = new System.Drawing.Size(431, 93);
            this.groupBoxFiles.TabIndex = 1;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Files";
            // 
            // buttonOutputBrowse
            // 
            this.buttonOutputBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOutputBrowse.Location = new System.Drawing.Point(337, 48);
            this.buttonOutputBrowse.Name = "buttonOutputBrowse";
            this.buttonOutputBrowse.Size = new System.Drawing.Size(88, 23);
            this.buttonOutputBrowse.TabIndex = 5;
            this.buttonOutputBrowse.Text = "Browse...";
            this.buttonOutputBrowse.UseVisualStyleBackColor = true;
            this.buttonOutputBrowse.Click += new System.EventHandler(this.buttonOutputBrowse_Click);
            // 
            // textBoxOutputFile
            // 
            this.textBoxOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputFile.Location = new System.Drawing.Point(70, 50);
            this.textBoxOutputFile.Name = "textBoxOutputFile";
            this.textBoxOutputFile.Size = new System.Drawing.Size(261, 20);
            this.textBoxOutputFile.TabIndex = 4;
            // 
            // labelOutputFile
            // 
            this.labelOutputFile.AutoSize = true;
            this.labelOutputFile.Location = new System.Drawing.Point(6, 53);
            this.labelOutputFile.Name = "labelOutputFile";
            this.labelOutputFile.Size = new System.Drawing.Size(58, 13);
            this.labelOutputFile.TabIndex = 3;
            this.labelOutputFile.Text = "Output file:";
            // 
            // buttonInputBrowse
            // 
            this.buttonInputBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInputBrowse.Location = new System.Drawing.Point(337, 19);
            this.buttonInputBrowse.Name = "buttonInputBrowse";
            this.buttonInputBrowse.Size = new System.Drawing.Size(88, 23);
            this.buttonInputBrowse.TabIndex = 2;
            this.buttonInputBrowse.Text = "Browse...";
            this.buttonInputBrowse.UseVisualStyleBackColor = true;
            this.buttonInputBrowse.Click += new System.EventHandler(this.buttonInputBrowse_Click);
            // 
            // textBoxInputFile
            // 
            this.textBoxInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputFile.Location = new System.Drawing.Point(70, 21);
            this.textBoxInputFile.Name = "textBoxInputFile";
            this.textBoxInputFile.Size = new System.Drawing.Size(261, 20);
            this.textBoxInputFile.TabIndex = 1;
            // 
            // labelInputFile
            // 
            this.labelInputFile.AutoSize = true;
            this.labelInputFile.Location = new System.Drawing.Point(6, 24);
            this.labelInputFile.Name = "labelInputFile";
            this.labelInputFile.Size = new System.Drawing.Size(50, 13);
            this.labelInputFile.TabIndex = 0;
            this.labelInputFile.Text = "Input file:";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(446, 40);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Q3 Log Converter";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Plain text (*.txt;*.log)|*.txt;*.log|All files (*.*)|*.*";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(452, 40);
            this.panelTop.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelBottom.Controls.Add(this.progressBarConvert);
            this.panelBottom.Controls.Add(this.buttonConvert);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 251);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(452, 35);
            this.panelBottom.TabIndex = 4;
            // 
            // progressBarConvert
            // 
            this.progressBarConvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarConvert.Location = new System.Drawing.Point(9, 9);
            this.progressBarConvert.Name = "progressBarConvert";
            this.progressBarConvert.Size = new System.Drawing.Size(331, 18);
            this.progressBarConvert.TabIndex = 2;
            this.progressBarConvert.Visible = false;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConvert.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonConvert.Location = new System.Drawing.Point(346, 5);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(94, 26);
            this.buttonConvert.TabIndex = 1;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // groupBoxFormat
            // 
            this.groupBoxFormat.Controls.Add(this.radioButtonFormatBBCode);
            this.groupBoxFormat.Controls.Add(this.radioButtonFormatHTML);
            this.groupBoxFormat.Controls.Add(this.radioButtonFormatPlain);
            this.groupBoxFormat.Location = new System.Drawing.Point(12, 105);
            this.groupBoxFormat.Name = "groupBoxFormat";
            this.groupBoxFormat.Size = new System.Drawing.Size(157, 93);
            this.groupBoxFormat.TabIndex = 2;
            this.groupBoxFormat.TabStop = false;
            this.groupBoxFormat.Text = "Convert to";
            // 
            // radioButtonFormatBBCode
            // 
            this.radioButtonFormatBBCode.AutoSize = true;
            this.radioButtonFormatBBCode.Location = new System.Drawing.Point(9, 65);
            this.radioButtonFormatBBCode.Name = "radioButtonFormatBBCode";
            this.radioButtonFormatBBCode.Size = new System.Drawing.Size(64, 17);
            this.radioButtonFormatBBCode.TabIndex = 2;
            this.radioButtonFormatBBCode.Text = "BBCode";
            this.radioButtonFormatBBCode.UseVisualStyleBackColor = true;
            // 
            // radioButtonFormatHTML
            // 
            this.radioButtonFormatHTML.AutoSize = true;
            this.radioButtonFormatHTML.Checked = true;
            this.radioButtonFormatHTML.Location = new System.Drawing.Point(9, 42);
            this.radioButtonFormatHTML.Name = "radioButtonFormatHTML";
            this.radioButtonFormatHTML.Size = new System.Drawing.Size(55, 17);
            this.radioButtonFormatHTML.TabIndex = 1;
            this.radioButtonFormatHTML.TabStop = true;
            this.radioButtonFormatHTML.Text = "HTML";
            this.radioButtonFormatHTML.UseVisualStyleBackColor = true;
            // 
            // radioButtonFormatPlain
            // 
            this.radioButtonFormatPlain.AutoSize = true;
            this.radioButtonFormatPlain.Location = new System.Drawing.Point(9, 19);
            this.radioButtonFormatPlain.Name = "radioButtonFormatPlain";
            this.radioButtonFormatPlain.Size = new System.Drawing.Size(68, 17);
            this.radioButtonFormatPlain.TabIndex = 0;
            this.radioButtonFormatPlain.Text = "Plain text";
            this.radioButtonFormatPlain.UseVisualStyleBackColor = true;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxColor.Controls.Add(this.radioButtonColorConvert);
            this.groupBoxColor.Controls.Add(this.radioButtonColorRemove);
            this.groupBoxColor.Controls.Add(this.radioButtonColorKeep);
            this.groupBoxColor.Location = new System.Drawing.Point(175, 105);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(265, 93);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Color processing";
            // 
            // radioButtonColorConvert
            // 
            this.radioButtonColorConvert.AutoSize = true;
            this.radioButtonColorConvert.Checked = true;
            this.radioButtonColorConvert.Location = new System.Drawing.Point(6, 65);
            this.radioButtonColorConvert.Name = "radioButtonColorConvert";
            this.radioButtonColorConvert.Size = new System.Drawing.Size(125, 17);
            this.radioButtonColorConvert.TabIndex = 2;
            this.radioButtonColorConvert.TabStop = true;
            this.radioButtonColorConvert.Text = "Convert to real colors";
            this.radioButtonColorConvert.UseVisualStyleBackColor = true;
            // 
            // radioButtonColorRemove
            // 
            this.radioButtonColorRemove.AutoSize = true;
            this.radioButtonColorRemove.Location = new System.Drawing.Point(6, 42);
            this.radioButtonColorRemove.Name = "radioButtonColorRemove";
            this.radioButtonColorRemove.Size = new System.Drawing.Size(123, 17);
            this.radioButtonColorRemove.TabIndex = 1;
            this.radioButtonColorRemove.Text = "Remove color codes";
            this.radioButtonColorRemove.UseVisualStyleBackColor = true;
            // 
            // radioButtonColorKeep
            // 
            this.radioButtonColorKeep.AutoSize = true;
            this.radioButtonColorKeep.Location = new System.Drawing.Point(6, 19);
            this.radioButtonColorKeep.Name = "radioButtonColorKeep";
            this.radioButtonColorKeep.Size = new System.Drawing.Size(171, 17);
            this.radioButtonColorKeep.TabIndex = 0;
            this.radioButtonColorKeep.Text = "Keep color codes (^1, ^2, etc.)";
            this.radioButtonColorKeep.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.groupBoxFiles);
            this.panelMain.Controls.Add(this.groupBoxFormat);
            this.panelMain.Controls.Add(this.groupBoxColor);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(452, 211);
            this.panelMain.TabIndex = 8;
            // 
            // conversionBackgroundWorker
            // 
            this.conversionBackgroundWorker.WorkerReportsProgress = true;
            this.conversionBackgroundWorker.WorkerSupportsCancellation = true;
            this.conversionBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.conversionBackgroundWorker_DoWork);
            this.conversionBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.conversionBackgroundWorker_ProgressChanged);
            this.conversionBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.conversionBackgroundWorker_RunWorkerCompleted);
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 286);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new System.Drawing.Size(460, 320);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q3 Log Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.groupBoxFiles.ResumeLayout(false);
            this.groupBoxFiles.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.groupBoxFormat.ResumeLayout(false);
            this.groupBoxFormat.PerformLayout();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFiles;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelInputFile;
        private System.Windows.Forms.Button buttonInputBrowse;
        private System.Windows.Forms.TextBox textBoxInputFile;
        private System.Windows.Forms.Button buttonOutputBrowse;
        private System.Windows.Forms.TextBox textBoxOutputFile;
        private System.Windows.Forms.Label labelOutputFile;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.GroupBox groupBoxFormat;
        private System.Windows.Forms.RadioButton radioButtonFormatBBCode;
        private System.Windows.Forms.RadioButton radioButtonFormatHTML;
        private System.Windows.Forms.RadioButton radioButtonFormatPlain;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.RadioButton radioButtonColorConvert;
        private System.Windows.Forms.RadioButton radioButtonColorRemove;
        private System.Windows.Forms.RadioButton radioButtonColorKeep;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.ProgressBar progressBarConvert;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel panelMain;
        private System.ComponentModel.BackgroundWorker conversionBackgroundWorker;
    }
}