using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEditor.Callbacks;
using UnityEditor;
using System;

namespace StateMachineViz
{
    [Serializable]
    public class Variable<T>
    {
        public string name;
        public T value;
    }


    [CreateAssetMenu(fileName = "New State Machine Data", menuName = "State Machine Data")]
    public class StateMachineData : ScriptableObject
    {
        public List<Variable<int>> intVariables = new List<Variable<int>>();
        public List<Variable<float>> floatVariables = new List<Variable<float>>();
        public List<Variable<bool>> boolVariables = new List<Variable<bool>>();
        public List<Variable<string>> stringVariables = new List<Variable<string>>();
        public List<Variable<UnityEvent>> callbackVariables = new List<Variable<UnityEvent>>();

        [OnOpenAssetAttribute(2)]
        public static bool OpenGameStateFlow(int instanceID, int line)
        {
            // var window = EditorWindow.GetWindow(typeof(StateMachineEditor)) as StateMachineEditor;

            // string assetPath = AssetDatabase.GetAssetPath(instanceID);
            // window.LoadFromFile(assetPath);

            return true;
        }
    }
}