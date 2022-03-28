using UnityEngine;
using System.Collections;

public class Flow : MonoBehaviour {

    public float windFlow = 0f;
    public float gust = 0f;
    Rigidbody2D PCbody;


	// Use this for initialization
	void Start () {

        PCbody = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {

        this.PCbody.velocity = new Vector2(windFlow, 0f);

        if (Input.GetKey("space"))
        {
            PCbody.AddForce(Vector2.up * gust, ForceMode2D.Force);
        }
	
	}
}
