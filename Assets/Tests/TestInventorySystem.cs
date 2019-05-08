using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

namespace WgUnityPackages.IInventoryForUnity.Tests
{
    public class TestInventorySystem : MonoBehaviour
    {
        [ContextMenu("Test soldier")]
        public void TestSoldier()
        {
            Soldier soldier = new Soldier(){name = "Jablonsky"};
            Weapon weapon = new Gun(){weaponName = "a gun"};
            soldier.inventory.Put(weapon);
            Assert.AreEqual ( "Jablonsky",soldier.name );
            Assert.IsInstanceOf(typeof(Gun), soldier.inventory.GetFirstOrNull<Gun>());
            Assert.AreEqual(0, soldier.inventory.GetFirstOrNull<Gun>().Id);
            Knife knife = new Knife(){weaponName = "a knife" };
            soldier.inventory.Put(knife);
            Assert.IsInstanceOf(typeof(Knife), soldier.inventory.GetFirstOrNull<Knife>());
            Assert.AreEqual(1, soldier.inventory.GetFirstOrNull<Knife>().Id);

            Assert.AreEqual("a gun", soldier.inventory.GetFirstOrNull<Gun>().weaponName);
            Assert.AreEqual("a knife", soldier.inventory.GetFirstOrNull<Knife>().weaponName);

            Assert.AreEqual("a gun", soldier.inventory.GetFirstOrNull<Weapon>().weaponName);
        }
    }
}
