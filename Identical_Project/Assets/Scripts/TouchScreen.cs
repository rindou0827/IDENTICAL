using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScreen : MonoBehaviour {

    public float dis = 50.0f;

    public static RaycastHit2D hit;

    void Start()
    {
        hit = new RaycastHit2D();//当たった情報を格納
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 tapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D collition2d = Physics2D.OverlapPoint(tapPoint);

            if (collition2d.tag == "Player" || collition2d.tag == "Enemy")
            {
                //collition2d.transform.GetComponent<MoveForced>().Reverce();
            }
        }
    }
}
