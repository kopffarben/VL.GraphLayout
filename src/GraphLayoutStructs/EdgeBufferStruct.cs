using System;
using System.Runtime.InteropServices;

namespace GraphLayoutStructs
{
    [StructLayout(LayoutKind.Explicit)]
    public struct EdgeBufferStruct
    {
        [FieldOffset(0)]
        public int fromIndex;
        [FieldOffset(4)]
        public int toIndex;
        [FieldOffset(8)]
        public float weight;
        public EdgeBufferStruct(int fromIndex, int toIndex, float weight)
        {
            this.fromIndex = fromIndex;
            this.toIndex = toIndex;
            this.weight = weight;
        }

        public void Split(out int fromIndex, out int toIndex, out float weight)
        {
            fromIndex = this.fromIndex;
            toIndex = this.toIndex;
            weight = this.weight;
        }
    }
}
