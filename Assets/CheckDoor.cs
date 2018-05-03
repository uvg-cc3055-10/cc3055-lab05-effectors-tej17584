using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CheckDoor : MonoBehaviour {
    private Character player;
    public bool toque;
	// Use this for initialization
	void Start () {
        player = GetComponentInParent<Character>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        
            SceneManager.LoadScene("Dungeon2");
        toque = true;
      
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        SceneManager.LoadScene("Dungeon2");
        toque = true;
    }
}
