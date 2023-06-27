using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.Interaction.Toolkit.AR;

namespace LBXR
{
    public delegate void TrackAnchor(EventArgs eventArgs);
    public class AnchorTracker : MonoBehaviour
    {
        private ARAnchorManager _arAnchorManager;
        private ARAnchor arAnchor;
        private TrackableId _trackableId;

        void Start()
        {
            _arAnchorManager = GetComponent<ARAnchorManager>();
        }

        public void TrackAnchor(GameObject anchor)
        {
            if (_arAnchorManager.enabled)
            {
                if (_arAnchorManager.trackables.count == 0)
                {
                    anchor.AddComponent<ARAnchor>();
                    _trackableId = anchor.GetComponent<ARAnchor>().trackableId;
                    print($"created anchor with id: {_trackableId}");
                    print($"trackables: {_arAnchorManager.trackables.count}");
                }
                else
                {
                    arAnchor = _arAnchorManager.GetAnchor(_trackableId);
                    anchor.transform.SetParent(arAnchor.gameObject.transform);
                    print($"added GO to anchor with ID: {arAnchor.trackableId}");
                    print($"trackables: {_arAnchorManager.trackables.count}");

                }
            }
        }
        
        void OnEnable()
        {
            // Subscribe to the event.
            Interactable.OnObjectSpawned += ReactToObjectSpawned;
        }

        void OnDisable()
        {
            // Unsubscribe from the event.
            Interactable.OnObjectSpawned -= ReactToObjectSpawned;
        }

        // This method will be called when an object is spawned.
        void ReactToObjectSpawned(GameObject spawnedObject)
        {
            TrackAnchor(spawnedObject);
        }

    }
}
