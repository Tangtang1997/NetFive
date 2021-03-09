using System;
using NetFive.A.Abstractions.TestA;

namespace NetFive.A.TestA
{
    public class TestAService:ITestAService
    {
        public void Say()
        {
            Console.WriteLine("A");
        }
    }
}