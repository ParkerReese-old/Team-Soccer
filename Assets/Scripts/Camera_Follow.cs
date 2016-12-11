using UnityEngine;
using System.Collections;

public class Camera_Follow : MonoBehaviour {
    public Transform ball;
    public Vector3 offset;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(ball.position.x + offset.x, ball.position.y + offset.y, offset.z);

	}
}
