using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour {

    public Vector3 targetPosition;
    private Vector3 finalTargetPosition;
    public float speed = 10.0f;
    public bool moveOnStart = false;
    public bool deltaMove = false;
    private bool move = false;


	// Use this for initialization
	void Start () {

        if (deltaMove)
        {
            finalTargetPosition = transform.position + targetPosition;
        }
        else
        {
            finalTargetPosition = transform.position;
        }

        if(moveOnStart == true)
        {
            move = true;
        }

	}
	
	// Update is called once per frame
	void Update () {

        if (move)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, finalTargetPosition, step);
        }
	}

    public void Move()
    {
        this.move = true;
    }
}
