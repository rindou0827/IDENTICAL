using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PingPongImage : MonoBehaviour {

    private Image image;
    private Color SaveColor;//保存用

    // Use this for initialization
    void Start()
    {
        image = this.GetComponent<Image>();
        SaveColor = image.color;
    }

    // Update is called once per frame
    void Update()
    {
        image.color = new Color(SaveColor.r, SaveColor.g, SaveColor.a, Mathf.PingPong(Time.time, 1));//点滅表示
    }
}
