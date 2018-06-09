using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(GameManager.Instance.GameState == GameState.Playing)
        transform.Rotate(new Vector3(5, 0, 0));
    }
}
