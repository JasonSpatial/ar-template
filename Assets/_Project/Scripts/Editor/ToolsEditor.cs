using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

[CustomEditor(typeof(Tools))]
public class ToolsEditor : Editor
{
    public override void OnInspectorGUI()
    {
        if (GUILayout.Button("Enable Touch Simulation"))
        {
            TouchSimulation.Enable();
        }

        if (GUILayout.Button("Disable Touch Simulation"))
        {
            TouchSimulation.Disable();
        }
    }
}
