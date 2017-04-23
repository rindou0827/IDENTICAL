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
        AddStageStatus(stage1, 1.0f);

        Stage stage2 = new Stage();
        AddStageStatus(stage2, 1.5f);

        Stage stage3 = new Stage();
        AddStageStatus(stage3, 2.0f);

        Stage stageXX = new Stage();
        AddStageStatus(stageXX, 3.0f);
    }

    /// <summary>
    /// ステージを追加するためのメソッド
    /// </summary>
    /// <param name="stage">ステージ名</param>
    /// <param name="Speed">落下速度</param>
    public void AddStageStatus(Stage stage, float Speed)
    {
        stage.DropSpeed = Speed;
        stages.Add(stage);
    }
}

/// <summary>
/// Gameに引き渡すステージ情報
/// </summary>
public class Stage
{
    public float DropSpeed;//落下スピード(x1.0 = そのまま x2.0 = 倍)
}
