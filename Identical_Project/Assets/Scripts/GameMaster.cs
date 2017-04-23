using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {

    public GameObject DropObject;//落下させるオブジェ
    public GameObject Player;//捕まえるオブジェクト
    public GameObject ResultObjects;//ゲームの合否をまとめたオブジェクト
    public GameObject RetryButton;//リトライボタン
    public Text ResultText;//結果を表示するテキスト
    public Sprite CatchImage;//キャッチした画像
    public float DropTimeMin;//落下させる最短時間
    public float DropTimeMax;//落下させる最長時間

    public static float DropSpeed;//落下速度

    private float RandomDropTiming;//落下し始める時間
    private bool ClearFlag;//ゲームクリアかどうか
    private bool DropFlag;//落下したかどうか
    private bool PushFlag;//押したかどうか

	// Use this for initialization
	void Start () {
        RetryButton.SetActive(false);//非表示
        ResultObjects.SetActive(false);//非表示
        PushFlag = false;
        ClearFlag = false;
        DropFlag = false;
        RandomDropTiming = Random.Range(DropTimeMin, DropTimeMax);//指定された時間内で落下させる時間を決定
        DropObject.GetComponent<DropObjectUI>().DropSpeed = DropSpeed;//オブジェクトに落下速度を渡す。
	}
	
	// Update is called once per frame
	void Update () {
        if(PushFlag == false)//押されるまで
        {
            RandomDropTiming -= Time.deltaTime;//時間減少
        }

        if(RandomDropTiming <= 0.0f && DropFlag == false)//0秒を下回ったかつまだ落ちてない
        {
            DropObject.GetComponent<DropObjectUI>().moveInfo = MoveInfo.Move;//動かす
            DropFlag = true;//落下
        }

        if (Input.GetMouseButton(0) && PushFlag == false)//マウスが押されたらかつまだ一回も押してない
        {
            Player.GetComponent<SpriteRenderer>().sprite = CatchImage;
            Judge(Player.transform.position, DropObject.transform.position);//判定
            if(ClearFlag == true)
            {
                ResultText.text = "Game Clear!!";
                ResultObjects.SetActive(true);//表示
                ClearFlag = false;
            }
            else
            {
                ResultText.text = "Game Over!!";
                ResultObjects.SetActive(true);//表示
                RetryButton.SetActive(true);
            }
            PushFlag = true;
        }

        if(DropObject.transform.position.y <= -9.0f)//落ちてくるオブジェクトが一定以上下がったら
        {
            DropObject.GetComponent<DropObjectUI>().moveInfo = MoveInfo.Stay;//停止
            ResultText.text = "Game Over!!";
            ResultObjects.SetActive(true);//表示
            RetryButton.SetActive(true);
            ClearFlag = false;
            PushFlag = true;
        }
	}
    public void Judge(Vector3 PlayerPos, Vector3 ObjectPos)
    {
        if(Vector3.Distance(PlayerPos, ObjectPos) < 2.0f)//成功
        {
            DropObject.GetComponent<DropObjectUI>().moveInfo = MoveInfo.Stay;//停止
            ClearFlag = true;
        }
        else//失敗
        {
            ClearFlag = false;
        }
    }
}
