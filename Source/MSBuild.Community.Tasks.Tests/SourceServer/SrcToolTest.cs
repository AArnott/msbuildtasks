using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Build.Utilities;
using MSBuild.Community.Tasks.SourceServer;
using NUnit.Framework;

namespace MSBuild.Community.Tasks.Tests.SourceServer
{
    [TestFixture]
    public class SrcToolTest
    {
        [SetUp]
        public void Setup()
        {
            //TODO: NUnit setup
        }

        [TearDown]
        public void TearDown()
        {
            //TODO: NUnit TearDown
        }

        [Test]
        public void SourceOnly()
        {
            var task = new SrcTool();
            task.BuildEngine = new MockBuild();

            var pdfFile = new TaskItem(Path.GetFullPath("MSBuild.Community.Tasks.pdb"));

            task.SourceOnly = true;
            task.PdbFile = pdfFile;
            //task.ToolPath = @"C:\Program Files\Debugging Tools for Windows (x64)\srcsrv";

            var result = task.Execute();

            Assert.IsTrue(result);
        }

        [Test]
        public void CountOnly()
        {
            var task = new SrcTool();
            task.BuildEngine = new MockBuild();

            var pdfFile = new TaskItem(Path.GetFullPath("MSBuild.Community.Tasks.pdb"));

            task.CountOnly = true;
            task.PdbFile = pdfFile;
            task.ToolPath = @"C:\Program Files\Debugging Tools for Windows (x64)\srcsrv";

            var result = task.Execute();

            Assert.IsTrue(result);
        }
    }
}
