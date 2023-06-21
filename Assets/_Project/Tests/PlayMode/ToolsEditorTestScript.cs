using System.Collections;
using System.Collections.Generic;
using LBXR;
using NUnit.Framework;
using Unity.PerformanceTesting;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;
using Tools = LBXR.Tools;


public class ToolsEditorTestScript
{
    [UnityTest, Performance]
    public IEnumerator ToolsEditorButtonTests()
    {
        Tools tools = new GameObject().AddComponent<Tools>();
        tools.simulationEnabled = false;

        // Simulate Enable press
        Measure.Method(() => {
            tools.OnEnablePressed();
        }).Run();

        // Give Unity a frame to process the change
        yield return null;

        // Check that your component now has the expected state
        Assert.IsTrue(tools.simulationEnabled);

        // Simulate Disable press
        Measure.Method(() => {
            tools.OnDisablePressed();
        }).Run();
        
        // Give Unity another frame to process the change
        yield return null;

        // Check that the value is toggled back to false
        Assert.IsFalse(tools.simulationEnabled);
    }

}
