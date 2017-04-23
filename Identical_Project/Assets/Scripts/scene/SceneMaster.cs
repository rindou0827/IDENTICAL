using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// このクラスのみでシーンを管理する。
/// ここ以外でシーンの記述はしてはいけない。
/// インスタンスは一つのみ
/// </summary>
public class SceneMaster : MonoBehaviour {

    private static SceneMaster sceneMaster = new SceneMaster();

    public static SceneMaster GetInstance()
    {
        return sceneMaster;
    }

    // Use this for initialization
    //void Start () {
        
	//}
	
	// Update is called once per frame
	void Update () {            
        if(Input.GetKeyDown(KeyCode.Escape))//Escapeキー押されたら終了
        {
            Application.Quit();
        }
	}

    //シーンの読み込み
    public void Load_Title()
    {
        SceneManager.LoadScene("Title");
    }
    public void Load_MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Load_Game()
    {
        SceneManager.LoadScene("Game");
    }
    public void Load_VersusMode()
    {
        SceneManager.LoadScene("Versus");
    }
}
