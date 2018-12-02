using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class SYLA_Stop_Ufo : MonoBehaviour {

   public GameObject childObj;
    public Animator anim;
    private bool paused;
    public Rigidbody2D rb;
    public GameObject ufo;
    public AnimationClip clip;
    


    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKey(KeyCode.J))

        {
            childObj.SetActive(true);
            Debug.Log(" J was pressed!");
           anim.gameObject.GetComponent<Animator>().enabled = false;

        }



    }
}
