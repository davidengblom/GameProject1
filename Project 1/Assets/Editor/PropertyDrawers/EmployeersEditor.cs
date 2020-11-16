// using System.Reflection.Emit;
// using UnityEditor;
// using UnityEngine;
// using UnityEngine.UI;
// using HUD;
//
// namespace PropertyDrawers
// {
//     [CustomEditor(typeof(EmployeeUI))]
//     public class EmployersEditor : Editor
//     {
//         public override void OnInspectorGUI()
//         {
//             var value = this.target as EmployeeUI;
//
//
//             GUILayout.BeginHorizontal();
//             EditorGUILayout.LabelField("Owned employers Text");
//             value.ownedEmployersText = (Text) EditorGUILayout.ObjectField(value.ownedEmployersText, typeof(Text), true);
//             GUILayout.EndHorizontal();
//
//             GUILayout.Space(10);
//             GUILayout.Label("Employers cost / resource cost", EditorStyles.boldLabel);
//
//             GUILayout.BeginHorizontal();
//             var pink = new GUIStyle();
//             pink.normal.textColor = new Color(0.9433962f, 0.3604486f, 0.8352419f);
//             EditorGUILayout.LabelField("Hunters", pink, GUILayout.Width(90));
//             value.purchaseHunter.cost = EditorGUILayout.IntField(value.purchaseHunter.cost);
//             value.purchaseHunter.resource = (Resource) EditorGUILayout.ObjectField(value.purchaseHunter.resource, typeof(Text), true);
//             GUILayout.EndHorizontal();
//
//             GUILayout.BeginHorizontal();
//             var yellow = new GUIStyle();
//             yellow.normal.textColor = Color.yellow;
//             EditorGUILayout.LabelField("Miners", yellow, GUILayout.Width(90));
//             value.purchaseMiner.cost = EditorGUILayout.IntField(value.purchaseMiner.cost);
//             value.purchaseMiner.resource = (Resource) EditorGUILayout.ObjectField(value.purchaseMiner.resource, typeof(Text), true);
//             GUILayout.EndHorizontal();
//
//             GUILayout.BeginHorizontal();
//             var brown = new GUIStyle();
//             brown.normal.textColor = new Color(0.5943396f, 0.4105989f, 0.2775454f);
//             EditorGUILayout.LabelField("Lumber Jacks", brown, GUILayout.Width(90));
//             value.purchaseLumberjack.cost = EditorGUILayout.IntField(value.purchaseLumberjack.cost);
//             value.purchaseLumberjack.resource = (Resource) EditorGUILayout.ObjectField(value.purchaseLumberjack.resource, typeof(Text), true);
//             GUILayout.EndHorizontal();
//         }
//     }
// }