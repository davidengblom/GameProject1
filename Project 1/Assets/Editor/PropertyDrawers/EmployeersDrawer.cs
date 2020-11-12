using GUI;
using UnityEditor;
using UnityEngine;

namespace PropertyDrawers
{
    // [CustomPropertyDrawer(typeof(OwnedEmployersUI))]
    // public class EmployersDrawer : PropertyDrawer
    // {
    //     public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    //     {
    //         return base.GetPropertyHeight(property, label) * 2;
    //     }
    //
    //     public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    //     {
    //         position = EditorGUI.PrefixLabel(position, label);
    //
    //         var labelWidth = 50f;
    //         var width = (position.width - labelWidth) / 2;
    //         var minerLabel = new Rect(position.x, position.y, labelWidth, position.height / 2);
    //         var miners = new Rect(position.x + labelWidth, position.y, width, position.height / 2);
    //         var minersText = new Rect(position.x + labelWidth + width, position.y, width, position.height / 2);
    //         // var lumberJacks = new Rect(position.x, position.y + position.height / 2, 80, position.height / 2);
    //         // var lumberJacksText = new Rect(position.x + lumberJacks.width + 2, position.y + position.height / 2, 80, position.height / 2);
    //         // var hunters = new Rect(position.x, position.y + lumberJacks.height + miners.height, EditorGUIUtility.fieldWidth / 2, position.height);
    //         // var huntersText = new Rect(position.x + hunters.width + 2, hunters.position.y, EditorGUIUtility.fieldWidth / 2, position.height);
    //
    //         EditorGUI.LabelField(minerLabel, "Miners");
    //         EditorGUI.PropertyField(miners, property.FindPropertyRelative("ownedMiners"), GUIContent.none);
    //         EditorGUI.PropertyField(minersText, property.FindPropertyRelative("ownedMinersText"), GUIContent.none);
    //         // EditorGUI.PropertyField(lumberJacks, property.FindPropertyRelative("ownedLumberJacks"), new GUIContent("LumberJack"));
    //         // EditorGUI.PropertyField(lumberJacksText, property.FindPropertyRelative("ownedLumberJacksText"), new GUIContent());
    //         // EditorGUI.PropertyField(hunters, property.FindPropertyRelative("ownedHunters"), new GUIContent("Hunters"));
    //         // EditorGUI.PropertyField(huntersText, property.FindPropertyRelative("ownedHuntersText"), new GUIContent());
    //     }
    // }
}