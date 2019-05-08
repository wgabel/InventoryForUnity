using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WgUnityPackages.IInventoryForUnity.Tests
{
    public class Weapon : IInventoryItem
    {
        public long Id { get; set; }
        public string weaponName;
        

        public void DestroyInstance()
        {
            throw new System.NotImplementedException();
        }
    }
}