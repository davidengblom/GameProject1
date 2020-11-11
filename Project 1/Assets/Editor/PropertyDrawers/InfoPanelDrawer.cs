using GUI;
using UnityEditor;
using UnityEngine;

namespace PropertyDrawers
{
    [CustomPropertyDrawer(typeof(InfoPanel))] //not working for a none serializable class. We'll change the type later down the road
    public class InfoPanelDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position = EditorGUI.PrefixLabel(position, label);

            var cost = new Rect(position.x, position.y, EditorGUIUtility.fieldWidth / 2, position.height);
            var type = new Rect(position.x + cost.width + 2, position.y, EditorGUIUtility.fieldWidth, position.height);

            EditorGUI.PropertyField(cost, property.FindPropertyRelative("resourceCost"), GUIContent.none);
            EditorGUI.PropertyField(type, property.FindPropertyRelative("resourceType"), GUIContent.none);
        }
    }
}