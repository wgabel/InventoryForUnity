using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WgUnityPackages.IInventoryForUnity
{
    public interface IInventory
    {
        void Put<T> ( T instance ) where T: IInventoryItem;
        T GetFirstOrNull<T>() where T : class;
        T GetFirstOrNull<T>(int id) where T : class;
        IEnumerable<T> GetAllOfType<T> ( ) where T : class;
        void Destroy();
    }
}

