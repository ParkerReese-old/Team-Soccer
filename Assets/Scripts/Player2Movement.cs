using UnityEngine;
using System.Collections;

public class Player2Movement : MonoBehaviour {
    public GameObject Player2;
    Rigidbody2D rbody;
    public float Speed;
    // Use this for initialization
    void Start()
    {
        rbody = Player2.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = new Vector3(
            Input.GetAxis("P2_Horizontal") * Speed,
            Input.GetAxis("P2_Vertical") * Speed,
            0);
    }
}
