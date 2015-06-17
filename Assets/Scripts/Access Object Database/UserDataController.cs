using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class UserDataController 
{


	#region Access User Table

	public static IEnumerable<User> GetUsers(){
		return DataService.UserDBQuery().connection.Table<User>();;
	}

	
	public static IEnumerable<User> GetUsersByName(string name){
		return DataService.UserDBQuery().connection.Table<User>().Where(x => x.UserName == name);
	}
	
	
	public static User GetUserByName(string name){
		return DataService.UserDBQuery().connection.Table<User>().Where(x => x.UserName == name).FirstOrDefault();
	}
	
	public static User InsertUser(User user)
	{
		DataService.UserDBQuery().connection.Insert (user);
		return user;
	}
	
	public static User UpdateUser(User user)
	{
		DataService.UserDBQuery().connection.Update(user);
		return user;
	}
	public static User DeleteUser(User user)
	{
		DataService.UserDBQuery().connection.Delete(user);
		return user;
	}
	
	public static IEnumerable<User> QueryUser (string queryString)
	{
		return DataService.UserDBQuery().connection.Query<User> (queryString,"");
	}
	
	#endregion


}
