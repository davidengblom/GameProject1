using System.Reflection.Emit;
using GUI;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace PropertyDrawers
{
    [CustomEditor(typeof(EmployeeUI))]
    public class EmployersEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            var value = this.target as EmployeeUI;
            var value2 = this.target as InfoPanel;

            GUILayout.Label("Resource cost/type", EditorStyles.boldLabel);

            GUILayout.BeginHorizontal();
            GUILayout.Label("Cost",GUILayout.Width(80));
            value2.purchasable.cost = EditorGUILayout.IntField(value2.purchasable.cost);
            value2.purchasable.resource = (Resource) EditorGUILayout.ObjectField(value2.purchasable.resource, typeof(Resource), true);
            GUILayout.EndHorizontal();

            GUILayout.Space(10);
            GUILayout.Label("Employers owned / text", EditorStyles.boldLabel);

            GUILayout.BeginHorizontal();
            GUILayout.Label("Hunters",GUILayout.Width(80));
            value.ownedHunters = EditorGUILayout.IntField(value.ownedHunters);
            value.ownedHuntersText = (Text) EditorGUILayout.ObjectField(value.ownedHuntersText, typeof(Text), true);
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUILayout.Label("Miners",GUILayout.Width(80));
            value.ownedMiners = EditorGUILayout.IntField(value.ownedMiners);
            value.ownedMinersText = (Text) EditorGUILayout.ObjectField(value.ownedMinersText, typeof(Text), true);
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUILayout.Label("LumberJacks", GUILayout.Width(80));
            value.ownedLumberJacks = EditorGUILayout.IntField(value.ownedLumberJacks);
            value.ownedLumberJacksText = (Text) EditorGUILayout.ObjectField(value.ownedLumberJacksText, typeof(Text), true);
            GUILayout.EndHorizontal();
        }
    }
}