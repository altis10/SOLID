using System.Drawing;
using System.Windows.Forms;

namespace SOLIDFilesAnalyzerCSharp
{
  partial class FilesAnalyzer
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      this.scanningLocationGroupBox = new System.Windows.Forms.GroupBox();
      this.webScanLocationRadioButton = new System.Windows.Forms.RadioButton();
      this.scanLocalDrivesRadioButton = new System.Windows.Forms.RadioButton();
      this.fileTypeGroupBox = new System.Windows.Forms.GroupBox();
      this.exeCheckBox = new System.Windows.Forms.CheckBox();
      this.aviCheckBox = new System.Windows.Forms.CheckBox();
      this.mp4CheckBox = new System.Windows.Forms.CheckBox();
      this.mp3CheckBox = new System.Windows.Forms.CheckBox();
      this.pdfCheckBox = new System.Windows.Forms.CheckBox();
      this.textFilesCheckBox = new System.Windows.Forms.CheckBox();
      this.buttonScan = new System.Windows.Forms.Button();
      this.backgroundWorkerDetectFiles = new System.ComponentModel.BackgroundWorker();
      this.dataGridViewDetectedFiles = new System.Windows.Forms.DataGridView();
      this.bindingSourceDetectedFiles = new System.Windows.Forms.BindingSource(this.components);
      this.groupBoxCustomFileType = new System.Windows.Forms.GroupBox();
      this.textBoxCustomFileType = new System.Windows.Forms.TextBox();
      this.progressBarSearchFiles = new System.Windows.Forms.ProgressBar();
      this.folderBrowserDialog_Select = new System.Windows.Forms.FolderBrowserDialog();
      this.buttonSearchFolder = new System.Windows.Forms.Button();
      this.textBoxSearchFolder = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.buttonAnalyseFiles = new System.Windows.Forms.Button();
      this.scanningLocationGroupBox.SuspendLayout();
      this.fileTypeGroupBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetectedFiles)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDetectedFiles)).BeginInit();
      this.groupBoxCustomFileType.SuspendLayout();
      this.SuspendLayout();
      // 
      // scanningLocationGroupBox
      // 
      this.scanningLocationGroupBox.Controls.Add(this.webScanLocationRadioButton);
      this.scanningLocationGroupBox.Controls.Add(this.scanLocalDrivesRadioButton);
      this.scanningLocationGroupBox.Location = new System.Drawing.Point(12, 12);
      this.scanningLocationGroupBox.Name = "scanningLocationGroupBox";
      this.scanningLocationGroupBox.Size = new System.Drawing.Size(180, 82);
      this.scanningLocationGroupBox.TabIndex = 3;
      this.scanningLocationGroupBox.TabStop = false;
      this.scanningLocationGroupBox.Text = "Scanning Location";
      // 
      // webScanLocationRadioButton
      // 
      this.webScanLocationRadioButton.AutoSize = true;
      this.webScanLocationRadioButton.Location = new System.Drawing.Point(18, 43);
      this.webScanLocationRadioButton.Name = "webScanLocationRadioButton";
      this.webScanLocationRadioButton.Size = new System.Drawing.Size(126, 19);
      this.webScanLocationRadioButton.TabIndex = 1;
      this.webScanLocationRadioButton.TabStop = true;
      this.webScanLocationRadioButton.Text = "Scan Web Location";
      this.webScanLocationRadioButton.UseVisualStyleBackColor = true;
      this.webScanLocationRadioButton.CheckedChanged += new System.EventHandler(this.webScanLocationRadioButton_CheckedChanged);
      // 
      // scanLocalDrivesRadioButton
      // 
      this.scanLocalDrivesRadioButton.AutoSize = true;
      this.scanLocalDrivesRadioButton.Checked = true;
      this.scanLocalDrivesRadioButton.Location = new System.Drawing.Point(18, 22);
      this.scanLocalDrivesRadioButton.Name = "scanLocalDrivesRadioButton";
      this.scanLocalDrivesRadioButton.Size = new System.Drawing.Size(116, 19);
      this.scanLocalDrivesRadioButton.TabIndex = 0;
      this.scanLocalDrivesRadioButton.TabStop = true;
      this.scanLocalDrivesRadioButton.Text = "Scan Local Drives";
      this.scanLocalDrivesRadioButton.UseVisualStyleBackColor = true;
      this.scanLocalDrivesRadioButton.CheckedChanged += new System.EventHandler(this.scanLocalDrivesRadioButton_CheckedChanged);
      // 
      // fileTypeGroupBox
      // 
      this.fileTypeGroupBox.Controls.Add(this.exeCheckBox);
      this.fileTypeGroupBox.Controls.Add(this.aviCheckBox);
      this.fileTypeGroupBox.Controls.Add(this.mp4CheckBox);
      this.fileTypeGroupBox.Controls.Add(this.mp3CheckBox);
      this.fileTypeGroupBox.Controls.Add(this.pdfCheckBox);
      this.fileTypeGroupBox.Controls.Add(this.textFilesCheckBox);
      this.fileTypeGroupBox.Location = new System.Drawing.Point(12, 181);
      this.fileTypeGroupBox.Name = "fileTypeGroupBox";
      this.fileTypeGroupBox.Size = new System.Drawing.Size(180, 100);
      this.fileTypeGroupBox.TabIndex = 5;
      this.fileTypeGroupBox.TabStop = false;
      this.fileTypeGroupBox.Text = "File types";
      // 
      // exeCheckBox
      // 
      this.exeCheckBox.AutoSize = true;
      this.exeCheckBox.Location = new System.Drawing.Point(91, 72);
      this.exeCheckBox.Name = "exeCheckBox";
      this.exeCheckBox.Size = new System.Drawing.Size(47, 19);
      this.exeCheckBox.TabIndex = 10;
      this.exeCheckBox.Text = ".exe";
      this.exeCheckBox.UseVisualStyleBackColor = true;
      this.exeCheckBox.CheckedChanged += new System.EventHandler(this.exeCheckBox_CheckedChanged);
      // 
      // aviCheckBox
      // 
      this.aviCheckBox.AutoSize = true;
      this.aviCheckBox.Location = new System.Drawing.Point(91, 47);
      this.aviCheckBox.Name = "aviCheckBox";
      this.aviCheckBox.Size = new System.Drawing.Size(44, 19);
      this.aviCheckBox.TabIndex = 9;
      this.aviCheckBox.Text = ".avi";
      this.aviCheckBox.UseVisualStyleBackColor = true;
      this.aviCheckBox.CheckedChanged += new System.EventHandler(this.aviCheckBox_CheckedChanged);
      // 
      // mp4CheckBox
      // 
      this.mp4CheckBox.AutoSize = true;
      this.mp4CheckBox.Location = new System.Drawing.Point(91, 22);
      this.mp4CheckBox.Name = "mp4CheckBox";
      this.mp4CheckBox.Size = new System.Drawing.Size(53, 19);
      this.mp4CheckBox.TabIndex = 7;
      this.mp4CheckBox.Text = ".mp4";
      this.mp4CheckBox.UseVisualStyleBackColor = true;
      this.mp4CheckBox.CheckedChanged += new System.EventHandler(this.mp4CheckBox_CheckedChanged);
      // 
      // mp3CheckBox
      // 
      this.mp3CheckBox.AutoSize = true;
      this.mp3CheckBox.Location = new System.Drawing.Point(18, 72);
      this.mp3CheckBox.Name = "mp3CheckBox";
      this.mp3CheckBox.Size = new System.Drawing.Size(53, 19);
      this.mp3CheckBox.TabIndex = 8;
      this.mp3CheckBox.Text = ".mp3";
      this.mp3CheckBox.UseVisualStyleBackColor = true;
      this.mp3CheckBox.CheckedChanged += new System.EventHandler(this.mp3CheckBox_CheckedChanged);
      // 
      // pdfCheckBox
      // 
      this.pdfCheckBox.AutoSize = true;
      this.pdfCheckBox.Location = new System.Drawing.Point(18, 47);
      this.pdfCheckBox.Name = "pdfCheckBox";
      this.pdfCheckBox.Size = new System.Drawing.Size(47, 19);
      this.pdfCheckBox.TabIndex = 7;
      this.pdfCheckBox.Text = ".pdf";
      this.pdfCheckBox.UseVisualStyleBackColor = true;
      this.pdfCheckBox.CheckedChanged += new System.EventHandler(this.pdfCheckBox_CheckedChanged);
      // 
      // textFilesCheckBox
      // 
      this.textFilesCheckBox.AutoSize = true;
      this.textFilesCheckBox.Location = new System.Drawing.Point(18, 22);
      this.textFilesCheckBox.Name = "textFilesCheckBox";
      this.textFilesCheckBox.Size = new System.Drawing.Size(43, 19);
      this.textFilesCheckBox.TabIndex = 6;
      this.textFilesCheckBox.Text = ".txt";
      this.textFilesCheckBox.UseVisualStyleBackColor = true;
      this.textFilesCheckBox.CheckedChanged += new System.EventHandler(this.textFilesCheckBox_CheckedChanged);
      // 
      // buttonScan
      // 
      this.buttonScan.Location = new System.Drawing.Point(12, 400);
      this.buttonScan.Name = "buttonScan";
      this.buttonScan.Size = new System.Drawing.Size(75, 23);
      this.buttonScan.TabIndex = 11;
      this.buttonScan.Text = "Scan";
      this.buttonScan.UseVisualStyleBackColor = true;
      this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
      // 
      // backgroundWorkerDetectFiles
      // 
      this.backgroundWorkerDetectFiles.WorkerReportsProgress = true;
      this.backgroundWorkerDetectFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDetectFiles_DoWork);
      // 
      // dataGridViewDetectedFiles
      // 
      this.dataGridViewDetectedFiles.AllowUserToOrderColumns = true;
      this.dataGridViewDetectedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridViewDetectedFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewDetectedFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.dataGridViewDetectedFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewDetectedFiles.DefaultCellStyle = dataGridViewCellStyle4;
      this.dataGridViewDetectedFiles.Location = new System.Drawing.Point(221, 12);
      this.dataGridViewDetectedFiles.Name = "dataGridViewDetectedFiles";
      this.dataGridViewDetectedFiles.RowTemplate.Height = 25;
      this.dataGridViewDetectedFiles.Size = new System.Drawing.Size(567, 411);
      this.dataGridViewDetectedFiles.TabIndex = 12;
      // 
      // groupBoxCustomFileType
      // 
      this.groupBoxCustomFileType.Controls.Add(this.textBoxCustomFileType);
      this.groupBoxCustomFileType.Location = new System.Drawing.Point(12, 287);
      this.groupBoxCustomFileType.Name = "groupBoxCustomFileType";
      this.groupBoxCustomFileType.Size = new System.Drawing.Size(180, 51);
      this.groupBoxCustomFileType.TabIndex = 11;
      this.groupBoxCustomFileType.TabStop = false;
      this.groupBoxCustomFileType.Text = "Custom File Type";
      // 
      // textBoxCustomFileType
      // 
      this.textBoxCustomFileType.Location = new System.Drawing.Point(6, 22);
      this.textBoxCustomFileType.Name = "textBoxCustomFileType";
      this.textBoxCustomFileType.Size = new System.Drawing.Size(161, 23);
      this.textBoxCustomFileType.TabIndex = 13;
      this.textBoxCustomFileType.TextChanged += new System.EventHandler(this.textBoxCustomFileType_TextChanged);
      // 
      // progressBarSearchFiles
      // 
      this.progressBarSearchFiles.Location = new System.Drawing.Point(221, 430);
      this.progressBarSearchFiles.Name = "progressBarSearchFiles";
      this.progressBarSearchFiles.Size = new System.Drawing.Size(567, 10);
      this.progressBarSearchFiles.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      this.progressBarSearchFiles.TabIndex = 13;
      // 
      // folderBrowserDialog_Select
      // 
      this.folderBrowserDialog_Select.RootFolder = System.Environment.SpecialFolder.MyComputer;
      // 
      // buttonSearchFolder
      // 
      this.buttonSearchFolder.AllowDrop = true;
      this.buttonSearchFolder.Location = new System.Drawing.Point(12, 100);
      this.buttonSearchFolder.Name = "buttonSearchFolder";
      this.buttonSearchFolder.Size = new System.Drawing.Size(180, 23);
      this.buttonSearchFolder.TabIndex = 16;
      this.buttonSearchFolder.Text = "Search Location";
      this.buttonSearchFolder.UseVisualStyleBackColor = true;
      this.buttonSearchFolder.Click += new System.EventHandler(this.buttonSearchFolder_Click);
      // 
      // textBoxSearchFolder
      // 
      this.textBoxSearchFolder.Location = new System.Drawing.Point(12, 152);
      this.textBoxSearchFolder.Name = "textBoxSearchFolder";
      this.textBoxSearchFolder.ReadOnly = true;
      this.textBoxSearchFolder.Size = new System.Drawing.Size(180, 23);
      this.textBoxSearchFolder.TabIndex = 17;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(18, 134);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(78, 15);
      this.label1.TabIndex = 18;
      this.label1.Text = "Search Folder";
      // 
      // buttonAnalyseFiles
      // 
      this.buttonAnalyseFiles.Location = new System.Drawing.Point(104, 400);
      this.buttonAnalyseFiles.Name = "buttonAnalyseFiles";
      this.buttonAnalyseFiles.Size = new System.Drawing.Size(88, 23);
      this.buttonAnalyseFiles.TabIndex = 19;
      this.buttonAnalyseFiles.Text = "Analyse Files";
      this.buttonAnalyseFiles.UseVisualStyleBackColor = true;
      this.buttonAnalyseFiles.Click += new System.EventHandler(this.buttonAnalyseFiles_Click);
      // 
      // FilesAnalyzer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.buttonAnalyseFiles);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxSearchFolder);
      this.Controls.Add(this.buttonSearchFolder);
      this.Controls.Add(this.progressBarSearchFiles);
      this.Controls.Add(this.groupBoxCustomFileType);
      this.Controls.Add(this.dataGridViewDetectedFiles);
      this.Controls.Add(this.buttonScan);
      this.Controls.Add(this.fileTypeGroupBox);
      this.Controls.Add(this.scanningLocationGroupBox);
      this.Name = "FilesAnalyzer";
      this.Text = "File Analyzer";
      this.scanningLocationGroupBox.ResumeLayout(false);
      this.scanningLocationGroupBox.PerformLayout();
      this.fileTypeGroupBox.ResumeLayout(false);
      this.fileTypeGroupBox.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetectedFiles)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDetectedFiles)).EndInit();
      this.groupBoxCustomFileType.ResumeLayout(false);
      this.groupBoxCustomFileType.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private GroupBox scanningLocationGroupBox;
    private RadioButton webScanLocationRadioButton;
    private RadioButton scanLocalDrivesRadioButton;
    private GroupBox fileTypeGroupBox;
    private CheckBox exeCheckBox;
    private CheckBox aviCheckBox;
    private CheckBox mp4CheckBox;
    private CheckBox mp3CheckBox;
    private CheckBox pdfCheckBox;
    private CheckBox textFilesCheckBox;
    private Button buttonScan;
    private System.ComponentModel.BackgroundWorker backgroundWorkerDetectFiles;
    private DataGridView dataGridViewDetectedFiles;
    private BindingSource bindingSourceDetectedFiles;
    private GroupBox groupBoxCustomFileType;
    private TextBox textBoxCustomFileType;
    private ProgressBar progressBarSearchFiles;
    private FolderBrowserDialog folderBrowserDialog_Select;
    private Button buttonSearchFolder;
        private TextBox textBoxSearchFolder;
        private Label label1;
        private Button buttonAnalyseFiles;

        public SizeF AutoScaleDimensions { get; private set; }
  }
}