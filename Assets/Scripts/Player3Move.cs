using UnityEngine;
using System.Collections;

public class Player3Move : MonoBehaviour
{
    public GameObject Player3;
    Rigidbody2D rbody;
    public float Speed;
    // Use this for initialization
    void Start()
    {
        rbody = Player3.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = new Vector3(
            Input.GetAxis("P3_Horizontal") * Speed,
            Input.GetAxis("P3_Vertical") * Speed,
            0);
    }
}

