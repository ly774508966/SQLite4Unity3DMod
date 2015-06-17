using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class CreateDBScript : MonoBehaviour {

	public Text DebugText;

	// Use this for initialization
	void Start () {
		StartSync();
	}

    private void StartSync()
    {
//		var ds = new DataService("datasqlite");
//        ds.CreateDatabase();
//        
//		var user = ds.GetUsers ();
//		ToConsole (user);
//
//		var tempUser = ds.GetUserByName ("Tuan");
//		ToConsole("Searching for Tuan ...");
//		ToConsole (tempUser); 
    }
	
	private void ToConsole(IEnumerable<User> people){
		foreach (var person in people) {
			ToConsole(person.ToString());
		}
	}
	private void ToConsole(User users){
		ToConsole(users.ToString());
	}

	private void ToConsole(string msg){
		DebugText.text += System.Environment.NewLine + msg;
		Debug.Log (msg);
	}
}
