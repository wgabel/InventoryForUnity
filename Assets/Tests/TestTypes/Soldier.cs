using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WgUnityPackages.IInventoryForUnity.Tests
{
    public class Soldier
    {
        public string name;
        public IInventory inventory;

        public Soldier()
        {
            inventory = new BasicInventory();
        }
    }
}