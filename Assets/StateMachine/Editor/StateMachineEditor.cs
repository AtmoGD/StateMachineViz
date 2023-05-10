using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace StateMachineViz
{
    public class StateMachineEditor : EditorWindow
    {
        private GUIStyle currentStyle = null;
        [MenuItem("StateMachineViz/StateMachine")]
        private static void ShowWindow()
        {
            var window = GetWindow<StateMachineEditor>();
            window.titleContent = new GUIContent("StateMachine");
            window.Show();
        }

        private void OnGUI()
        {
            var window = GetWindow<StateMachineEditor>();

            InitStyles();
            GUI.Box(new Rect(0, 0, window.position.width, window.position.height), "Hello", currentStyle);


            GUI.backgroundColor = Color.yellow;
            GUI.Button(new Rect(10, 10, 70, 30), "A button");
        }

        private void InitStyles()
        {
            currentStyle = new GUIStyle(GUI.skin.box);
            currentStyle.normal.background = MakeTex(2, 2, new Color(0.15f, 0.15f, 0.15f));
        }

        private Texture2D MakeTex(int width, int height, Color col)
        {
            Color[] pix = new Color[width * height];
            for (int i = 0; i < pix.Length; ++i)
            {
                pix[i] = col;
            }
            Texture2D result = new Texture2D(width, height);
            result.SetPixels(pix);
            result.Apply();
            return result;
        }

        public void LoadFromFile(string _path)
        {
            Debug.Log("Loading from file: " + _path);
        }
    }
}