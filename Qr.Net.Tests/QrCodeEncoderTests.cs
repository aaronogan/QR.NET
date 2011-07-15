using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThoughtWorks.QRCode.Codec;

namespace Qr.Net.Tests
{
    [TestClass]
    public class QrCodeEncoderTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var encoder = new QRCodeEncoder();
            var content = "QR.NET https://github.com/aaronogan/QR.NET";

            var result = encoder.Encode(content);

            AssertMatrix(result);
        }

        private void AssertMatrix(bool[][] matrix)
        {
            for (int x = 0; x < expected.Length; x++)
            {
                for (int y = 0; y < expected[0].Length; y++)
                {
                    Assert.AreEqual<bool>(expected[x][y], matrix[x][y]);
                }
            }
        }

        private bool[][] expected = new bool[][]
        {
            new bool[] { true, true, true, true, true, true, true, false, true, true, true, false, true, false, true, true, true, false, true, false, false, true, true, false, true, false, false, true, true, false, false, true, false, false, false, false, true, false, true, true, true, true, true, true, true },
            new bool[] { true, false, false, false, false, false, true, false, false, false, true, false, false, true, false, true, true, false, true, true, true, true, false, true, false, true, false, true, false, true, false, true, false, false, false, true, false, false, true, false, false, false, false, false, true },
            new bool[] { true, false, true, true, true, false, true, false, false, true, false, true, true, false, true, false, false, false, true, true, true, true, true, false, false, false, false, true, true, true, false, true, true, true, false, true, false, false, true, false, true, true, true, false, true },
            new bool[] { true, false, true, true, true, false, true, false, false, true, true, true, true, false, false, true, false, false, false, true, false, true, true, false, true, true, false, true, true, false, true, true, true, false, false, true, true, false, true, false, true, true, true, false, true },
            new bool[] { true, false, true, true, true, false, true, false, true, false, true, false, true, false, true, false, false, false, false, false, true, true, true, true, true, false, true, true, true, true, false, true, false, true, true, true, true, false, true, false, true, true, true, false, true },
            new bool[] { true, false, false, false, false, false, true, false, false, true, true, false, false, false, false, true, true, true, false, false, true, false, false, false, true, false, true, true, true, false, true, false, true, true, false, false, false, false, true, false, false, false, false, false, true },
            new bool[] { true, true, true, true, true, true, true, false, true, false, true, false, true, false, true, false, true, false, true, false, true, false, true, false, true, false, true, false, true, false, true, false, true, false, true, false, true, false, true, true, true, true, true, true, true },
            new bool[] { false, false, false, false, false, false, false, false, true, false, false, false, false, true, true, false, false, true, true, true, true, false, false, false, true, false, false, true, false, false, true, false, true, true, true, true, false, false, false, false, false, false, false, false, false },
            new bool[] { true, false, false, true, true, true, true, true, true, true, false, true, false, false, false, false, true, true, false, true, true, true, true, true, true, false, true, false, true, false, false, true, true, false, true, true, false, true, true, false, true, false, false, false, true },
            new bool[] { true, true, true, false, true, true, false, true, false, false, false, true, false, true, true, true, true, false, false, true, false, false, false, true, false, false, true, true, false, false, false, false, true, true, true, true, false, false, true, true, true, false, true, true, true },
            new bool[] { true, true, true, true, false, false, true, false, false, true, true, true, false, true, true, true, true, false, true, true, false, true, false, true, false, false, false, true, false, true, true, true, false, true, true, true, true, true, false, true, true, true, true, false, true },
            new bool[] { true, false, true, true, true, false, false, true, true, true, false, false, true, true, true, true, true, false, false, false, true, true, true, false, false, true, false, false, true, true, true, true, false, false, true, false, true, true, true, true, false, false, false, true, true },
            new bool[] { false, true, true, false, true, false, true, false, true, false, false, false, true, false, true, true, true, true, false, false, false, true, false, true, false, false, false, false, true, false, false, true, true, false, false, true, false, true, false, true, true, false, false, false, false },
            new bool[] { true, false, false, true, false, true, false, true, true, false, false, false, false, true, true, true, true, true, true, true, true, false, true, true, true, false, false, false, false, false, true, true, false, true, false, false, true, false, false, true, true, true, true, false, false },
            new bool[] { false, false, false, false, true, true, true, true, false, false, true, true, true, false, true, false, true, false, true, true, true, true, false, true, true, false, false, true, false, true, true, true, false, true, false, true, false, true, true, false, true, true, true, false, false },
            new bool[] { false, false, true, true, false, false, false, true, false, true, false, true, false, true, true, true, false, true, true, false, false, true, false, false, true, false, false, true, false, false, false, true, true, true, false, true, false, true, false, true, false, true, true, false, false },
            new bool[] { false, false, true, false, true, true, true, true, false, false, false, true, false, false, false, false, false, true, true, false, false, false, false, false, false, false, true, false, false, true, true, true, true, false, true, false, true, false, true, true, false, false, true, true, false },
            new bool[] { false, false, false, true, true, true, false, true, true, false, true, true, true, false, true, false, false, true, false, true, true, false, true, false, false, true, false, true, true, true, true, true, false, false, true, true, false, true, true, false, false, false, false, false, true },
            new bool[] { true, true, false, false, true, false, true, true, false, true, false, true, true, false, false, false, true, true, true, true, false, true, false, false, true, true, false, true, false, true, false, true, true, true, false, false, false, false, true, false, false, false, false, false, false },
            new bool[] { false, true, true, true, false, true, false, true, true, true, true, false, false, true, false, true, true, false, true, false, false, true, false, false, true, false, false, false, true, true, true, true, false, true, false, false, true, true, false, true, false, true, true, false, false },
            new bool[] { false, false, true, true, true, true, true, true, true, true, false, false, true, true, false, true, false, false, false, false, true, true, true, true, true, false, true, false, true, false, false, true, false, true, true, false, true, true, true, true, true, false, true, true, true },
            new bool[] { true, false, false, true, true, false, false, false, true, false, false, true, true, true, true, false, false, true, false, true, true, false, false, false, true, false, true, false, false, true, false, true, true, false, true, false, true, false, false, false, true, false, false, false, true },
            new bool[] { true, true, false, true, true, false, true, false, true, false, true, true, false, true, false, false, false, true, true, true, true, false, true, false, true, true, true, true, false, false, false, false, true, false, true, true, true, false, true, false, true, false, true, false, true },
            new bool[] { false, true, false, false, true, false, false, false, true, true, true, false, false, false, false, true, true, true, true, false, true, false, false, false, true, false, true, false, true, false, true, false, false, true, false, true, true, false, false, false, true, true, true, true, true },
            new bool[] { false, true, true, true, true, true, true, true, true, true, false, false, true, true, true, true, false, true, false, false, true, true, true, true, true, true, true, false, false, true, false, true, false, false, false, false, true, true, true, true, true, true, false, false, false },
            new bool[] { false, true, false, true, true, false, false, true, false, false, false, true, true, false, false, false, false, true, true, true, true, false, false, false, true, true, false, false, false, true, true, true, true, false, false, false, false, true, true, true, true, false, false, true, true },
            new bool[] { false, true, false, false, true, true, true, false, true, true, true, true, false, false, false, false, true, true, false, true, false, false, false, false, false, true, true, false, true, true, false, true, false, false, false, false, true, true, false, true, false, true, true, true, false },
            new bool[] { false, true, false, true, true, false, false, false, true, false, true, true, true, false, false, false, false, true, true, true, true, false, false, true, true, false, false, false, false, true, true, true, true, false, false, false, false, true, true, false, true, true, true, true, true },
            new bool[] { true, true, true, true, false, false, true, false, false, false, false, true, true, true, false, true, false, false, true, true, true, true, false, false, false, false, true, true, false, false, true, true, true, true, false, true, false, false, true, false, false, false, false, true, true },
            new bool[] { false, false, false, true, true, false, false, true, true, false, false, false, false, true, true, false, true, true, true, true, true, false, false, false, false, true, true, true, true, false, false, false, true, true, true, false, false, true, true, true, true, false, false, false, false },
            new bool[] { true, false, true, true, false, true, true, false, true, true, false, true, false, false, false, true, false, true, true, false, true, true, false, true, false, false, false, false, true, true, false, false, false, true, true, true, false, false, false, false, true, true, false, true, false },
            new bool[] { false, false, true, false, false, true, false, false, false, true, true, true, true, false, false, false, true, true, false, false, false, true, true, true, true, false, false, false, false, true, true, true, true, false, false, true, true, false, false, false, false, true, true, false, true },
            new bool[] { false, false, false, false, true, true, true, false, false, false, true, false, true, true, false, true, true, false, true, false, false, false, true, false, true, true, false, false, false, false, true, true, true, false, false, false, true, true, false, false, false, false, true, false, true },
            new bool[] { true, false, false, false, false, false, false, false, false, true, false, false, false, true, true, false, false, true, true, true, true, false, false, false, false, true, false, false, true, true, false, true, true, false, false, false, false, true, true, true, false, true, false, false, false },
            new bool[] { false, false, false, false, true, false, true, true, false, false, false, false, true, false, true, false, true, true, true, true, false, false, true, true, false, false, false, true, false, false, true, true, false, false, true, false, true, true, true, true, false, false, false, true, false },
            new bool[] { false, true, true, true, true, false, false, false, true, false, false, true, false, true, true, false, true, true, true, true, true, false, true, true, true, false, true, true, true, true, false, false, false, true, true, false, false, false, true, true, false, false, false, true, true },
            new bool[] { true, false, false, true, true, false, true, true, true, true, false, false, true, true, true, true, false, true, false, true, true, true, true, true, true, true, false, true, true, false, false, false, true, true, false, true, true, true, true, true, true, true, true, true, false },
            new bool[] { false, false, false, false, false, false, false, false, true, false, true, true, false, false, true, true, true, false, false, false, true, false, false, false, true, false, false, true, false, true, false, false, true, false, true, true, true, false, false, false, true, true, true, false, false },
            new bool[] { true, true, true, true, true, true, true, false, true, true, false, true, false, true, false, true, false, false, false, false, true, false, true, false, true, true, false, false, true, true, false, true, true, true, false, false, true, false, true, false, true, true, false, false, true },
            new bool[] { true, false, false, false, false, false, true, false, true, true, false, true, true, false, false, false, false, true, true, true, true, false, false, false, true, false, true, false, false, true, true, false, true, false, false, true, true, false, false, false, true, false, false, true, true },
            new bool[] { true, false, true, true, true, false, true, false, true, false, true, true, true, true, false, true, false, false, true, false, true, true, true, true, true, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, false, false, false, true },
            new bool[] { true, false, true, true, true, false, true, false, true, true, false, false, false, true, true, false, false, false, false, true, true, false, true, true, false, true, false, false, false, false, false, true, true, true, true, false, false, true, true, false, false, false, false, false, false },
            new bool[] { true, false, true, true, true, false, true, false, false, false, true, false, false, false, true, true, true, true, false, false, true, true, true, false, false, true, true, false, false, true, false, false, true, false, true, true, true, false, true, false, true, true, false, false, false },
            new bool[] { true, false, false, false, false, false, true, false, false, false, true, true, true, true, true, false, false, false, false, true, true, true, true, false, false, false, true, false, true, false, false, true, true, true, true, false, false, true, true, true, false, true, false, false, false },
            new bool[] { true, true, true, true, true, true, true, false, true, true, false, false, true, true, true, true, false, true, false, false, true, false, false, true, false, true, false, true, false, true, false, false, true, true, true, true, false, false, false, true, false, false, false, false, true }
        };
    }
}