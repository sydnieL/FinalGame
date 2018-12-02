using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SYLA_Cow_Child_Move : MonoBehaviour {



    public Vector2 moveTo;
    public float speed;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        //Debug.Log("Im trying to move");

        float step = speed * Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, moveTo, step);
    }
}
