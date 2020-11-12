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
            GUILayout.Label("Cost",GUILayout.Width(90));
            value2.purchasable.cost = EditorGUILayout.IntField(value2.purchasable.cost);
            value2.purchasable.resource = (Resource) EditorGUILayout.ObjectField(value2.purchasable.resource, typeof(Resource), true);
            GUILayout.EndHorizontal();

            GUILayout.Space(10);
            GUILayout.Label("Employers owned / text", EditorStyles.boldLabel);

            GUILayout.BeginHorizontal();
            var pink = new GUIStyle();
            pink.normal.textColor = new Color(0.9433962f,0.3604486f,0.8352419f);
            EditorGUILayout.LabelField("Hunters", pink,GUILayout.Width(90));
            value.ownedHunters = EditorGUILayout.IntField(value.ownedHunters);
            value.ownedHuntersText = (Text) EditorGUILayout.ObjectField(value.ownedHuntersText, typeof(Text), true);
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            var yellow = new GUIStyle();
            yellow.normal.textColor = Color.yellow;
            EditorGUILayout.LabelField("Miners", yellow,GUILayout.Width(90));
            value.ownedMiners = EditorGUILayout.IntField(value.ownedMiners);
            value.ownedMinersText = (Text) EditorGUILayout.ObjectField(value.ownedMinersText, typeof(Text), true);
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            var brown = new GUIStyle();
            brown.normal.textColor = new Color(0.5943396f,0.4105989f,0.2775454f);
            EditorGUILayout.LabelField("Lumber Jacks", brown,GUILayout.Width(90));
            value.ownedLumberJacks = EditorGUILayout.IntField(value.ownedLumberJacks);
            value.ownedLumberJacksText = (Text) EditorGUILayout.ObjectField(value.ownedLumberJacksText, typeof(Text), true);
            GUILayout.EndHorizontal();
        }
    }
}