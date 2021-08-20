using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayerPlayModeTest
    {
        public class PlayerUpdateTests
        {
            [UnityTest]
            public IEnumerator Update_Decrease_Player_Health_By_One()
            {
                var playerModel = new GameObject().AddComponent<PlayerModel>();
                playerModel.InitPlayer(100);

                // skip one frame.
                yield return null;

                Assert.AreEqual(99, playerModel.CurrentHealth);
            }
        }
    }
}
