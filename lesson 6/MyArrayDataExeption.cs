using System;
using System.Runtime.Serialization;

namespace lesson_6
{
    [Serializable]

   
    internal class MyArrayDataExeption : Exception
    {
        int row;
            int column;
        public MyArrayDataExeption(int row, int column)
        {
            this.row = row;
            this.column = column;

        }

        public MyArrayDataExeption(string message) : base(message)
        {
        }

        public MyArrayDataExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MyArrayDataExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}