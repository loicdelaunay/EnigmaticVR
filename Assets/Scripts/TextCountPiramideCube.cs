using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCountPiramideCube : MonoBehaviour {

    private GameObject[] piramideObject;
    private int count;
    private TextMesh textPiramide;
    private GameObject mur1Level2;

	// Use this for initialization
	void Start () {
        textPiramide = GetComponent<TextMesh>();
        mur1Level2 = GameObject.FindGameObjectWithTag("mur1Level2");
    }
	
	// Update is called once per frame
	void Update () {

        piramideObject = GameObject.FindGameObjectsWithTag("piramideCube");
        count = piramideObject.Length;

        if(count == 0)
        {
            textPiramide.text = "Bravo !";
            mur1Level2.GetComponent<MoveTo>().Move();
        }
        else
        {
            textPiramide.text = "Il reste : " + count + "cubes !";
        }
	}
}
