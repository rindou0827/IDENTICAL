using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelect : MonoBehaviour {

    public GameObject StageButtons;//各ゲーム遷移へのボタン

    SceneMaster scene = SceneMaster.GetInstance();
    StageInfo info;

	// Use this for initialization
	void Start () {
        info = this.GetComponent<StageInfo>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Move_StartPosition()
    {
        LeanTween.moveLocal(StageButtons, new Vector3(0, 0, 0), 0.7f);
    }
    public void Move_Left()
    {
        LeanTween.moveLocal(StageButtons, new Vector3(1080, 0, 0), 0.7f);
    }
    public void Move_Right()
    {
        LeanTween.moveLocal(StageButtons, new Vector3(-1080, 0, 0), 0.7f);
    }

    public void Stage1_Play()
    {
        GameMaster.DropSpeed = info.stages[0].DropSpeed;
        scene.Load_Game();//シーン遷移
    }
    public void Stage2_Play()
    {
        GameMaster.DropSpeed = info.stages[1].DropSpeed;
        scene.Load_Game();//シーン遷移
    }
    public void Stage3_Play()
    {
        GameMaster.DropSpeed = info.stages[2].DropSpeed;
        scene.Load_Game();//シーン遷移
    }
    public void StageXX_Play()
    {
        GameMaster.DropSpeed = info.stages[3].DropSpeed;
        scene.Load_Game();//シーン遷移
    }
}
