using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace WgUnityPackages.IInventoryForUnity
{
    public class BasicInventory : IInventory
    {
        public IList<IInventoryItem> inventory;
        
        public long nextId = 0;

        public BasicInventory()
        {
            inventory = new List<IInventoryItem>();
        }

        public void Destroy()
        {
            if(inventory == null)
                return;
            for(int i = inventory.Count; i>=0; i--)
            {
                inventory[i].DestroyInstance();
                inventory.RemoveAt ( inventory.Count-1 );
            }
        }

        public IEnumerable<T> GetAllOfType<T>() where T : class
        {
            return (inventory as IEnumerable<IInventoryItem>).OfType<T>();
        }

        public T GetFirstOrNull<T>() where T : class
        {
            return (inventory as IEnumerable<IInventoryItem>).OfType<T>().FirstOrDefault();
        }

        public T GetFirstOrNull<T>(int id) where T : class
        {
            return (inventory as IEnumerable<IInventoryItem>).FirstOrDefault(m=>m.Id == id) as T;
        }

        public void Put<T>(T instance) where T : IInventoryItem
        {
            instance.Id = nextId;
            nextId++;
            inventory.Add ( instance );
        }
    }
}
