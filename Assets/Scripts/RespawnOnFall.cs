using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnOnFall : MonoBehaviour {

    private Vector3 initPosition;

	// Use this for initialization
	void Start () {
        initPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        if(transform.position.y < -100)
        {
            transform.position = initPosition;
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
		
	}
}
