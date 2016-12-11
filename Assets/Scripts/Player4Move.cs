using UnityEngine;
using System.Collections;

public class Player4Move : MonoBehaviour
{
    public GameObject Player4;
    Rigidbody2D rbody;
    public float Speed;
    // Use this for initialization
    void Start()
    {
        rbody = Player4.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = new Vector3(
            Input.GetAxis("P4_Horizontal") * Speed,
            Input.GetAxis("P4_Vertical") * Speed,
            0);
    }
}
