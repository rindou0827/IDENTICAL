using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VersusMode : MonoBehaviour {

    public GameObject StartObject;//始まりを知らせるオブジェクト
    public GameObject ActiveObj;//表示非表示用
    public Text ResultText;//結果表示
    public float StartTimeMin;
    public float StartTimeMax;

    private float PushTime;//
    private float StartTime;//0になったら始まり

    private float RecodeTime_Player1;//押した時間を記録
    private float RecodeTime_Player2;
    private bool PushButton_Player1;//押したらtrue
    private bool PushButton_Player2;
    private bool StartFlag;//始まったか
    private bool ResultFlag;//結果をだしたか

	// Use this for initialization
	void Start () {
        ActiveObj.SetActive(false);
        StartObject.SetActive(false);
        RecodeTime_Player1 = 0;
        RecodeTime_Player2 = 0;
        PushButton_Player1 = false;
        PushButton_Player2 = false;
        StartFlag = false;
        ResultFlag = false;
        StartTime = Random.Range(StartTimeMin, StartTimeMax);
	}
	
	// Update is called once per frame
	void Update () {
        StartTime -= Time.deltaTime;

        if(StartTime <= 0.0f)
        {
            if(StartFlag == false)
            {
                StartObject.SetActive(true);
            }
            StartFlag = true;
            PushTime -= Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.S) && PushButton_Player1 == false)
        {
            PushButton_Player1 = true;
            RecodeTime_Player1 = PushTime;
        }
        if (Input.GetKeyDown(KeyCode.K) && PushButton_Player2 == false)
        {
            PushButton_Player2 = true;
            RecodeTime_Player2 = PushTime;
        }

        if(PushButton_Player1 == true && PushButton_Player2 == true && ResultFlag == false)//両方押したら
        {
            ResultFlag = true;
            Judge();
        }
	}
    public void Judge()
    {
        ActiveObj.SetActive(true);
        if(RecodeTime_Player1 == RecodeTime_Player2)//同着
        {
            ResultText.text = "DROW";
        }
        else if(RecodeTime_Player1 > RecodeTime_Player2)//1Pの勝利
        {
            ResultText.text = "PLAYER1 WIN";
        }
        else//2Pの勝利
        {
            ResultText.text = "PLAYER2 WIN";
        }
    }
}
