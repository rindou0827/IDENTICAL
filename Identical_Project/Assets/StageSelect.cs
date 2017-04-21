using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelect : MonoBehaviour {

    SceneMaster scene = SceneMaster.GetInstance();
    StageInfo info;

	// Use this for initialization
	void Start () {
        info = this.GetComponent<StageInfo>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Stage1_Play()
    {
        GameMaster.DropSpeed = info.stages[1].DropSpeed;
        scene.Load_Game();//シーン遷移
    }
}
