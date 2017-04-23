using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatStage : MonoBehaviour {

    public GameObject CheatButton;
    private int count;

	// Use this for initialization
	void Start () {
        count = 0;
        CheatButton.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            count++;
        }

        if(count >= 5)
        {
            CheatButton.SetActive(true);
        }
	}
}
