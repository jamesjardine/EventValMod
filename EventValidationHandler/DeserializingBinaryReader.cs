using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace JSI.SecurityTools.EventValidationHandler
{
    class DeserializingBinaryReader : BinaryReader
    {
        public DeserializingBinaryReader(Stream input) : base(input)
        { }
        protected override void Dispose(bool disposing)
        {
           
        }
        public int Read7BitEncodedInt() => base.Read7BitEncodedInt();
    }
}
