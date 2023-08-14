using System.Collections.Generic;
using System.Linq; 
using System.Windows.Forms;

namespace ProcessorPipeline
{
    /// <summary>
    /// Simulates a seven stage pipeline that can handle superscalar and potentially more
    /// features such as out of order execution, branch prediction, and hazard detection.
    /// </summary>
    public class Processor
    {
        public int currentClockCycle = 1;
        public bool checkForHazard = false;
        public List<Station> ProcessorPipelineOne = new List<Station>(7);
        public List<Station> ProcessorPipelineTwo = new List<Station>(7);
        public List<Instruction> FD1Buffer = new List<Instruction>();
        public List<Instruction> D1D2Buffer = new List<Instruction>();
        public List<Instruction> D2OFBuffer = new List<Instruction>();
        public List<Instruction> OFEBuffer = new List<Instruction>();
        public List<Instruction> EMABuffer = new List<Instruction>();
        public List<Instruction> MAWBBuffer = new List<Instruction>();
        private PipelineForm currentPipelineForm;

        #region Getters & Setters

        public bool BadInstruction { get; set; }
        public int ProgramCounter { get; set; }

        //counts how many hazards we have run into while running.
        //we can make multiple counters for different hazards
        public int dataHazardCount { get; set; }
        public object Controls { get; private set; }
        #endregion

        /// <summary>
        /// Parameterized constructor for the Processor class.
        /// </summary>
        public Processor(PipelineForm currentPipelineForm)
        {
            this.currentPipelineForm = currentPipelineForm;

            BadInstruction = false;

            InitializePipeline(); // Initialize the pipeline
        }

        /// <summary>
        /// Fetches the next instruction from the source.
        /// </summary>
        /// <returns>Instruction that was fetched from the source.</returns>
        public string Fetch()
		{
            string result = Source.FetchLine();

            return result;
		}

        /// <summary>
        /// Determines the type of the instruction.
        /// </summary>
        public void DecodeOne(Instruction instruction)
        {
            //instruction types that need an addressing mode
            string[] addressTrue = { "ADD", "SUB", "AND", "OR", "XOR", "NEG", "NOT", "LD", "ST" };

            //instruction types that do not need addressing mode
            string[] addressNotTrue = { "UBR", "YD" };

            //split on the period so the first part of the mnemonic is separated
            string[] temp = instruction.AssemblyLine.Split('.');

            instruction.DividedInst[0] = temp[0];

            //check to see where the instruction lies
            if(addressTrue.Contains(instruction.DividedInst[0]))
            {
                instruction.noAddress = false;
            }
            else if(addressNotTrue.Contains(instruction.DividedInst[0]))
            {
                instruction.noAddress = true;
            }
            else
            {
                BadInstruction = true;
            }
        }

        /// <summary>
        /// Determines the address mode of the instruction.
        /// </summary>
        public void DecodeTwo(Instruction instruction)
        {
            //all the types of addressing that can occur
            //I - immediate value
            //M - memory value
            //R - register
            string[] addressTypes = { "I", "M", "R" };

            //split on the period and whitespace so the addressing is separated
            string[] temp = instruction.AssemblyLine.Split('.', ' ');

            instruction.DividedInst[1] = temp[1].ToUpper();

            if (!addressTypes.Contains(instruction.DividedInst[1]))
            {
                BadInstruction = true;
            }
        }

        /// <summary>
        /// Fetches the operands of the instruction.
        /// </summary>
        public void OperandFetch(Instruction instruction)
        {
            //instruction types that do not need addressing mode
            string[] addressNotTrue = { "UBR", "YD" };

            //split on the period and whitespace so the addressing is separated
            string[] temp = instruction.AssemblyLine.Split('.', ' ', ',');
            
            if(temp[0] == "YD")
            {
                // Do nothing
            }
            else if(temp[0] == "UBR")
            {
                instruction.DividedInst[2] = temp[1];
            }
            else if ( (temp[0] == "NOT") || (temp[0] == "NEG") )
			{
                instruction.DividedInst[2] = temp[1];
                instruction.DividedInst[3] = temp[2];
			}
            else
            {
                instruction.DividedInst[2] = temp[2];
                instruction.DividedInst[3] = temp[4];
            }

            checkForHazard = true;
        }

