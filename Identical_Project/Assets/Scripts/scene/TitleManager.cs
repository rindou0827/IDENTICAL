using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour {

    [HideInInspector]
    SceneMaster sceneMaster;

	// Use this for initialization
	void Start () {
        sceneMaster = SceneMaster.GetInstance();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.anyKey)//何か押されたら
        {
            sceneMaster.Load_MainMenu();//MainMenuに移行
        }
	}
}
