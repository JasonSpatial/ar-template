using System;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

namespace LBXR
{
    public class Tools : MonoBehaviour
    {
        public bool simulationEnabled = false;

        private void Start()
        {
            // always start with the same state since the build-in editor saves state between runs
            TouchSimulation.Disable();
        }

        public void OnEnablePressed()
        {
            TouchSimulation.Enable();
            simulationEnabled = true;
            
        }

        public void OnDisablePressed()
        {
            TouchSimulation.Disable();
            simulationEnabled = false;
        }
    }

}