        /// <summary>
        /// Fetches the execution latency count for the instruction.
        /// Will also need to add to latency and stall the pipeline if the 
        /// instruction requires something from the previous instruction
        /// </summary>
        public int Execute(Instruction instruction)
        {
            switch (instruction.DividedInst[0])
            {
                case "ADD":
                    return ConfigProperties.AddLatency;
                case "SUB":
                    return ConfigProperties.SubLatency;
                case "AND":
                    return ConfigProperties.AndLatency;
                case "OR":
                    return ConfigProperties.OrLatency;
                case "XOR":
                    return ConfigProperties.XorLatency;
                case "NEG":
                    return ConfigProperties.NegLatency;
                case "NOT":
                    return ConfigProperties.NotLatency;
                case "LD":
                    return ConfigProperties.LdLatency;
                case "ST":
                    return ConfigProperties.StLatency;
                case "UBR":
                    return ConfigProperties.UbrLatency;
                case "YD":
                    return ConfigProperties.YdLatency;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Increments the value of the program counter.
        /// </summary>
        public void IncrementProgramCounter()
        {
            ProgramCounter += 2; // Add 2 to the value of ProgramCounter

            currentPipelineForm.ProgramCounterTextBox.Text = ProgramCounter.ToString("X"); // Set the text property of ProgramCounterTextBox to the value of ProgramCounter as a hexadecimal value
        }

        /// <summary>
        /// Simulates a single clock cycle within the pipeline.
        /// </summary>
        public void DoPipelineCycle()
        {
            ClearTextBoxes();

            for (int i = 0; i < ProcessorPipelineOne.Count; i++)
            {
                ProcessorPipelineOne[i].DoClockCycle(); // Give the station at the current index a clock cycle to perform an action or not
                ProcessorPipelineTwo[i].DoClockCycle(); // Give the station at the current index a clock cycle to perform an action or not
            }

            if (checkForHazard)
            {
                DetectDataHazard(ProcessorPipelineOne[3].CurrentInstruction, ProcessorPipelineTwo[3].CurrentInstruction);
                //DetectDataHazard (ProcessorPipelineOne[4].CurrentInstruction, ProcessorPipelineOne[3].CurrentInstruction);
            }

            if (BadInstruction)
            {
                MessageBox.Show ("There was a bad instruction. Please fix your code.");

                currentPipelineForm.AtEndOfFile ( );   
            }

            checkForHazard = false;

            currentClockCycle++;
        }

        /// <summary>
        /// Initializes the pipeline.
        /// </summary>
        public void InitializePipeline()
        {
            for (int i = 0; i < 7; i++)
            {
                ProcessorPipelineOne.Add (new Station((Station.StationTypes)i, i, this, currentPipelineForm)); // Create and stagger out the various stages of the pipeline
                ProcessorPipelineTwo.Add(new Station((Station.StationTypes)i, i, this, currentPipelineForm)); // Create and stagger out the various stages of the pipeline
            }
        }

        public void DetectDataHazard(Instruction pipelineOneInstructionToCheck, Instruction pipelineTwoInstructionToCheck)
        {
            if (pipelineOneInstructionToCheck == null || pipelineTwoInstructionToCheck == null)
			{
                return;
			}
            
            if (pipelineOneInstructionToCheck.DividedInst[2] != null)
            {
                if (pipelineOneInstructionToCheck.DividedInst[2] == pipelineTwoInstructionToCheck.DividedInst[2])
                {
                    ProcessorPipelineTwo[4].CyclesToWait = 1;
                    ProcessorPipelineTwo[5].CyclesToWait = 2;
                    ProcessorPipelineTwo[6].CyclesToWait = 3;

                    dataHazardCount++;
                }
                else if (pipelineOneInstructionToCheck.DividedInst[2] == pipelineTwoInstructionToCheck.DividedInst[3])
                {
                    ProcessorPipelineTwo[4].CyclesToWait = 1;
                    ProcessorPipelineTwo[5].CyclesToWait = 2;
                    ProcessorPipelineTwo[6].CyclesToWait = 3;

                    dataHazardCount++;
                }
            }
        }

        private void ClearTextBoxes()
        {
            currentPipelineForm.FetchTextBox.Text = "";
            currentPipelineForm.DecodeOneTextBox.Text = "";
            currentPipelineForm.DecodeTwoTextBox.Text = "";
            currentPipelineForm.OperandFetchTextBox.Text = "";
            currentPipelineForm.ExecuteTextBox.Text = "";
            currentPipelineForm.MemoryAccessTextBox.Text = "";
        }
    }
}