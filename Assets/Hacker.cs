using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ShowMainMenu();
	}

    void ShowMainMenu() {
        Terminal.ClearScreen();
        Terminal.WriteLine("Archaologists have uncovered what they believe to be the library of Alexandria");
        Terminal.WriteLine("but it's locked up behind ancient alien technology. We need your help to solve the puzzles!");
        Terminal.WriteLine("Which chamber will you hack into?");
        Terminal.WriteLine("Press 1 for Fantasy/Scifi");
        Terminal.WriteLine("Press 2 for Poetry");
        Terminal.WriteLine("Press 3 for Novels");
        Terminal.WriteLine("Enter your selection: ");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
