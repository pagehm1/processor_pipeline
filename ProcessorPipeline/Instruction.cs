using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessorPipeline
{
    public class Instruction
    {
        private bool Dependent { get; set; }

        private int Latency { get; set; }

        /// <summary>
        /// The Assembly instruction Broken up into pieces of required info
        /// 
        /// Positions
        /// ----------
        /// 0. mnemonic
        /// 1. addressing type
        /// 2. first operand/destination
        /// 3. second operand
        /// </summary>
        public string[] DividedInst { get; set; }

        public string AssemblyLine { get; set; }

        public bool noAddress { get; set; }

        public StringBuilder InstructionCycleCount{ get; set; }

        public List<string> clockCycleCounts = new List<string> (7) {"-", "-", "-", "-", "-", "-", "-"};

        public Instruction()
        {
            DividedInst = new string[4];
            Latency = 0;
            Dependent = false;
            InstructionCycleCount = new StringBuilder();
        }

        public string DisplayInstruction()
        {
            return String.Format("{0, -19}{1, -8}{2, -7}{3, -6}{4, -7}{5, -7}{6, -7}{7, -7}", AssemblyLine,
                clockCycleCounts[0].ToString(), clockCycleCounts[1].ToString(), clockCycleCounts[2].ToString(), 
                clockCycleCounts[3].ToString(), clockCycleCounts[4].ToString(), clockCycleCounts[5].ToString(), clockCycleCounts[6].ToString());
            
        }
    }
}
