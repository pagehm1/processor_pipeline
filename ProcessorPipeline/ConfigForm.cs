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
	public partial class ConfigForm : Form
	{
		public ConfigForm ( )
		{
			InitializeComponent ( );
		}

		private void ConfigForm_Load (object sender, EventArgs e)
		{
			#region Set TextBox Values
			tbAdd.Text = ConfigProperties.AddLatency.ToString ( );
			tbSub.Text = ConfigProperties.SubLatency.ToString ( );
			tbAnd.Text = ConfigProperties.AndLatency.ToString ( );
			tbOr.Text = ConfigProperties.OrLatency.ToString ( );
			tbXor.Text = ConfigProperties.XorLatency.ToString ( );
			tbNeg.Text = ConfigProperties.NegLatency.ToString ( );
			tbNot.Text = ConfigProperties.NotLatency.ToString ( );
			tbUbr.Text = ConfigProperties.UbrLatency.ToString ( );
			tbYd.Text = ConfigProperties.YdLatency.ToString ( );
			tbLd.Text = ConfigProperties.LdLatency.ToString ( );
			tbSt.Text = ConfigProperties.StLatency.ToString ( );
			#endregion

			this.Refresh ( );
		}

		private void btnOpenConfig_Click (object sender, EventArgs e)
		{
			FileManager.ReadConfigFile ( );
			this.ConfigForm_Load (sender, e);
		}

		private void btnSaveConfig_Click (object sender, EventArgs e)
		{
			#region Set Config Properties
			ConfigProperties.AddLatency = Int32.Parse(tbAdd.Text);
			ConfigProperties.SubLatency = Int32.Parse(tbSub.Text);
			ConfigProperties.AndLatency = Int32.Parse(tbAnd.Text);
			ConfigProperties.OrLatency = Int32.Parse(tbOr.Text);
			ConfigProperties.XorLatency = Int32.Parse(tbXor.Text);
			ConfigProperties.NegLatency = Int32.Parse(tbNeg.Text);
			ConfigProperties.NotLatency = Int32.Parse(tbNot.Text);
			ConfigProperties.UbrLatency = Int32.Parse(tbUbr.Text);
			ConfigProperties.YdLatency = Int32.Parse(tbYd.Text);
			ConfigProperties.LdLatency = Int32.Parse(tbLd.Text);
			ConfigProperties.StLatency = Int32.Parse(tbSt.Text);
			#endregion

			FileManager.WriteConfigFile ( );
		}
	}
}
