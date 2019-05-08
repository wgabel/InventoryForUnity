using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WgUnityPackages.IInventoryForUnity
{
    public interface IInventoryItem
    {
        long Id { get; set; }
        void DestroyInstance ();
    }
}