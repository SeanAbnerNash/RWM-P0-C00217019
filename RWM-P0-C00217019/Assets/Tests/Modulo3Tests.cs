using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Modulo3Test
    {
        // A Test behaves as an ordinary method
        [Test]
        public void Modulo3TestSimple()
        {

            int[] initial = { 3, 957, 2,-1,1 };
            initial = Modulo3.modulo3(initial);
            int[] expected = { 0, 0, 2,-1,1 };

            CollectionAssert.AreEqual(expected, initial);
        }



    }
}
