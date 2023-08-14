using System;

namespace ProcessorPipeline
{
    /// <summary>
    /// Class which simulates one of the various stages of the pipeline.
    /// </summary>
    public class Station
    {
        private StationTypes typeOfStation;
        private int cyclesToWait;
        private Processor currentProcessor;
        private Instruction currentInstruction;
        private PipelineForm pipelineForm;

        /// <summary>
        /// Enumeration type containing different types of stations.
        /// </summary>
        public enum StationTypes
        {
            FETCH,
            DECODE1,
            DECODE2,
            OPERANDFETCH,
            EXECUTE,
            MEMORYACCESS,
            WRITEBACK
        }

        /// <summary>
        /// Parameterized constructor for the Station class.
        /// </summary>
        /// <param name="initialTypeOfStation">Initial type of the Station.</param>
        /// <param name="initialCyclesToWait">Initial number of cycles to wait before performing an action.</param>
        /// <param name="initialCurrentProcessor">Initial instance of the currently active Processor.</param>
        public Station(StationTypes initialTypeOfStation, int initialCyclesToWait, Processor initialCurrentProcessor, PipelineForm currentPipelineForm)
        {
            pipelineForm = currentPipelineForm;
            typeOfStation = initialTypeOfStation;
            cyclesToWait = initialCyclesToWait;
            currentProcessor = initialCurrentProcessor;
        }

        /// <summary>
        /// Getter and setter for the currentInstruction field.
        /// </summary>
        public Instruction CurrentInstruction
        {
            get 
            { 
                return currentInstruction; 
            }
            set 
            {
                currentInstruction = value; 
            }
        }

        /// <summary>
        /// Getter and setter for the cyclesToWait field.
        /// </summary>
        public int CyclesToWait
        {
            get
            {
                return cyclesToWait;
            }
            set
            {
                cyclesToWait = value;
            }
        }

        /// <summary>
        /// Simulates a single clock cycle in which an action
        /// can be performed or not.
        /// </summary>
        public void DoClockCycle()
        {
            if (cyclesToWait > 0) // If the value of cyclesToWait is greater than 0
            {
                cyclesToWait--; // Do nothing but wait and decrement the value of cyclesToWait
            }
            else
            {
                DoAction(); // Perform one of the various actions in the pipeline depending on the type of station
            }
        }

