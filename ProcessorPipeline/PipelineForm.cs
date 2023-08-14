using System;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace ProcessorPipeline
{
    public partial class PipelineForm : Form
    {
        private Processor simulatedProcessor;

		public string TraceFilePath { get; set; }

		public PipelineForm()
        {
            InitializeComponent();
            string projectPath = Directory.GetParent (Environment.CurrentDirectory).Parent.FullName;
            TraceFilePath = projectPath + @"\Files\trace.dat";
        }

        public void AtEndOfFile()
        {
            StartButton.Enabled = false;
            StopButton.Enabled = false;
            StepButton.Enabled = false;

            HazardTextBox.Text += " " + simulatedProcessor.dataHazardCount.ToString();

            ClockTimer.Stop();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StepButton.Enabled = false;

            ClockTimer.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StepButton.Enabled = true;

            ClockTimer.Stop();
        }

        private void StepButton_Click(object sender, EventArgs e)
        {
            simulatedProcessor.DoPipelineCycle();
        }

        private void OpenTraceFile_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = true;
            StopButton.Enabled = true;
            StepButton.Enabled = true;
            
            using (OpenFileDialog openFile = new OpenFileDialog())
			{
                openFile.Filter = "dat files (*.dat)|*.dat";

                if (openFile.ShowDialog ( ) == DialogResult.OK)
				{
                    TraceFilePath = openFile.FileName;
				}
			}
            
            Source.NewSource();

            ListBoxOne.Items.Clear();

            ClearAllTextBoxes();

            FileManager.ReadTraceFile(TraceFilePath);

            PopulateListBox();

            simulatedProcessor = new Processor (this);

            PopulateResultsBox();
            PopulateHazardsBox();
        }

        private void ConfigurationSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();

            configForm.ShowDialog();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            simulatedProcessor.DoPipelineCycle();
        }

        private void PopulateListBox()
        {
            foreach (string line in Source.SourceLines)
            {
                ListBoxOne.Items.Add(line);
            }
        }

        private void ClearAllTextBoxes()
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Text = "";
            }
        }

        private void PopulateResultsBox()
        {

            ResultsTextBox.Text = "Instruction      Fetch    D1    D2    OF    Exec.   Mem.    W.B." + Environment.NewLine;
            ResultsTextBox.Text += "------------------------------------------------------------------" + Environment.NewLine;
        }

		private void EditTraceFile_Click (object sender, EventArgs e)
		{
            TraceForm traceForm = new TraceForm (TraceFilePath);

            traceForm.ShowDialog ( );
        }

        private void PopulateHazardsBox()
        {
            HazardTextBox.Text = "Data Dependencies: ";
        }
	}
}