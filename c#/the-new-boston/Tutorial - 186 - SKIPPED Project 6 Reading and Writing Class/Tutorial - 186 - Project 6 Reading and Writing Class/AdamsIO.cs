using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // binary reader

namespace AdamsIO
{
    public class Reader : BaseIO // inheriting from BaseIO
    {
        /// <summary>
        /// Create a reader to read a file
        /// </summary>
        /// <param name="path">The path to the file to read</param>
        public Reader(string path) // ctor tab x2
        {
            br = new BinaryReader(File.OpenRead(path)));
            byteOrder = this.ByteOrder.BigEndian;      // make sure it's the one from this class by using this
        }
        /// <summary>
        /// Create a reader to read a file
        /// </summary>
        /// <param name="path">The path to the file to read</param>
        ///  <param name="bo">The order of the bytes to read</param>
        public Reader(string path, ByteOrder bo)
        {
            br = new BinaryReader(File.OpenRead(path));
            this.byteOrder = bo;
        }
        BinaryReader br;

        /// <summary>
        /// The position to read at.
        /// </summary>
        public long position // 64 bit singned
        {
            get { return br.BaseStream.Position; }
            set { br.BaseStream.Position = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>each time it reads it goes over by one</returns>
        public byte ReadByte()
        {
            return br.ReadByte(); // each time it reads it goes over by one
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>convert into signed byte</returns>
        public sbyte ReadSByte()
        {
            return (sbyte)br.ReadByte(); // convert into signed byte
        }

        public short ReadInt16()
        {
            short myShort = br.ReadInt16(); // 78, 65 would be read as 65, 78 unless we reverse it
            if (byteOrder == ByteOrder.BigEndian)
            {
                byte[] buffer = BitConverter.GetBytes(myShort); // turns short into byte array
                Array.Reverse(buffer); // reverses byte array
                myShort = BitConverter.ToInt16(buffer, 0);  // now convert it back into a short, now it reads 78, 65
            }
            return myShort;
        }
    }
    public abstract class BaseIO 
    {
        /// <summary>
        /// The order of the bytes both read and written
        /// </summary>
        public enum ByteOrder
        {
            BigEndian,
            LittleEndian
        }

        protected ByteOrder byteOrder; // protected so we can use it in this class and the derived class
    }
}
