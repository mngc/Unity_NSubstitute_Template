using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class PlayerModelTests
    {
        public class InitPlayerTests
        {
            [Test]
            public void InitPlayer_Sets_CurrentHealth_To_MaxHealth()
            {
                const int maxHealth = 100;
                var playerModel = new GameObject().AddComponent<PlayerModel>();
                
                playerModel.InitPlayer(maxHealth);
                
                Assert.AreEqual(maxHealth, playerModel.CurrentHealth);
            }
        }
    }
}
