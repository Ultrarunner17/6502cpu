using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpu
{
    public class Cpu
    {
        /// <summary>
        /// Instruction register
        /// </summary>
        public byte IR { get; set; }

        /// <summary>
        /// Accumulator register
        /// </summary>
        public byte A { get; set; }

        /// <summary>
        /// X register
        /// </summary>
        public byte X { get; set; }

        /// <summary>
        /// Y register
        /// </summary>
        public byte Y { get; set; }

        /// <summary>
        /// Processor status
        /// </summary>
        public byte P { get; set; }

        /// <summary>
        /// Program counter register
        /// </summary>
        public UInt16 PC { get; set; }

        /// <summary>
        /// Stack pointer register
        /// </summary>
        public byte S { get; set; }

        public Cpu()
        {
            Reset();
        }

        public void Reset()
        {
            IR = 0;
            A = 0;
            X = 0;
            Y = 0;
            P = 0;
            PC = 0xFFFC;
            S = 0;
        }
    }
}
