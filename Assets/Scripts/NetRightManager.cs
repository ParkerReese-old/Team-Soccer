using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NetRightManager : MonoBehaviour {
    public int pointsToAdd;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "SoccerBall")
        {

            ScoreLeftManager.AddPoints(pointsToAdd);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}
