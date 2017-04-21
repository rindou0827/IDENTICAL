using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageInfo : MonoBehaviour {

    [HideInInspector]
    public List<Stage> stages;

	// Use this for initialization
	void Start () {
        stages = new List<Stage>();
        CreateStageInfo();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// ステージ情報の作成
    /// </summary>
    public void CreateStageInfo()
    {
        Stage stage1 = new Stage();
        stage1.DropSpeed = 1.0f;
        stages.Add(stage1);
    }
}
public class Stage
{
    public float DropSpeed;//落下スピード
}
