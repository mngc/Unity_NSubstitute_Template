using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;
using NSubstitute;

namespace Tests
{
    public class MyTestClass
    {
        // A Test behaves as an ordinary method
        [Test]
        public void NewTestScriptSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        [Test]
        public void MockMyInterfaceTest()
        {
            int inputValue = 1;
            int expectecValue = 10;

            var mockedInterface = Substitute.For<MyInterface>();
            mockedInterface.ThisFunctionDoesNothing(inputValue).Returns(10);
            
            Assert.AreEqual(expectecValue, mockedInterface.ThisFunctionDoesNothing(inputValue));
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

    public interface MyInterface
    {
        int ThisFunctionDoesNothing(int value);
    }
}