using System.Collections;
using System.Collections.Generic;
using Boo.Lang.Environments;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class NewTestScript
    {
        // A Test behaves as an ordinary method
        [Test]
        public void NewTestScriptSimplePasses()
        {
            List<string> someStrings = new List<string>();
            someStrings.Add("My string!");
            someStrings.Add("My second string!");
            someStrings.RemoveAt(0);
            Assert.AreEqual(1, someStrings.Count);
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
