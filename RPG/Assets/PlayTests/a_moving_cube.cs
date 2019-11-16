using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class a_moving_cube
    {
        // A Test behaves as an ordinary method
        [Test]
        public void NewTestScriptSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator moving_forward_changes_position()
        {
            // ARRANGE
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = Vector3.zero;
            
            // ACT
            for (int i = 0; i < 10; i++)
            {
                cube.transform.position += Vector3.forward;
                yield return null; // new WaitForSeconds(0.5f);
                
                // ASSERT
                Assert.AreEqual(i + 1,cube.transform.position.z);
            }
            
            // ASSERT
            
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
