using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeToScene(string name)
    {
        Debug.Log("Changing scene: " + name);
        SceneManager.LoadScene(name);
    }

}
