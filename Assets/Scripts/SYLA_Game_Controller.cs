using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SYLA_Game_Controller : MonoBehaviour {

    public Text endText;
    float timer;

	// Use this for initialization
	void Start () {
		
	}

   /* IEnumerator ByeAfterDelay(float time)
    {
        yield return new WaitForSeconds(time);

        // Code to execute after the delay
        GameLoader.gameOn = false;
    } */

    // Update is called once per frame
    void Update () {

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        timer = timer + Time.deltaTime;
       if (timer >= 10)
        {
            endText.text = "You Lose!";
            //StartCoroutine(ByeAfterDelay(2));

        }

    }

}

