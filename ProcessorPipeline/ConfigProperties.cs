using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessorPipeline
{
	static class ConfigProperties
	{
		public static int AddLatency { get; set; }
		public static int SubLatency { get; set; }
		public static int AndLatency { get; set; }
		public static int OrLatency { get; set; }
		public static int XorLatency { get; set; }
		public static int NegLatency { get; set; }
		public static int NotLatency { get; set; }
		public static int UbrLatency { get; set; }
		public static int YdLatency { get; set; }
		public static int LdLatency { get; set; }
		public static int StLatency { get; set; }
		

	}
}
