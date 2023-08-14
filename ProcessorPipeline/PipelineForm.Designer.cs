
namespace ProcessorPipeline
{
    partial class PipelineForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PipelineForm));
			this.StepButton = new System.Windows.Forms.Button();
			this.StartButton = new System.Windows.Forms.Button();
			this.StopButton = new System.Windows.Forms.Button();
			this.ClockTimer = new System.Windows.Forms.Timer(this.components);
			this.MenuStripOne = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ConfigurationSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ListBoxOne = new System.Windows.Forms.ListBox();
			this.OpenTraceFile = new System.Windows.Forms.Button();
			this.ProgramCounterTextBox = new System.Windows.Forms.TextBox();
			this.ProgramCounterLabel = new System.Windows.Forms.Label();
			this.FetchTextBox = new System.Windows.Forms.TextBox();
			this.FetchLabel = new System.Windows.Forms.Label();
			this.DecodeOneTextBox = new System.Windows.Forms.TextBox();
			this.DecodeOneLabel = new System.Windows.Forms.Label();
			this.DecodeTwoTextBox = new System.Windows.Forms.TextBox();
			this.DecodeTwoLabel = new System.Windows.Forms.Label();
			this.PipelinePictureBox = new System.Windows.Forms.PictureBox();
			this.OperandFetchTextBox = new System.Windows.Forms.TextBox();
			this.OperandFetchLabel = new System.Windows.Forms.Label();
			this.ExecuteTextBox = new System.Windows.Forms.TextBox();
			this.ExecuteLabel = new System.Windows.Forms.Label();
			this.MemoryAccessTextBox = new System.Windows.Forms.TextBox();
			this.MemoryAccessLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ResultsTextBox = new System.Windows.Forms.TextBox();
			this.EditTraceFile = new System.Windows.Forms.Button();
			this.HazardsLabel = new System.Windows.Forms.Label();
			this.HazardTextBox = new System.Windows.Forms.TextBox();
			this.OFE_ListBox = new System.Windows.Forms.ListBox();
			this.D2OF_ListBox = new System.Windows.Forms.ListBox();
			this.D1D2_ListBox = new System.Windows.Forms.ListBox();
			this.FD1_ListBox = new System.Windows.Forms.ListBox();
			this.EMA_ListBox = new System.Windows.Forms.ListBox();
			this.MAWB_ListBox = new System.Windows.Forms.ListBox();
			this.FD1BufferLabel = new System.Windows.Forms.Label();
			this.D1D2BufferLabel = new System.Windows.Forms.Label();
			this.D2OFBufferLabel = new System.Windows.Forms.Label();
			this.OFEBufferLabel = new System.Windows.Forms.Label();
			this.EMABufferLabel = new System.Windows.Forms.Label();
			this.MAWBBufferLabel = new System.Windows.Forms.Label();
			this.MenuStripOne.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PipelinePictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// StepButton
			// 
			this.StepButton.Enabled = false;
			this.StepButton.Location = new System.Drawing.Point(187, 450);
			this.StepButton.Name = "StepButton";
			this.StepButton.Size = new System.Drawing.Size(75, 50);
			this.StepButton.TabIndex = 11;
			this.StepButton.Text = "Step";
			this.StepButton.UseVisualStyleBackColor = true;
			this.StepButton.Click += new System.EventHandler(this.StepButton_Click);
			// 
			// StartButton
			// 
			this.StartButton.Enabled = false;
			this.StartButton.Location = new System.Drawing.Point(12, 450);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(75, 50);
			this.StartButton.TabIndex = 14;
			this.StartButton.Text = "Start";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// StopButton
			// 
			this.StopButton.Enabled = false;
			this.StopButton.Location = new System.Drawing.Point(100, 450);
			this.StopButton.Name = "StopButton";
			this.StopButton.Size = new System.Drawing.Size(75, 50);
			this.StopButton.TabIndex = 16;
			this.StopButton.Text = "Stop";
			this.StopButton.UseVisualStyleBackColor = true;
			this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
			// 
			// ClockTimer
			// 
			this.ClockTimer.Interval = 1000;
			this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
			// 
			// MenuStripOne
			// 
			this.MenuStripOne.BackColor = System.Drawing.SystemColors.ControlLight;
			this.MenuStripOne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
			this.MenuStripOne.Location = new System.Drawing.Point(0, 0);
			this.MenuStripOne.Name = "MenuStripOne";
			this.MenuStripOne.Size = new System.Drawing.Size(1351, 24);
			this.MenuStripOne.TabIndex = 26;
			this.MenuStripOne.Text = "menuStrip1";
			// 
			// FileToolStripMenuItem
			// 
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigurationSettingsToolStripMenuItem});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.FileToolStripMenuItem.Text = "File";
			// 
			// ConfigurationSettingsToolStripMenuItem
			// 
			this.ConfigurationSettingsToolStripMenuItem.Name = "ConfigurationSettingsToolStripMenuItem";
			this.ConfigurationSettingsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
			this.ConfigurationSettingsToolStripMenuItem.Text = "Configuration Settings";
			this.ConfigurationSettingsToolStripMenuItem.Click += new System.EventHandler(this.ConfigurationSettingsToolStripMenuItem_Click);
			// 
			// ListBoxOne
			// 
			this.ListBoxOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ListBoxOne.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ListBoxOne.FormattingEnabled = true;
			this.ListBoxOne.ItemHeight = 19;
			this.ListBoxOne.Location = new System.Drawing.Point(12, 46);
			this.ListBoxOne.Name = "ListBoxOne";
			this.ListBoxOne.Size = new System.Drawing.Size(250, 306);
			this.ListBoxOne.TabIndex = 27;
			// 
			// OpenTraceFile
			// 
			this.OpenTraceFile.BackColor = System.Drawing.Color.LightGreen;
			this.OpenTraceFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OpenTraceFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OpenTraceFile.Location = new System.Drawing.Point(12, 364);
			this.OpenTraceFile.Name = "OpenTraceFile";
			this.OpenTraceFile.Size = new System.Drawing.Size(117, 75);
			this.OpenTraceFile.TabIndex = 28;
			this.OpenTraceFile.Text = "Open Trace File";
			this.OpenTraceFile.UseVisualStyleBackColor = false;
			this.OpenTraceFile.Click += new System.EventHandler(this.OpenTraceFile_Click);
			// 
			// ProgramCounterTextBox
			// 
			this.ProgramCounterTextBox.Location = new System.Drawing.Point(325, 245);
			this.ProgramCounterTextBox.Multiline = true;
			this.ProgramCounterTextBox.Name = "ProgramCounterTextBox";
			this.ProgramCounterTextBox.Size = new System.Drawing.Size(75, 80);
			this.ProgramCounterTextBox.TabIndex = 30;
			this.ProgramCounterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ProgramCounterLabel
			// 
			this.ProgramCounterLabel.AutoSize = true;
			this.ProgramCounterLabel.BackColor = System.Drawing.Color.Gainsboro;
			this.ProgramCounterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ProgramCounterLabel.Location = new System.Drawing.Point(318, 225);
			this.ProgramCounterLabel.Name = "ProgramCounterLabel";
			this.ProgramCounterLabel.Size = new System.Drawing.Size(88, 15);
			this.ProgramCounterLabel.TabIndex = 31;
			this.ProgramCounterLabel.Text = "Program Counter";
			this.ProgramCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FetchTextBox
			// 
			this.FetchTextBox.Location = new System.Drawing.Point(435, 245);
			this.FetchTextBox.Multiline = true;
			this.FetchTextBox.Name = "FetchTextBox";
			this.FetchTextBox.Size = new System.Drawing.Size(75, 80);
			this.FetchTextBox.TabIndex = 32;
			this.FetchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FetchLabel
			// 
			this.FetchLabel.AutoSize = true;
			this.FetchLabel.BackColor = System.Drawing.Color.Gainsboro;
			this.FetchLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.FetchLabel.Location = new System.Drawing.Point(454, 225);
			this.FetchLabel.Name = "FetchLabel";
			this.FetchLabel.Size = new System.Drawing.Size(36, 15);
			this.FetchLabel.TabIndex = 33;
			this.FetchLabel.Text = "Fetch";
			this.FetchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DecodeOneTextBox
			// 
			this.DecodeOneTextBox.Location = new System.Drawing.Point(573, 245);
			this.DecodeOneTextBox.Multiline = true;
			this.DecodeOneTextBox.Name = "DecodeOneTextBox";
			this.DecodeOneTextBox.Size = new System.Drawing.Size(75, 120);
			this.DecodeOneTextBox.TabIndex = 34;
			this.DecodeOneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// DecodeOneLabel
			// 
			this.DecodeOneLabel.AutoSize = true;
			this.DecodeOneLabel.BackColor = System.Drawing.Color.Gainsboro;
			this.DecodeOneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DecodeOneLabel.Location = new System.Drawing.Point(575, 225);
			this.DecodeOneLabel.Name = "DecodeOneLabel";
			this.DecodeOneLabel.Size = new System.Drawing.Size(70, 15);
			this.DecodeOneLabel.TabIndex = 35;
			this.DecodeOneLabel.Text = "Decode One";
			this.DecodeOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DecodeTwoTextBox
			// 
			this.DecodeTwoTextBox.Location = new System.Drawing.Point(693, 240);
			this.DecodeTwoTextBox.Multiline = true;
			this.DecodeTwoTextBox.Name = "DecodeTwoTextBox";
			this.DecodeTwoTextBox.Size = new System.Drawing.Size(75, 120);
			this.DecodeTwoTextBox.TabIndex = 36;
			this.DecodeTwoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// DecodeTwoLabel
			// 
			this.DecodeTwoLabel.AutoSize = true;
			this.DecodeTwoLabel.BackColor = System.Drawing.Color.Gainsboro;
			this.DecodeTwoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DecodeTwoLabel.Location = new System.Drawing.Point(695, 220);
			this.DecodeTwoLabel.Name = "DecodeTwoLabel";
			this.DecodeTwoLabel.Size = new System.Drawing.Size(71, 15);
			this.DecodeTwoLabel.TabIndex = 37;
			this.DecodeTwoLabel.Text = "Decode Two";
			this.DecodeTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PipelinePictureBox
			// 
			this.PipelinePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PipelinePictureBox.Image")));
			this.PipelinePictureBox.Location = new System.Drawing.Point(310, 45);
			this.PipelinePictureBox.Name = "PipelinePictureBox";
			this.PipelinePictureBox.Size = new System.Drawing.Size(1000, 445);
			this.PipelinePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PipelinePictureBox.TabIndex = 29;
			this.PipelinePictureBox.TabStop = false;
			// 
			// OperandFetchTextBox
			// 
			this.OperandFetchTextBox.Location = new System.Drawing.Point(820, 245);
			this.OperandFetchTextBox.Multiline = true;
			this.OperandFetchTextBox.Name = "OperandFetchTextBox";
			this.OperandFetchTextBox.Size = new System.Drawing.Size(75, 120);
			this.OperandFetchTextBox.TabIndex = 38;
			this.OperandFetchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// OperandFetchLabel
			// 
			this.OperandFetchLabel.AutoSize = true;
			this.OperandFetchLabel.BackColor = System.Drawing.Color.Gainsboro;
			this.OperandFetchLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OperandFetchLabel.Location = new System.Drawing.Point(818, 225);
			this.OperandFetchLabel.Name = "OperandFetchLabel";
			this.OperandFetchLabel.Size = new System.Drawing.Size(80, 15);
			this.OperandFetchLabel.TabIndex = 39;
			this.OperandFetchLabel.Text = "Operand Fetch";
			this.OperandFetchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ExecuteTextBox
			// 
			this.ExecuteTextBox.Location = new System.Drawing.Point(965, 250);
			this.ExecuteTextBox.Multiline = true;
			this.ExecuteTextBox.Name = "ExecuteTextBox";
			this.ExecuteTextBox.Size = new System.Drawing.Size(110, 100);
			this.ExecuteTextBox.TabIndex = 40;
			this.ExecuteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ExecuteLabel
			// 
			this.ExecuteLabel.AutoSize = true;
			this.ExecuteLabel.BackColor = System.Drawing.Color.Gainsboro;
			this.ExecuteLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ExecuteLabel.Location = new System.Drawing.Point(995, 230);
			this.ExecuteLabel.Name = "ExecuteLabel";
			this.ExecuteLabel.Size = new System.Drawing.Size(48, 15);
			this.ExecuteLabel.TabIndex = 41;
			this.ExecuteLabel.Text = "Execute";
			this.ExecuteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MemoryAccessTextBox
			// 
			this.MemoryAccessTextBox.Location = new System.Drawing.Point(1135, 230);
			this.MemoryAccessTextBox.Multiline = true;
			this.MemoryAccessTextBox.Name = "MemoryAccessTextBox";
			this.MemoryAccessTextBox.Size = new System.Drawing.Size(75, 125);
			this.MemoryAccessTextBox.TabIndex = 42;
			this.MemoryAccessTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// MemoryAccessLabel
			// 
			this.MemoryAccessLabel.AutoSize = true;
			this.MemoryAccessLabel.BackColor = System.Drawing.Color.Gainsboro;
			this.MemoryAccessLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MemoryAccessLabel.Location = new System.Drawing.Point(1130, 210);
			this.MemoryAccessLabel.Name = "MemoryAccessLabel";
			this.MemoryAccessLabel.Size = new System.Drawing.Size(84, 15);
			this.MemoryAccessLabel.TabIndex = 43;
			this.MemoryAccessLabel.Text = "Memory Access";
			this.MemoryAccessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(226, 523);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 20);
			this.label1.TabIndex = 53;
			this.label1.Text = "Results";
			// 
			// ResultsTextBox
			// 
			this.ResultsTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ResultsTextBox.Location = new System.Drawing.Point(310, 515);
			this.ResultsTextBox.Multiline = true;
			this.ResultsTextBox.Name = "ResultsTextBox";
			this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.ResultsTextBox.Size = new System.Drawing.Size(511, 109);
			this.ResultsTextBox.TabIndex = 54;
			// 
			// EditTraceFile
			// 
			this.EditTraceFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.EditTraceFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditTraceFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EditTraceFile.Location = new System.Drawing.Point(133, 364);
			this.EditTraceFile.Name = "EditTraceFile";
			this.EditTraceFile.Size = new System.Drawing.Size(129, 75);
			this.EditTraceFile.TabIndex = 55;
			this.EditTraceFile.Text = "Edit Trace File";
			this.EditTraceFile.UseVisualStyleBackColor = false;
			this.EditTraceFile.Click += new System.EventHandler(this.EditTraceFile_Click);
			// 
			// HazardsLabel
			// 
			this.HazardsLabel.AutoSize = true;
			this.HazardsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HazardsLabel.Location = new System.Drawing.Point(859, 523);
			this.HazardsLabel.Name = "HazardsLabel";
			this.HazardsLabel.Size = new System.Drawing.Size(69, 20);
			this.HazardsLabel.TabIndex = 56;
			this.HazardsLabel.Text = "Hazards";
			// 
			// HazardTextBox
			// 
			this.HazardTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HazardTextBox.Location = new System.Drawing.Point(947, 515);
			this.HazardTextBox.Multiline = true;
			this.HazardTextBox.Name = "HazardTextBox";
			this.HazardTextBox.Size = new System.Drawing.Size(363, 109);
			this.HazardTextBox.TabIndex = 57;
			// 
			// OFE_ListBox
			// 
			this.OFE_ListBox.FormattingEnabled = true;
			this.OFE_ListBox.Location = new System.Drawing.Point(905, 100);
			this.OFE_ListBox.Name = "OFE_ListBox";
			this.OFE_ListBox.Size = new System.Drawing.Size(30, 381);
			this.OFE_ListBox.TabIndex = 58;
			// 
			// D2OF_ListBox
			// 
			this.D2OF_ListBox.FormattingEnabled = true;
			this.D2OF_ListBox.Location = new System.Drawing.Point(780, 100);
			this.D2OF_ListBox.Name = "D2OF_ListBox";
			this.D2OF_ListBox.Size = new System.Drawing.Size(30, 381);
			this.D2OF_ListBox.TabIndex = 59;
			// 
			// D1D2_ListBox
			// 
			this.D1D2_ListBox.FormattingEnabled = true;
			this.D1D2_ListBox.Location = new System.Drawing.Point(655, 100);
			this.D1D2_ListBox.Name = "D1D2_ListBox";
			this.D1D2_ListBox.Size = new System.Drawing.Size(30, 381);
			this.D1D2_ListBox.TabIndex = 60;
			// 
			// FD1_ListBox
			// 
			this.FD1_ListBox.FormattingEnabled = true;
			this.FD1_ListBox.Location = new System.Drawing.Point(525, 100);
			this.FD1_ListBox.Name = "FD1_ListBox";
			this.FD1_ListBox.Size = new System.Drawing.Size(30, 381);
			this.FD1_ListBox.TabIndex = 61;
			// 
			// EMA_ListBox
			// 
			this.EMA_ListBox.FormattingEnabled = true;
			this.EMA_ListBox.Location = new System.Drawing.Point(1080, 100);
			this.EMA_ListBox.Name = "EMA_ListBox";
			this.EMA_ListBox.Size = new System.Drawing.Size(30, 381);
			this.EMA_ListBox.TabIndex = 62;
			// 
			// MAWB_ListBox
			// 
			this.MAWB_ListBox.FormattingEnabled = true;
			this.MAWB_ListBox.Location = new System.Drawing.Point(1218, 100);
			this.MAWB_ListBox.Name = "MAWB_ListBox";
			this.MAWB_ListBox.Size = new System.Drawing.Size(30, 381);
			this.MAWB_ListBox.TabIndex = 63;
			// 
			// FD1BufferLabel
			// 
			this.FD1BufferLabel.AutoSize = true;
			this.FD1BufferLabel.BackColor = System.Drawing.Color.Gainsboro;
			this.FD1BufferLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.FD1BufferLabel.Location = new System.Drawing.Point(510, 485);
			this.FD1BufferLabel.Name = "FD1BufferLabel";
			this.FD1BufferLabel.Size = new System.Drawing.Size(60, 15);
			this.FD1BufferLabel.TabIndex = 64;
			this.FD1BufferLabel.Text = "FD1 Buffer";
			this.FD1BufferLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// D1D2BufferLabel
			// 
			this.D1D2BufferLabel.AutoSize = true;
			this.D1D2BufferLabel.BackColor = System.Drawing.Color.Gainsboro;
			this.D1D2BufferLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.D1D2BufferLabel.Location = new System.Drawing.Point(637, 485);
			this.D1D2BufferLabel.Name = "D1D2BufferLabel";
			this.D1D2BufferLabel.Size = new System.Drawing.Size(68, 15);
			this.D1D2BufferLabel.TabIndex = 65;
			this.D1D2BufferLabel.Text = "D1D2 Buffer";
			this.D1D2BufferLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// D2OFBufferLabel
			// 
			this.D2OFBufferLabel.AutoSize = true;
			this.D2OFBufferLabel.BackColor = System.Drawing.Color.Gainsboro;
			this.D2OFBufferLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.D2OFBufferLabel.Location = new System.Drawing.Point(763, 485);
			this.D2OFBufferLabel.Name = "D2OFBufferLabel";
			this.D2OFBufferLabel.Size = new System.Drawing.Size(68, 15);
			this.D2OFBufferLabel.TabIndex = 66;
			this.D2OFBufferLabel.Text = "D2OF Buffer";
			this.D2OFBufferLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// OFEBufferLabel
			// 
			this.OFEBufferLabel.AutoSize = true;
			this.OFEBufferLabel.BackColor = System.Drawing.Color.Gainsboro;
			this.OFEBufferLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OFEBufferLabel.Location = new System.Drawing.Point(890, 485);
			this.OFEBufferLabel.Name = "OFEBufferLabel";
			this.OFEBufferLabel.Size = new System.Drawing.Size(61, 15);
			this.OFEBufferLabel.TabIndex = 67;
			this.OFEBufferLabel.Text = "OFE Buffer";
			this.OFEBufferLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// EMABufferLabel
			// 
			this.EMABufferLabel.AutoSize = true;
			this.EMABufferLabel.BackColor = System.Drawing.Color.Gainsboro;
			this.EMABufferLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.EMABufferLabel.Location = new System.Drawing.Point(1065, 485);
			this.EMABufferLabel.Name = "EMABufferLabel";
			this.EMABufferLabel.Size = new System.Drawing.Size(63, 15);
			this.EMABufferLabel.TabIndex = 68;
			this.EMABufferLabel.Text = "EMA Buffer";
			this.EMABufferLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MAWBBufferLabel
			// 
			this.MAWBBufferLabel.AutoSize = true;
			this.MAWBBufferLabel.BackColor = System.Drawing.Color.Gainsboro;
			this.MAWBBufferLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MAWBBufferLabel.Location = new System.Drawing.Point(1195, 485);
			this.MAWBBufferLabel.Name = "MAWBBufferLabel";
			this.MAWBBufferLabel.Size = new System.Drawing.Size(74, 15);
			this.MAWBBufferLabel.TabIndex = 69;
			this.MAWBBufferLabel.Text = "MAWB Buffer";
			this.MAWBBufferLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PipelineForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1351, 648);
			this.Controls.Add(this.MAWBBufferLabel);
			this.Controls.Add(this.EMABufferLabel);
			this.Controls.Add(this.OFEBufferLabel);
			this.Controls.Add(this.D2OFBufferLabel);
			this.Controls.Add(this.D1D2BufferLabel);
			this.Controls.Add(this.FD1BufferLabel);
			this.Controls.Add(this.MAWB_ListBox);
			this.Controls.Add(this.EMA_ListBox);
			this.Controls.Add(this.FD1_ListBox);
			this.Controls.Add(this.D1D2_ListBox);
			this.Controls.Add(this.D2OF_ListBox);
			this.Controls.Add(this.OFE_ListBox);
			this.Controls.Add(this.HazardTextBox);
			this.Controls.Add(this.HazardsLabel);
			this.Controls.Add(this.EditTraceFile);
			this.Controls.Add(this.ResultsTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.MemoryAccessLabel);
			this.Controls.Add(this.MemoryAccessTextBox);
			this.Controls.Add(this.ExecuteLabel);
			this.Controls.Add(this.ExecuteTextBox);
			this.Controls.Add(this.OperandFetchLabel);
			this.Controls.Add(this.OperandFetchTextBox);
			this.Controls.Add(this.DecodeTwoLabel);
			this.Controls.Add(this.DecodeTwoTextBox);
			this.Controls.Add(this.DecodeOneLabel);
			this.Controls.Add(this.DecodeOneTextBox);
			this.Controls.Add(this.FetchLabel);
			this.Controls.Add(this.FetchTextBox);
			this.Controls.Add(this.ProgramCounterLabel);
			this.Controls.Add(this.ProgramCounterTextBox);
			this.Controls.Add(this.PipelinePictureBox);
			this.Controls.Add(this.OpenTraceFile);
			this.Controls.Add(this.ListBoxOne);
			this.Controls.Add(this.StopButton);
			this.Controls.Add(this.StartButton);
			this.Controls.Add(this.StepButton);
			this.Controls.Add(this.MenuStripOne);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.MenuStripOne;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PipelineForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Processor Pipeline";
			this.MenuStripOne.ResumeLayout(false);
			this.MenuStripOne.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PipelinePictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StepButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.MenuStrip MenuStripOne;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConfigurationSettingsToolStripMenuItem;
        private System.Windows.Forms.ListBox ListBoxOne;
        private System.Windows.Forms.Button OpenTraceFile;
        private System.Windows.Forms.PictureBox PipelinePictureBox;
        private System.Windows.Forms.Label ProgramCounterLabel;
        private System.Windows.Forms.Label FetchLabel;
        public System.Windows.Forms.TextBox ProgramCounterTextBox;
        public System.Windows.Forms.TextBox FetchTextBox;
        public System.Windows.Forms.TextBox DecodeOneTextBox;
        private System.Windows.Forms.Label DecodeOneLabel;
        public System.Windows.Forms.TextBox DecodeTwoTextBox;
        private System.Windows.Forms.Label DecodeTwoLabel;
        public System.Windows.Forms.TextBox OperandFetchTextBox;
        private System.Windows.Forms.Label OperandFetchLabel;
        public System.Windows.Forms.TextBox ExecuteTextBox;
        private System.Windows.Forms.Label ExecuteLabel;
        public System.Windows.Forms.TextBox MemoryAccessTextBox;
        private System.Windows.Forms.Label MemoryAccessLabel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox ResultsTextBox;
		private System.Windows.Forms.Button EditTraceFile;
        private System.Windows.Forms.Label HazardsLabel;
        public System.Windows.Forms.TextBox HazardTextBox;
        public System.Windows.Forms.ListBox OFE_ListBox;
        public System.Windows.Forms.ListBox D2OF_ListBox;
        public System.Windows.Forms.ListBox D1D2_ListBox;
        public System.Windows.Forms.ListBox FD1_ListBox;
        public System.Windows.Forms.ListBox EMA_ListBox;
        public System.Windows.Forms.ListBox MAWB_ListBox;
        private System.Windows.Forms.Label FD1BufferLabel;
        private System.Windows.Forms.Label D1D2BufferLabel;
        private System.Windows.Forms.Label D2OFBufferLabel;
        private System.Windows.Forms.Label OFEBufferLabel;
        private System.Windows.Forms.Label EMABufferLabel;
        private System.Windows.Forms.Label MAWBBufferLabel;
    }
}