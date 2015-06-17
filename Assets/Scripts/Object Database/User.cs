using SQLite4Unity3d;

public class User  {

	
	[PrimaryKey, AutoIncrement]
	public int ID { get; set; }
	public string UserName { get; set; }
	public int Age { get; set; }
	public string Company { get; set; }
	
	public override string ToString ()
	{
		return string.Format ("[Id: Id={0}, UserName={1},  Age={2}, Company={3}]", ID, UserName, Age, Company);
	}
}
