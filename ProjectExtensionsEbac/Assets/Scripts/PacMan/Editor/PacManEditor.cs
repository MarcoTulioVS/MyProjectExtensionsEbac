using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PacMan))]
public class PacManEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();

        PacMan pacMan = (PacMan)target;
        pacMan.pacMan = (GameObject)EditorGUILayout.ObjectField(pacMan.pacMan, typeof(GameObject), true);

        if(GUILayout.Button("Pac man"))
        {
            pacMan.CreatePacMan();
        }
    }
}
