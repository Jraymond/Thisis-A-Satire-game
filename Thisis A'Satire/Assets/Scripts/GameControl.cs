using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

    public GameObject game_menu;
    public float game_length;

    private float start_time;

	// Use this for initialization
	void Start () {
        start_time = Time.time;
    }
	
	// Update is called once per frame
	void Update () {

        Debug.Log("time: " + (Time.time - start_time));

        if ((Time.time - start_time) >= game_length)
            Gameover();

    }

    private void Gameover()
    {
        game_menu.SetActive(true);
    }

    public void Startgame()
    {
        start_time = Time.time;
        game_menu.SetActive(false);
    }
}
