using UnityEditor;
using UnityEngine;

namespace LBXR
{
    [CustomEditor(typeof(Tools))]
    public class ToolsEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            Tools tools = (Tools)target;
            
            if (GUILayout.Button("Enable Touch Simulation"))
            {
                tools.OnEnablePressed();
            }

            if (GUILayout.Button("Disable Touch Simulation"))
            {
                tools.OnDisablePressed();
            }
        }
    }
}

