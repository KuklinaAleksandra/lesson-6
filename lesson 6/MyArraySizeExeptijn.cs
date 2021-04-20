using System;
using System.Runtime.Serialization;

namespace lesson_6
{
    [Serializable]
    internal class MyArraySizeExeptijn : Exception
    {
        public MyArraySizeExeptijn()
        {
        }

        public MyArraySizeExeptijn(string message) : base(message)
        {
        }

        public MyArraySizeExeptijn(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MyArraySizeExeptijn(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}