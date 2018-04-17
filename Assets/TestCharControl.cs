using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharControl : MonoBehaviour {

    [Range(0,1)]
    public float MoveSpeed = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 moveVector = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical")) * Time.deltaTime * MoveSpeed;
        //Debug.Log(moveVector);
        transform.Translate(moveVector);
	}
}
