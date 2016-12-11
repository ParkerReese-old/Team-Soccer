using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeCountDown : MonoBehaviour {

    public static float time = 50;

    Text text;

    private bool reset = false;

    // Use this for initialization
    void Start () {

        text = GetComponent<Text>();

        text.text = "" + time;
       

        DontDestroyOnLoad(gameObject);

    }
	
	// Update is called once per frame
	void Update () {

        time -= Time.deltaTime;

        text.text = "" + Mathf.Round(time);

	}

    public void Reset()
    {
        text.text = "" + time;
    }
}
