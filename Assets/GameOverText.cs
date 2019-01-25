using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverText : MonoBehaviour {
    public GameObject Player;

    void Start () {
		
	}
	
	
	void Update () {
        GetComponent<TextMesh>().text = Player.GetComponent<PlayerController>().GameOver;
    }
}
