namespace SOLIDFilesAnalyzerCSharp
{
  partial class DisplayAnalysisResults
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
      this.dataGridViewDisplayAnalysisResults = new System.Windows.Forms.DataGridView();
      this.backgroundWorkerAnalyseFilesProperties = new System.ComponentModel.BackgroundWorker();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayAnalysisResults)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridViewDisplayAnalysisResults
      // 
      this.dataGridViewDisplayAnalysisResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewDisplayAnalysisResults.Location = new System.Drawing.Point(2, 1);
      this.dataGridViewDisplayAnalysisResults.Name = "dataGridViewDisplayAnalysisResults";
      this.dataGridViewDisplayAnalysisResults.RowTemplate.Height = 25;
      this.dataGridViewDisplayAnalysisResults.Size = new System.Drawing.Size(797, 383);
      this.dataGridViewDisplayAnalysisResults.TabIndex = 0;
      // 
      // backgroundWorkerAnalyseFilesProperties
      // 
      this.backgroundWorkerAnalyseFilesProperties.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerAnalyseFilesProperties_DoWork);
      // 
      // DisplayAnalysisResults
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.dataGridViewDisplayAnalysisResults);
      this.Name = "DisplayAnalysisResults";
      this.Text = "DisplayAnalysisResults";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayAnalysisResults)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDisplayAnalysisResults;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAnalyseFilesProperties;
    }
}