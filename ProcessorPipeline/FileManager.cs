using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProcessorPipeline
{
	/// <summary>
	/// Class that provides methods for working with file I/O
	/// </summary>
	static class FileManager
	{
		// Setup path to the config file path
		static private string PROJECT_PATH = Directory.GetParent (Environment.CurrentDirectory).Parent.FullName;
		static private string CONFIG_PATH = PROJECT_PATH + @"\Files\config.txt";


		static public void ReadConfigFile ( )
		{
			if (File.Exists (CONFIG_PATH))
			{
				using (StreamReader configFile = new StreamReader (CONFIG_PATH))
				{
					string line;

					#region Parse Config Values
					line = configFile.ReadLine ( );
					ConfigProperties.AddLatency = Int32.Parse (Regex.Match (line, @"\d+").Value);

					line = configFile.ReadLine ( );
					ConfigProperties.SubLatency = Int32.Parse (Regex.Match (line, @"\d+").Value);

					line = configFile.ReadLine ( );
					ConfigProperties.AndLatency = Int32.Parse (Regex.Match (line, @"\d+").Value);

					line = configFile.ReadLine ( );
					ConfigProperties.OrLatency = Int32.Parse (Regex.Match (line, @"\d+").Value);

					line = configFile.ReadLine ( );
					ConfigProperties.XorLatency = Int32.Parse (Regex.Match (line, @"\d+").Value);

					line = configFile.ReadLine ( );
					ConfigProperties.NegLatency = Int32.Parse (Regex.Match (line, @"\d+").Value);

					line = configFile.ReadLine ( );
					ConfigProperties.NotLatency = Int32.Parse (Regex.Match (line, @"\d+").Value);

					line = configFile.ReadLine ( );
					ConfigProperties.UbrLatency = Int32.Parse (Regex.Match (line, @"\d+").Value);

					line = configFile.ReadLine ( );
					ConfigProperties.YdLatency = Int32.Parse (Regex.Match (line, @"\d+").Value);

					line = configFile.ReadLine ( );
					ConfigProperties.LdLatency = Int32.Parse (Regex.Match (line, @"\d+").Value);

					line = configFile.ReadLine ( );
					ConfigProperties.StLatency = Int32.Parse (Regex.Match (line, @"\d+").Value);
					#endregion

				}
			}
		}

		static public void WriteConfigFile ( )
		{
			using (StreamWriter configFile = new StreamWriter (CONFIG_PATH))
			{
				#region Write Config File Lines
				configFile.WriteLine ("add: " + ConfigProperties.AddLatency);
				configFile.WriteLine ("sub: " + ConfigProperties.SubLatency);
				configFile.WriteLine ("and: " + ConfigProperties.AndLatency);
				configFile.WriteLine ("or: " + ConfigProperties.OrLatency);
				configFile.WriteLine ("xor: " + ConfigProperties.XorLatency);
				configFile.WriteLine ("neg: " + ConfigProperties.NegLatency);
				configFile.WriteLine ("not: " + ConfigProperties.NotLatency);
				configFile.WriteLine ("ubr: " + ConfigProperties.UbrLatency);
				configFile.WriteLine ("yd: " + ConfigProperties.YdLatency);
				configFile.WriteLine ("ld: " + ConfigProperties.LdLatency);
				configFile.WriteLine ("st: " + ConfigProperties.StLatency);
				#endregion

			}
		}

		static public void ReadTraceFile (string path)
		{
			if (File.Exists (path))
			{
				using (StreamReader traceFile = new StreamReader (path))
				{
					string line;

					while (!traceFile.EndOfStream)
					{
						line = traceFile.ReadLine ( );
						Source.SourceLines.Add (line);
					}

				}
			}
		}

		static public void WriteTraceFile (string path, string data)
		{
			if (File.Exists (path))
			{
				using (StreamWriter traceFile = new StreamWriter (path))
				{
					traceFile.Write (data);

				}
			}
		}
	}
}
