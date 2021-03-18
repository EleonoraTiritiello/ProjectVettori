using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ShowVarible))]
public class ShowVariablesComponent : Editor
{
    void OnSceneGUI()
    {
        ShowVarible showVariables = target as ShowVarible;

        showVariables.pointX = Handles.PositionHandle(showVariables.pointX, Quaternion.identity);
        showVariables.pointY = Handles.PositionHandle(showVariables.pointY, Quaternion.identity);
        showVariables.TangentA = Handles.PositionHandle(showVariables.TangentA, Quaternion.identity);
        showVariables.TangentB = Handles.PositionHandle(showVariables.TangentB, Quaternion.identity);

        Handles.DrawBezier(showVariables.pointX, showVariables.pointY, showVariables.TangentA, showVariables.TangentB, Color.blue, null, 5);
    }
}
