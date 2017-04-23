using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MoveInfo
{
    Stay,
    Move
}
public class DropObjectUI : MonoBehaviour {

    [HideInInspector]
    public float DropSpeed;
    [HideInInspector]
    public MoveInfo moveInfo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		switch(moveInfo)
        {
            case MoveInfo.Stay:
                break;
            case MoveInfo.Move:
                transform.position -= new Vector3(0, 0.3f, 0) * DropSpeed;
                break;
        }
	}
}