        /// <summary>
        /// Performs one of the various actions in the pipeline depending
        /// on the type of station.
        /// </summary>
        private void DoAction()
        {
            if (typeOfStation == StationTypes.FETCH) // If the value of typeOfStation is equal to FETCH
            {
                currentInstruction = new Instruction(); // Set currentInstruction to a new Instruction object

                currentInstruction.AssemblyLine = currentProcessor.Fetch(); // Fetch the next instruction from the source and set it to the current instruction

                if (currentInstruction.AssemblyLine != null) // If currentInstruction.AssemblyLine is not equal to null
                {
                    #region Add Instruction To FD1 Buffer
                    currentProcessor.FD1Buffer.Add(currentInstruction); // Add the current instruction into FD1Buffer

                    pipelineForm.FD1_ListBox.Items.Add(currentInstruction.AssemblyLine); // Add the current instruction into FD1_ListBox
                    #endregion

                    currentProcessor.IncrementProgramCounter(); // Increments the value of the program counter

                    pipelineForm.FetchTextBox.Text += (currentInstruction.AssemblyLine + Environment.NewLine); // Set the Text property of FetchTextBox to the current instruction

                    currentInstruction.clockCycleCounts[0] = currentProcessor.currentClockCycle.ToString ( );

                    /*
                    if (currentInstruction.AssemblyLine == "YD")
                    { 
                        currentInstruction.InstructionCycleCount.Append(string.Format("{0, -25}{1, 13}", currentInstruction.AssemblyLine, currentProcessor.currentClockCycle.ToString()));
                    }
                    else
                    {
                        currentInstruction.InstructionCycleCount.Append(string.Format("{0, -25}{1, -10}", currentInstruction.AssemblyLine, currentProcessor.currentClockCycle.ToString()));
                    }
                    */
                }
            }
            else if (typeOfStation == StationTypes.DECODE1) // If the value of typeOfStation is equal to DECODE1
            {
                if (!(currentProcessor.FD1Buffer.Count <= 0)) // If the count of FD1Buffer is not less than or equal to 0
                {
                    currentInstruction = currentProcessor.FD1Buffer[0]; // Fetch the current instruction from FD1Buffer

                    #region Remove Instruction From FD1 Buffer & Add Instruction To D1D2 Buffer
                    currentProcessor.FD1Buffer.RemoveAt(0); // Remove the current instruction from FD1Buffer

                    pipelineForm.FD1_ListBox.Items.RemoveAt(0); // Remove the current instruction from FD1_ListBox

                    currentProcessor.D1D2Buffer.Add(currentInstruction); // Add the current instruction into D1D2Buffer

                    pipelineForm.D1D2_ListBox.Items.Add(currentInstruction.AssemblyLine); // Add the current instruction into D1D2_ListBox
                    #endregion

                    currentProcessor.DecodeOne(currentInstruction); // Determine the type of the instruction

                    pipelineForm.DecodeOneTextBox.Text += (currentInstruction.DividedInst[0] + Environment.NewLine); // Set the Text property of DecodeOneTextBox to the current instruction mnemonic

                    currentInstruction.clockCycleCounts[1] = currentProcessor.currentClockCycle.ToString();

                    /*
                    if (currentInstruction.AssemblyLine == "YD")
                    {
                        currentInstruction.InstructionCycleCount.Append(string.Format("{0, 10}", currentProcessor.currentClockCycle.ToString()));
                    }
                    else
                    {

                        currentInstruction.InstructionCycleCount.Append(string.Format("{0, -15}", currentProcessor.currentClockCycle.ToString()));
                    }
                    */
                }
            }
            else if (typeOfStation == StationTypes.DECODE2) // If the value of typeOfStation is equal to DECODE2
            {
                if (!(currentProcessor.D1D2Buffer.Count <= 0)) // If the count of D1D2Buffer is not less than or equal to 0
                {
                    currentInstruction = currentProcessor.D1D2Buffer[0]; // Fetch the current instruction from D1D2Buffer

                    #region Remove Instruction From D1D2 Buffer & Add Instruction To D2OF Buffer
                    currentProcessor.D1D2Buffer.RemoveAt(0); // Remove the current instruction from D1D2Buffer

                    pipelineForm.D1D2_ListBox.Items.RemoveAt(0); // Remove the current instruction from D1D2_ListBox

                    currentProcessor.D2OFBuffer.Add(currentInstruction); // Add the current instruction into D2OFBuffer

                    pipelineForm.D2OF_ListBox.Items.Add(currentInstruction.AssemblyLine); // Add the current instruction into D2OF_ListBox
                    #endregion

                    if (!currentInstruction.noAddress)
                    {
                        currentProcessor.DecodeTwo(currentInstruction); // Determine the address mode of the instruction

                        pipelineForm.DecodeTwoTextBox.Text += (currentInstruction.DividedInst[1] + Environment.NewLine); // Set the text property of FetchTextBox to the current instruction address mode

                        currentInstruction.clockCycleCounts[2] = currentProcessor.currentClockCycle.ToString();

                        //currentInstruction.InstructionCycleCount.Append(string.Format("{0, -15}", currentProcessor.currentClockCycle.ToString()));
                    }
                }
            }
            else if (typeOfStation == StationTypes.OPERANDFETCH) // If the value of typeOfStation is equal to OPERANDFETCH
            {
                if (!(currentProcessor.D2OFBuffer.Count <= 0)) // If the count of D2OFBuffer is not less than or equal to 0
                {
                    currentInstruction = currentProcessor.D2OFBuffer[0]; // Fetch the current instruction from D2OFBuffer

                    #region Remove Instruction From D2OF Buffer & Add Instruction To OFE Buffer
                    currentProcessor.D2OFBuffer.RemoveAt(0); // Remove the current instruction from D2OFBuffer

                    pipelineForm.D2OF_ListBox.Items.RemoveAt(0); // Remove the current instruction from D2OF_ListBox

                    currentProcessor.OFEBuffer.Add(currentInstruction); // Add the current instruction into OFEBuffer

                    pipelineForm.OFE_ListBox.Items.Add(currentInstruction.AssemblyLine); // Add the current instruction into OFE_ListBox
                    #endregion

                    if (!currentInstruction.noAddress)
                    {
                        currentProcessor.OperandFetch(currentInstruction); // Fetch the operands of the instruction

                        pipelineForm.OperandFetchTextBox.Text += (currentInstruction.DividedInst[2] + ", " + currentInstruction.DividedInst[3] + Environment.NewLine); // Set the text property of OperandFetchTextBox to the current instruction operands

                        currentInstruction.clockCycleCounts[3] = currentProcessor.currentClockCycle.ToString();

                        //currentInstruction.InstructionCycleCount.Append(string.Format("{0, -15}", currentProcessor.currentClockCycle.ToString()));
                    }
                }
            }
            else if (typeOfStation == StationTypes.EXECUTE) // If the value of typeOfStation is equal to EXECUTE
            {
                if (!(currentProcessor.OFEBuffer.Count <= 0)) // If the count of OFEBuffer is not less than or equal to 0
                {
                    currentInstruction = currentProcessor.OFEBuffer[0]; // Fetch the current instruction from OFEBuffer

                    #region Remove Instruction From OFE Buffer & Add Instruction To EMA Buffer
                    currentProcessor.OFEBuffer.RemoveAt(0); // Remove the current instruction from OFEBuffer

                    pipelineForm.OFE_ListBox.Items.RemoveAt(0); // Remove the current instruction from OFE_ListBox

                    currentProcessor.EMABuffer.Add(currentInstruction); // Add the current instruction into EMABuffer

                    pipelineForm.EMA_ListBox.Items.Add(currentInstruction.AssemblyLine); // Add the current instruction into EMA_ListBox
                    #endregion

                    pipelineForm.ExecuteTextBox.Text += (currentInstruction.AssemblyLine + Environment.NewLine); // Set the text property of ExecuteTextBox to the current instruction

                    currentInstruction.clockCycleCounts[4] = currentProcessor.currentClockCycle.ToString();

                    /*
                    if (currentInstruction.AssemblyLine == "YD")
                    {
                        currentInstruction.InstructionCycleCount.Append(string.Format("{0, 47}", currentProcessor.currentClockCycle.ToString()));
                    }
                    else
                    {

                        currentInstruction.InstructionCycleCount.Append(string.Format("{0, -15}", currentProcessor.currentClockCycle.ToString()));
                    }
                    */
                }
            }
            else if(typeOfStation == StationTypes.MEMORYACCESS) // If the value of typeOfStation is equal to MEMORYACCESS
            {
                if (!(currentProcessor.EMABuffer.Count <= 0)) // If the count of EMABuffer is not less than or equal to 0
                {
                    currentInstruction = currentProcessor.EMABuffer[0]; // Fetch the current instruction from EMABuffer

                    #region Remove Instruction From EMA Buffer & Add Instruction To MAWB Buffer
                    currentProcessor.EMABuffer.RemoveAt(0); // Remove the current instruction from EMABuffer

                    pipelineForm.EMA_ListBox.Items.RemoveAt(0); // Remove the current instruction from EMA_ListBox

                    currentProcessor.MAWBBuffer.Add(currentInstruction); // Add the current instruction into MAWBBuffer

                    pipelineForm.MAWB_ListBox.Items.Add(currentInstruction.AssemblyLine); // Add the current instruction into MAWB_ListBox
                    #endregion

                    pipelineForm.MemoryAccessTextBox.Text += (currentInstruction.AssemblyLine + Environment.NewLine); // Set the text property of MemoryAccessTextBox to the current instruction

                    int tempClockCycle = (currentProcessor.currentClockCycle + currentProcessor.Execute(currentInstruction));

                    if (currentInstruction.AssemblyLine == "YD")
                    {
                        // Do nothing but skip to the next station
                    }
                    else
                    {
                        currentInstruction.clockCycleCounts[5] = tempClockCycle.ToString();

                        //currentInstruction.InstructionCycleCount.Append(string.Format("{0, -15}", tempClockCycle.ToString()));
                    }
                }
            }
            else if(typeOfStation == StationTypes.WRITEBACK) // If the value of typeOfStation is equal to WRITEBACK
            {
                if (!(currentProcessor.MAWBBuffer.Count <= 0)) // If the count of MAWBBuffer is not less than or equal to 0
                {
                    currentInstruction = currentProcessor.MAWBBuffer[0]; // Fetch the current instruction from MAWBBuffer

                    #region Remove Instruction From MAWB Buffer
                    currentProcessor.MAWBBuffer.RemoveAt(0); // Remove the current instruction from MAWBBuffer

                    pipelineForm.MAWB_ListBox.Items.RemoveAt(0); // Remove the current instruction from MAWB_ListBox
                    #endregion

                    int tempClockCycle = (currentProcessor.currentClockCycle + (currentProcessor.Execute(currentInstruction)));

                    if (currentInstruction.AssemblyLine == "YD")
                    {
                        // Do nothing but skip to the next station
                    }
                    else
                    {
                        currentInstruction.clockCycleCounts[6] = tempClockCycle.ToString();

                        //currentInstruction.InstructionCycleCount.Append(string.Format("{0, -15}", tempClockCycle.ToString()));
                    }

                    pipelineForm.ResultsTextBox.Text += (currentInstruction.DisplayInstruction() + Environment.NewLine); //place the stringbuilder of the info into the results box 

                    if (currentInstruction.DividedInst[0] == "YD")
                    {
                        pipelineForm.AtEndOfFile();
                    }
                }
            }
        }
    }
}