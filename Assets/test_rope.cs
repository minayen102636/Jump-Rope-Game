using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_rope : MonoBehaviour {
    public int x=20; //speed
    public bool Gameover_rope;
    public GameObject Player;
    public int jump_rope;
    public int speedup;
    public int y = 0;

    void Start () {
		
	}
	
	void Update () {

        Gameover_rope = Player.GetComponent<PlayerController>().gameOver;
        jump_rope = Player.GetComponent<PlayerController>().jump;

        if (jump_rope > y)
        {
            if (jump_rope % 2 == 0)
            {

                x = x + 5;
                y = jump_rope;
            }
        }
        if (!Gameover_rope)
        {

            Transform transform = GetComponent<Transform>();
            Vector3 angle = new Vector3(x * 0.1f, 0, 0);
            transform.Rotate(angle);
        }
    }
    void speedcontroller(){

    }

}
