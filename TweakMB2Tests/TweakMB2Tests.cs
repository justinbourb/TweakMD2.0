using Microsoft.VisualStudio.TestTools.UnitTesting;
using TweakMB2;
using HelperFunctions;
using System.IO;
using System;

namespace TweakMB2Tests
{
    [TestClass]
    public class TweakMB2Tests
    {
        [TestMethod]
        public void multilineTest()
        {
            //multilinetoSinglelieFunc converts a multiline string to single line
            string testString = @"One
two
three";
            string expectedResult = "One two three";
            Assert.AreEqual(HelperFunctions.HelperFunctions.multilineToSinglelineFunc(testString), expectedResult);
        }
        [TestMethod]
        public void multispaceTest()
        {
            //multilinetoSinglelieFunc converts a "  " to " "
            string testString = "One  two  three";
            string expectedResult = "One two three";
            Assert.AreEqual(HelperFunctions.HelperFunctions.multilineToSinglelineFunc(testString), expectedResult);
        }
        [TestMethod]
        public void openFileFuncTest()
        {
            //openFileFunc opens and reads a file
            string path = "C:\\git_local\\testfile.txt";
            string expectedResult = "One two three";
            //if file doesn't exist, create test file to read
            //File.Create will overwrite existing files, don't want to destroy something accidentally
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();
                StreamWriter file = new StreamWriter(path);
                file.Write(expectedResult);
                file.Close();
                //Assert.AreEqual was failing to compare these strings
                expectedResult += Environment.NewLine;
                bool results = HelperFunctions.HelperFunctions.openFileFunc(path).Equals(expectedResult);
                //the test
                Assert.IsTrue(results);
                //clean up test file
                FileInfo file2 = new FileInfo(path);
                file2.Delete();
            }
        }

    }
}
