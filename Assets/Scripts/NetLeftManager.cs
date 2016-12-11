using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class NetLeftManager : MonoBehaviour
{ 

    public GameObject Ball;
    public GameObject P1_P2_Rope;
    public GameObject P3_P4_Rope;
    public GameObject Destination;

    public int pointsToAdd;
    private bool clones;
 
  
    // Use this for initialization
    void Start()
    {
        clones = false;
      
     
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "SoccerBall")
        {
           
            ScoreRightManager.AddPoints(pointsToAdd);

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            
        }
    }
}
