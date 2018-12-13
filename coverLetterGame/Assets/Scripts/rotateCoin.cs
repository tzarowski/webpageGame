using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCoin : MonoBehaviour {
    private Rigidbody coin;
	// Use this for initialization
	void Start () {
        coin = GetComponent<Rigidbody>(); 
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        coin.transform.Rotate(0f, 0f, 3f);
	}
}
