using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Q3LogConverter.lib;
using System.Threading;
using System.IO;

namespace Q3LogConverter.gui
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conversionBackgroundWorker.IsBusy)
            {
                conversionBackgroundWorker.CancelAsync();
            }
        }

        private LogConverterType getConverterType()
        {
            LogConverterType converterType = LogConverterType.TYPE_TEXT;
            if (radioButtonFormatHTML.Checked)
                converterType = LogConverterType.TYPE_HTML;
            else if (radioButtonFormatBBCode.Checked)
                converterType = LogConverterType.TYPE_BBCODE;

            return converterType;
        }

        private ColorProcessing getColorProcessing()
        {
            ColorProcessing colorProcessing = ColorProcessing.COLOR_KEEP;
            if (radioButtonColorConvert.Checked)
                colorProcessing = ColorProcessing.COLOR_CONVERT;
            else if (radioButtonColorRemove.Checked)
                colorProcessing = ColorProcessing.COLOR_REMOVE;

            return colorProcessing;
        }

        private void buttonInputBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                textBoxInputFile.Text = openFileDialog.FileName;
            }
        }

        private void buttonOutputBrowse_Click(object sender, EventArgs e)
        {
            switch (getConverterType())
            {
                case LogConverterType.TYPE_TEXT:
                case LogConverterType.TYPE_BBCODE:
                    saveFileDialog.Filter = "Plain text (*.txt;*.log)|*.txt;*.log|All files (*.*)|*.*";
                    break;

                case LogConverterType.TYPE_HTML:
                    saveFileDialog.Filter = "HTML (*.htm;*.html)|*.htm;*.html|All files (*.*)|*.*";
                    break;
            }

            if (saveFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                textBoxOutputFile.Text = saveFileDialog.FileName;
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (conversionBackgroundWorker.IsBusy)
            {   // Cancel conversion
                conversionBackgroundWorker.CancelAsync();
            }
            else
            {   // Check input and begin converting
                if (textBoxInputFile.Text.Trim().Length == 0)
                {
                    MessageBox.Show(this, "You must specify an input file to convert.", "Invalid input file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!File.Exists(textBoxInputFile.Text))
                {
                    MessageBox.Show(this, "The input file does not exist.", "Invalid input file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (textBoxOutputFile.Text.Trim().Length == 0)
                {
                    MessageBox.Show(this, "You must specify an output file.", "Invalid output file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    LogConverter converter = LogConverterFactory.create(getConverterType());
                    ColorProcessing colorProcessing = getColorProcessing();

                    object[] args = new object[4];
                    args[0] = converter;
                    args[1] = textBoxInputFile.Text;
                    args[2] = textBoxOutputFile.Text;
                    args[3] = colorProcessing;

                    progressBarConvert.Value = 0;
                    conversionBackgroundWorker.RunWorkerAsync(args);
                }
            }
        }

        private delegate void SetBusyStateDelegate(bool isBusy);
        private void SetBusyState(bool isBusy)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new SetBusyStateDelegate(SetBusyState), new object[] { isBusy });
                return;
            }

            buttonConvert.Text = isBusy ? "Cancel" : "Convert";
            groupBoxFiles.Enabled = groupBoxFormat.Enabled = groupBoxColor.Enabled = !isBusy;
            progressBarConvert.Visible = isBusy;
        }

        private void conversionBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            SetBusyState(true);

            BackgroundWorker worker = (BackgroundWorker)sender;
            object[] args = (object[])e.Argument;

            LogConverter converter = (LogConverter)args[0];
            string inputFileName = (string)args[1];
            string outputFileName = (string)args[2];
            ColorProcessing colorProcessing = (ColorProcessing)args[3];

            FileStream inputFileStream = null;
            FileStream outputFileStream = null;
            StreamReader inputFileReader = null;
            StreamWriter outputFileWriter = null;
            try
            {
                inputFileStream = File.OpenRead(inputFileName);
                outputFileStream = File.OpenWrite(outputFileName);
                inputFileReader = new StreamReader(inputFileStream);
                outputFileWriter = new StreamWriter(outputFileStream);

                // Count the number of lines in input
                int totalLines = 0;
                while (inputFileReader.ReadLine() != null)
                {
                    ++totalLines;
                }

                // Rewind to the beginning of the input file
                inputFileStream.Seek(0, SeekOrigin.Begin);

                // Write header
                outputFileWriter.WriteLine(converter.Header);
                
                // Convert input to output
                int currentLines = 0;
                string inputLine;
                while ((inputLine = inputFileReader.ReadLine()) != null)
                {
                    ++currentLines;

                    string outputLine = converter.Convert(inputLine, colorProcessing);
                    outputFileWriter.WriteLine(outputLine);

                    worker.ReportProgress((int)(currentLines * 100.0 / totalLines));

                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                }

                // Write footer
                outputFileWriter.WriteLine(converter.Footer);
            }
            finally
            {
                if (outputFileWriter != null) outputFileWriter.Close();
                if (inputFileReader != null) inputFileReader.Close();
                if (outputFileStream != null) outputFileStream.Close();
                if (inputFileStream != null) inputFileStream.Close();
            }
        }

        private void conversionBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(this, "Conversion cancelled.", "Conversion cancelled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (e.Error != null)
            {
                MessageBox.Show(this, "An error occurred while converting the file: " + e.Error.ToString(), "Conversion error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(this, "Conversion succeeded.", "Conversion succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            SetBusyState(false);
        }

        private void conversionBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarConvert.Value = e.ProgressPercentage;
        }
        
    }
}
