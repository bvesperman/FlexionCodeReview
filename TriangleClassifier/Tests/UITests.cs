
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tests
{
    [TestClass()]
    public class UITests
    {
        [TestMethod(),Timeout(5000)]
        public void ConsoleBasicFunctionallity()
        {
            string testdata = 
@"1
1.0
1.1
";
            StringWriter consoleOutput = new StringWriter();
            StringReader consoleInput = new StringReader(testdata);
            Console.SetOut(consoleOutput);
            Console.SetIn(consoleInput);
      
            TriangleConsoleUI.Program.Main(new string[] { });
            string go = consoleOutput.ToString();

          
        }
    }
}
