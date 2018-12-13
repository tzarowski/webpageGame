using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiltScript : MonoBehaviour {
    public GameObject board;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        
        if (Input.GetKey("up"))
        {
            board.transform.Rotate(30f * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey("down"))
        {
            board.transform.Rotate(-30f * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey("left"))
        {
            board.transform.Rotate(0.0f, 0.0f, 30f * Time.deltaTime);
        }
        if (Input.GetKey("right"))
        {
            board.transform.Rotate(0.0f, 0.0f, -30f * Time.deltaTime);
        }
        
    }
}
