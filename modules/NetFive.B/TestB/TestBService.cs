using System;
using NetFive.A.Abstractions.TestA;
using NetFive.B.Abstractions.TestB;
using NetFive.C.Abstractions.TestC;

namespace NetFive.B.TestB
{
    public class TestBService : ITestBService
    {
        private readonly ITestAService _testAService;
        private readonly ITestCService _testCService;

        public TestBService(ITestAService testAService,ITestCService testCService)
        {
            _testAService = testAService;
            _testCService = testCService;
        }

        public void Say()
        {
            _testAService.Say();
            Console.WriteLine("B");
            _testCService.Say();
        }
    }
}