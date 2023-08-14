using System;
using System.Collections.Generic;

namespace ProcessorPipeline
{
	static class Source
	{
		static public List<string> SourceLines = new List<string>();

		static private int current = 0;

		/// <summary>
		/// Gives the first line to the Processor that has not been fetched yet.
		/// </summary>
		/// <returns>The line of code to be fetched.</returns>
		public static string FetchLine()
		{
			try
			{
				string line = SourceLines[current];

				current++;

				return line;
			}
			catch (ArgumentOutOfRangeException)
            {
				return null;
            }
		}

		public static void NewSource()
        {
			SourceLines = new List<string>();

			current = 0;
		}

		/// <summary>
		/// Adds stalls to the program so the pipeline can wait on an instruction dependency
		/// </summary>
		public static void InsertStalls()
        {
			string[] temp, previousInstructions;
			
			previousInstructions = SourceLines[0].Split('.', ' ', ',');

			for (int i = 1; i < SourceLines.Capacity - 1; i++)
            {
				//split on the period and whitespace so the addressing is separated
				temp = SourceLines[1].Split('.', ' ', ',');

				for(int j = 2; j < 4; i++)
                {
					//a dependency was found, place a NOP to enable a stall in the code
					if(temp[j] == previousInstructions[2])
                    {
						SourceLines.Insert(i, "NOP");
                    }

					else if(temp[j] == previousInstructions[3])
                    {
						SourceLines.Insert(i, "NOP");
					}
                }
			}
		}
	}
}
