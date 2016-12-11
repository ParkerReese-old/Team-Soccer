using UnityEngine;
using System.Collections;

public class Player1Movement : MonoBehaviour {
    public GameObject Player1;
    Rigidbody2D rbody;
    public float Speed;
    // Use this for initialization
    void Start () {
        rbody = Player1.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        rbody.velocity = new Vector3(
            Input.GetAxis("P1_Horizontal") * Speed,
            Input.GetAxis("P1_Vertical") * Speed,
            0);
    }
}
