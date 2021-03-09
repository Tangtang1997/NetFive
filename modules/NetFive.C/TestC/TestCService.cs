using System;
using NetFive.C.Abstractions.TestC;

namespace NetFive.C.TestC
{
    public class TestCService:ITestCService
    {
        public void Say()
        {
            Console.WriteLine("C");
        }
    }
}