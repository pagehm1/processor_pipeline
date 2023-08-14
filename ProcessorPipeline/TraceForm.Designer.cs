
namespace ProcessorPipeline
{
	partial class TraceForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ( );
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( )
		{
			this.tbTraceData = new System.Windows.Forms.TextBox();
			this.btnSaveTrace = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbTraceData
			// 
			this.tbTraceData.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTraceData.Location = new System.Drawing.Point(28, 23);
			this.tbTraceData.Multiline = true;
			this.tbTraceData.Name = "tbTraceData";
			this.tbTraceData.Size = new System.Drawing.Size(448, 346);
			this.tbTraceData.TabIndex = 0;
			// 
			// btnSaveTrace
			// 
			this.btnSaveTrace.BackColor = System.Drawing.Color.LightGreen;
			this.btnSaveTrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveTrace.Location = new System.Drawing.Point(172, 379);
			this.btnSaveTrace.Name = "btnSaveTrace";
			this.btnSaveTrace.Size = new System.Drawing.Size(161, 54);
			this.btnSaveTrace.TabIndex = 1;
			this.btnSaveTrace.Text = "Save File: trace.dat";
			this.btnSaveTrace.UseVisualStyleBackColor = false;
			this.btnSaveTrace.Click += new System.EventHandler(this.btnSaveTrace_Click);
			// 
			// TraceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 445);
			this.Controls.Add(this.btnSaveTrace);
			this.Controls.Add(this.tbTraceData);
			this.Name = "TraceForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Trace File";
			this.Load += new System.EventHandler(this.TraceForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbTraceData;
		private System.Windows.Forms.Button btnSaveTrace;
	}
}