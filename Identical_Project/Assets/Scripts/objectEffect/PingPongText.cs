using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PingPongText : MonoBehaviour {

    private Text text;
    private Color SaveColor;//保存用

	// Use this for initialization
	void Start () {
        text = this.GetComponent<Text>();
        SaveColor = text.color;
	}
	
	// Update is called once per frame
	void Update () {
        text.color = new Color(SaveColor.r, SaveColor.g, SaveColor.a, Mathf.PingPong(Time.time, 1));//点滅表示
	}
}
