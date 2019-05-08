using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WgUnityPackages.IInventoryForUnity
{
    public interface IInventory
    {
        void Put<T> ( T instance ) where T: class;
        T GetFirstOrNull<T>() where T : class;
        T Get<T> ( int id ) where T : class;
        void Destroy();
    }
}

