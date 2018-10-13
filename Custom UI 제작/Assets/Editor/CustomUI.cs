using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CustomAbout : EditorWindow
{
    private Texture2D WeARlogo; // WeAR로고
    private Texture2D ETRIlogo; // ETRI로고
    private Texture2D BONOGAMElogo; // BONOGAME 로고
    private Texture2D morphlogo; // morph로고
    private Texture2D SYWORKSlogo; // SYWORKS 로고
    private Texture2D HanYanglogo; // 한양대학교 로고
    private Texture2D MunHwalogo; // 문화체육관광부 로고
    private Texture2D Koccalogo; // KOCCA 로고
    private Texture2D whiteboard; // BackGround

    [MenuItem("Help/About Etri", priority = 1)]
    static void Init()
    {
        CustomAbout window = (CustomAbout)EditorWindow.GetWindow(typeof(CustomAbout),
                                                                 utility: true,
                                                                 title: "About Etri");

        //Window Position, Size
        window.position = new Rect(150, 150,750,450);
        window.minSize = new Vector2(750, 450);
        window.maxSize = new Vector2(750, 450);
        window.Show();
    }

    void OnEnable()
    {
        //Background
        whiteboard = (Texture2D)AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/logo/whiteboard.png");
        //WEAR
        WeARlogo = (Texture2D)AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/logo/wear.jpg");
        //BONOGAME
        BONOGAMElogo = (Texture2D)AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/logo/bono.png");
        //ETRI
        ETRIlogo = (Texture2D)AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/logo/etri.png");
        //HanYang
        HanYanglogo = (Texture2D)AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/logo/hanyang.png");
        //KOCCA
        Koccalogo = (Texture2D)AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/logo/kocca.png");
        //morph
        morphlogo = (Texture2D)AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/logo/morph.png");
        //MunHwa
        MunHwalogo = (Texture2D)AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/logo/munhwa.gif");
        //SYWORKS
        SYWORKSlogo = (Texture2D)AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/logo/syworks.jpg");

    }

    void OnGUI()
    {
        GUI.skin.label.fontSize = 13;

        //Background
        GUI.DrawTexture(new Rect(0, 0, 750, 500), whiteboard);
        //WEARlogo
        GUI.DrawTexture(new Rect(10, 0, 250, 70), WeARlogo);
        //GUILayout.Space(40);
        //GUILayout.Label("Version : 1.0", EditorStyles.boldLabel);
        GUI.Label(new Rect(10,70, 200, 25), "Version : 1.0");
        GUI.Label(new Rect(10, 100, 700, 30), "we:AR은 실외에서 증강현실을 즐길 수 있도록 템플릿 기반의 콘텐츠를 제작하는 기능을 제공합니다.");
        GUI.Label(new Rect(10, 150, 700, 30), "과제명 : 실세계 연계 실감형 e-레저 콘텐츠 서비스 기술 개발");

        //  
        GUI.skin.label.fontSize = 15;
        GUI.Label(new Rect(10, 200, 100, 30), "주관기관");
        GUI.DrawTexture(new Rect(10, 230, 180, 40), ETRIlogo);
        GUI.Label(new Rect(300, 200, 100, 30), "공동연구기관");
        GUI.DrawTexture(new Rect(300, 230, 180, 30), BONOGAMElogo);
        GUI.DrawTexture(new Rect(500, 230, 80, 30), morphlogo);
        GUI.DrawTexture(new Rect(600, 230, 100, 30), SYWORKSlogo);
        GUI.DrawTexture(new Rect(300, 280, 180, 40), HanYanglogo);

        //
        GUI.skin.label.fontSize = 13;
        GUI.Label(new Rect(10, 340, 700, 30), "본 연구는 문화체육관광부 및 한국콘텐츠진흥원의 문화기술 연구개발 지원사업으로 수행되었습니다.");
        GUI.DrawTexture(new Rect(350, 380, 220, 50), MunHwalogo);
        GUI.DrawTexture(new Rect(580, 380, 150, 50), Koccalogo);
    }
}