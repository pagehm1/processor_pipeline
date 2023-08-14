using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessorPipeline
{
	public partial class TraceForm : Form
	{
		string traceFilePath;

		public TraceForm (string traceFile)
		{
			InitializeComponent ( );
			traceFilePath = traceFile;
			
		}

		private void btnSaveTrace_Click (object sender, EventArgs e)
		{
			try
			{
				FileManager.WriteTraceFile (traceFilePath, tbTraceData.Text);
				MessageBox.Show ("File saved successfully.", "Saved .dat File");
			}
			catch (Exception ex)
			{
				MessageBox.Show (ex.Message, "Error");
			}
				
		}

		private void TraceForm_Load (object sender, EventArgs e)
		{
			Source.NewSource ( );
			tbTraceData.Clear ( );
			FileManager.ReadTraceFile (traceFilePath);
			PopulateTraceBox ( );
		}

		private void PopulateTraceBox ( )
		{
			foreach (string line in Source.SourceLines)
			{
				tbTraceData.AppendText (line);
				tbTraceData.AppendText (Environment.NewLine);
			}
		}
	}
}
