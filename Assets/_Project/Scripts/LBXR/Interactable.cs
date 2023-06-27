using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LBXR
{
    public class Interactable : MonoBehaviour
    {
        // Declare a delegate type for the event.
        public delegate void ObjectSpawnedDelegate(GameObject spawnedObject);

        // Declare an event of this delegate type.
        public static event ObjectSpawnedDelegate OnObjectSpawned;
        
        void Start()
        {
            OnObjectSpawned?.Invoke(gameObject);
        }
    }
}
