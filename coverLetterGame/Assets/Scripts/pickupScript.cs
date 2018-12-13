using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupScript : MonoBehaviour {
    private bool[] showText;
    private Texture2D myTexture;
    private int coinsCaught;
    public GameObject ball;
    public GameObject board;
    private Rigidbody ballBody;
	// Use this for initialization
	void Start () {
        myTexture = Resources.Load("SampleImage") as Texture2D;
        showText = new bool[] { false, false, false, false, false, false};
        coinsCaught = 0;
        ballBody = ball.GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.tag == "Collectable")
        {
            Destroy(c.gameObject);
            coinsCaught++;
            showText[coinsCaught] = true;
            ballBody.velocity = Vector3.zero;
            ballBody.angularVelocity = Vector3.zero;
            board.transform.eulerAngles = Vector3.zero;
            ball.transform.position = c.transform.position;

            
        }
        
    }

    void OnGUI()
    {
        if (showText[coinsCaught])
        {
            GUI.Label(new Rect(0 + (20*coinsCaught), 0 + (20*coinsCaught), 100, 100), coinsCaught.ToString());
        }
    }
}
