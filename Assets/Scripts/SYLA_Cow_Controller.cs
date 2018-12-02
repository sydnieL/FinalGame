using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SYLA_Cow_Controller : MonoBehaviour
{ 

    private bool isInBeam;
    public Transform beamCheck;
    public float checkRadius;
    public LayerMask beamSpace;
    public GameObject childObj;
    public GameObject mainObj;
    public GameObject loseText;



    private Animator anim;
    public Text winText;



    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        //Debug.Log("Cow is alive");
        
    }

    /*IEnumerator ByeAfterDelay(float time)
    {
        yield return new WaitForSeconds(time);

        // Code to execute after the delay
        GameLoader.gameOn = false;
    }*/

    // Update is called once per frame
    void Update()
    {

        isInBeam = Physics2D.OverlapCircle(beamCheck.position, checkRadius, beamSpace);

        if (isInBeam == true)
        {
            //Debug.Log("please cow is in beam");
            //GameLoader.AddScore(10);
            winText.text = "You Abducted the Cow!";
            childObj.SetActive(true);
            mainObj.SetActive(false);
            loseText.SetActive(false);
           // StartCoroutine(ByeAfterDelay(2));




        }



    }

   
}
