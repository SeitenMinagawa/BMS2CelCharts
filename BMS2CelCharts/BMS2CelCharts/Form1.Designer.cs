namespace BMS2CelCharts
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.butSelectData = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comChartStyle = new System.Windows.Forms.ComboBox();
            this.gridBPMSetting = new System.Windows.Forms.DataGridView();
            this.beat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridMeasureLineSetting = new System.Windows.Forms.DataGridView();
            this.measure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.numTotal = new System.Windows.Forms.NumericUpDown();
            this.numLastMeasure = new System.Windows.Forms.NumericUpDown();
            this.comJudgeLevel = new System.Windows.Forms.ComboBox();
            this.butBPMRowDelete = new System.Windows.Forms.Button();
            this.butMeasureLineSettingDelete = new System.Windows.Forms.Button();
            this.butGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridBPMSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMeasureLineSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLastMeasure)).BeginInit();
            this.SuspendLayout();
            // 
            // butSelectData
            // 
            this.butSelectData.Location = new System.Drawing.Point(831, 12);
            this.butSelectData.Name = "butSelectData";
            this.butSelectData.Size = new System.Drawing.Size(100, 19);
            this.butSelectData.TabIndex = 1;
            this.butSelectData.Text = "参照";
            this.butSelectData.UseVisualStyleBackColor = true;
            this.butSelectData.Click += new System.EventHandler(this.butSelectData_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(813, 19);
            this.txtPath.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comChartStyle
            // 
            this.comChartStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comChartStyle.FormattingEnabled = true;
            this.comChartStyle.Items.AddRange(new object[] {
            "PRINCESS",
            "RIPPLE",
            "TORNADO",
            "SAMPLER",
            "PHOENIX",
            "DJ SAMPLER",
            "GAMEPAD",
            "STICKPAD",
            "HAPPINESS",
            "DJ FULL"});
            this.comChartStyle.Location = new System.Drawing.Point(782, 37);
            this.comChartStyle.MaxDropDownItems = 10;
            this.comChartStyle.Name = "comChartStyle";
            this.comChartStyle.Size = new System.Drawing.Size(150, 20);
            this.comChartStyle.TabIndex = 6;
            // 
            // gridBPMSetting
            // 
            this.gridBPMSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBPMSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.beat,
            this.BPM,
            this.stop});
            this.gridBPMSetting.Location = new System.Drawing.Point(13, 37);
            this.gridBPMSetting.Name = "gridBPMSetting";
            this.gridBPMSetting.RowTemplate.Height = 21;
            this.gridBPMSetting.Size = new System.Drawing.Size(360, 260);
            this.gridBPMSetting.TabIndex = 2;
            // 
            // beat
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N6";
            dataGridViewCellStyle7.NullValue = "0";
            this.beat.DefaultCellStyle = dataGridViewCellStyle7;
            this.beat.HeaderText = "beat値";
            this.beat.Name = "beat";
            this.beat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BPM
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N6";
            dataGridViewCellStyle8.NullValue = "0";
            this.BPM.DefaultCellStyle = dataGridViewCellStyle8;
            this.BPM.HeaderText = "BPM";
            this.BPM.Name = "BPM";
            this.BPM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // stop
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N6";
            dataGridViewCellStyle9.NullValue = "0";
            this.stop.DefaultCellStyle = dataGridViewCellStyle9;
            this.stop.HeaderText = "ストップ";
            this.stop.Name = "stop";
            this.stop.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gridMeasureLineSetting
            // 
            this.gridMeasureLineSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMeasureLineSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.measure,
            this.style});
            this.gridMeasureLineSetting.Location = new System.Drawing.Point(384, 37);
            this.gridMeasureLineSetting.Name = "gridMeasureLineSetting";
            this.gridMeasureLineSetting.RowTemplate.Height = 21;
            this.gridMeasureLineSetting.Size = new System.Drawing.Size(260, 260);
            this.gridMeasureLineSetting.TabIndex = 4;
            // 
            // measure
            // 
            this.measure.HeaderText = "小節数";
            this.measure.Name = "measure";
            this.measure.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // style
            // 
            this.style.HeaderText = "スタイル";
            this.style.Items.AddRange(new object[] {
            "Fake",
            "Hidden"});
            this.style.Name = "style";
            this.style.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // numTotal
            // 
            this.numTotal.DecimalPlaces = 3;
            this.numTotal.Location = new System.Drawing.Point(782, 89);
            this.numTotal.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            196608});
            this.numTotal.Name = "numTotal";
            this.numTotal.Size = new System.Drawing.Size(150, 19);
            this.numTotal.TabIndex = 8;
            this.numTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numLastMeasure
            // 
            this.numLastMeasure.Location = new System.Drawing.Point(782, 114);
            this.numLastMeasure.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numLastMeasure.Name = "numLastMeasure";
            this.numLastMeasure.Size = new System.Drawing.Size(150, 19);
            this.numLastMeasure.TabIndex = 9;
            this.numLastMeasure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comJudgeLevel
            // 
            this.comJudgeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comJudgeLevel.FormattingEnabled = true;
            this.comJudgeLevel.Items.AddRange(new object[] {
            "GJA",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comJudgeLevel.Location = new System.Drawing.Point(782, 63);
            this.comJudgeLevel.MaxDropDownItems = 10;
            this.comJudgeLevel.Name = "comJudgeLevel";
            this.comJudgeLevel.Size = new System.Drawing.Size(150, 20);
            this.comJudgeLevel.TabIndex = 7;
            // 
            // butBPMRowDelete
            // 
            this.butBPMRowDelete.Location = new System.Drawing.Point(14, 303);
            this.butBPMRowDelete.Name = "butBPMRowDelete";
            this.butBPMRowDelete.Size = new System.Drawing.Size(359, 21);
            this.butBPMRowDelete.TabIndex = 3;
            this.butBPMRowDelete.Text = "選択行削除";
            this.butBPMRowDelete.UseVisualStyleBackColor = true;
            this.butBPMRowDelete.Click += new System.EventHandler(this.butBPMRowDelete_Click);
            // 
            // butMeasureLineSettingDelete
            // 
            this.butMeasureLineSettingDelete.Location = new System.Drawing.Point(384, 303);
            this.butMeasureLineSettingDelete.Name = "butMeasureLineSettingDelete";
            this.butMeasureLineSettingDelete.Size = new System.Drawing.Size(260, 21);
            this.butMeasureLineSettingDelete.TabIndex = 5;
            this.butMeasureLineSettingDelete.Text = "選択行削除";
            this.butMeasureLineSettingDelete.UseVisualStyleBackColor = true;
            this.butMeasureLineSettingDelete.Click += new System.EventHandler(this.butMeasureLineSettingDelete_Click);
            // 
            // butGenerate
            // 
            this.butGenerate.Location = new System.Drawing.Point(655, 303);
            this.butGenerate.Name = "butGenerate";
            this.butGenerate.Size = new System.Drawing.Size(276, 21);
            this.butGenerate.TabIndex = 10;
            this.butGenerate.Text = "出力";
            this.butGenerate.UseVisualStyleBackColor = true;
            this.butGenerate.Click += new System.EventHandler(this.butGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "譜面スタイル";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(711, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "判定レベル";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(711, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "TOTAL値";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(711, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "最終小節";
            // 
            // butImport
            // 
            this.butImport.Location = new System.Drawing.Point(655, 276);
            this.butImport.Name = "butImport";
            this.butImport.Size = new System.Drawing.Size(276, 21);
            this.butImport.TabIndex = 15;
            this.butImport.Text = "BPM取り込み";
            this.butImport.UseVisualStyleBackColor = true;
            this.butImport.Click += new System.EventHandler(this.butImport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 341);
            this.Controls.Add(this.butImport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butGenerate);
            this.Controls.Add(this.butMeasureLineSettingDelete);
            this.Controls.Add(this.butBPMRowDelete);
            this.Controls.Add(this.comJudgeLevel);
            this.Controls.Add(this.numLastMeasure);
            this.Controls.Add(this.numTotal);
            this.Controls.Add(this.gridMeasureLineSetting);
            this.Controls.Add(this.gridBPMSetting);
            this.Controls.Add(this.comChartStyle);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.butSelectData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridBPMSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMeasureLineSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLastMeasure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSelectData;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comChartStyle;
        private System.Windows.Forms.DataGridView gridBPMSetting;
        private System.Windows.Forms.DataGridView gridMeasureLineSetting;
        private System.Windows.Forms.DataGridViewTextBoxColumn measure;
        private System.Windows.Forms.DataGridViewComboBoxColumn style;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown numTotal;
        private System.Windows.Forms.NumericUpDown numLastMeasure;
        private System.Windows.Forms.ComboBox comJudgeLevel;
        private System.Windows.Forms.Button butBPMRowDelete;
        private System.Windows.Forms.Button butMeasureLineSettingDelete;
        private System.Windows.Forms.Button butGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn beat;
        private System.Windows.Forms.DataGridViewTextBoxColumn BPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn stop;
        private System.Windows.Forms.Button butImport;
    }
}