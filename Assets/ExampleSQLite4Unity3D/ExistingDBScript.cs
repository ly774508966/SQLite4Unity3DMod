using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;


public class ExistingDBScript : MonoBehaviour {

	public Text DebugText;


	void Start () {

		//DataService.UserDBQuery().CreateDatabase();

		var user = UserDataController.GetUsers();
		ToConsole (user);

		// Insert User
		var userTemp2 = new User{
			UserName = "Dat Pham Thanh xxx",
			Age = 200,
			Company = "Dat' com Thanh"
		};
		UserDataController.InsertUser(userTemp2);
		ToConsole("Adding for Dat Pham Thanh ...");
		ToConsole (userTemp2);


		// Get user
		user = UserDataController.GetUsersByName ("Dat Pham");
		ToConsole("Searching for Dat Pham ...");
		ToConsole (user);

		// Update user
		var userTemp = new User{
			UserName = "Dat Pham",
			Age = 200,
			Company = "Dat' com"
		};
		UserDataController.UpdateUser(userTemp);
		ToConsole("Updating for Dat Pham ...");
		ToConsole (userTemp);

		// Insert User
		ToConsole("Adding for Pham ...");
		var userTemp3 = new User{
			UserName = "Dat Pham Thanh",
			Age = 200,
			Company = "Dat' com Thanh"
		};
		UserDataController.InsertUser(userTemp3);
		ToConsole("Adding for Dat Pham Thanh ...");
		ToConsole (userTemp2);

		string query = "select * from User where ID = 3";
		var userQuery = UserDataController.QueryUser(query);
		ToConsole("Query for ID = 3 ...");
		ToConsole(userQuery);



	}
	
	private void ToConsole(IEnumerable<User> users){
		foreach (var user in users) {
			ToConsole(user.ToString());
		}
	}

	private void ToConsole(User users){
		ToConsole(users.ToString());
	}
	private void ToConsole(object users){
		ToConsole(users.ToString());
	}

	private void ToConsole(string msg){
		DebugText.text += System.Environment.NewLine + msg;
		Debug.Log (msg);
	}

}
