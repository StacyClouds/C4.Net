using System;

namespace C4.Net.Client.Api.Tests
{
    public class TestFailedException : Exception
    {

        public TestFailedException()
        {
        }
        
        public TestFailedException(string message) : base(message)
        {
        }
        
    }
}