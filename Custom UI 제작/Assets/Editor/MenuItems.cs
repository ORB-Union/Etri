/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
//using UnityEditor.SceneManagement;
 
public class AboutEtri : EditorWindow
{
    string myString = "Hello World";
    bool groupEnabled;
    bool myBool = true;
    float myFloat = 1.23f;

    //Window 메뉴에 "My Window" 항목을 추가한다.
    [MenuItem("Help/About Etri", priority = 1)]
    static void Init()
    {
        // 생성되어있는 윈도우를 가져온다. 없으면 새로 생성한다. 싱글턴 구조인듯하다.
        AboutEtri window = (AboutEtri)EditorWindow.GetWindow(typeof(AboutEtri), utility: true,
                                                       title: "About Etri");
        window.Show();
    }

    void OnGUI()
    {
        GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        myString = EditorGUILayout.TextField("Text Field", myString);

        groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);
        myBool = EditorGUILayout.Toggle("Toggle", myBool);
        myFloat = EditorGUILayout.Slider("Slider", myFloat, -3, 3);
        EditorGUILayout.EndToggleGroup();
    }
}
*/