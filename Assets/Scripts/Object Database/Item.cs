using SQLite4Unity3d;

public class Item 
{

	[PrimaryKey, AutoIncrement]
	public int ID { get; set; }
	public int UserID { get; set; }
	public string ItemName { get; set; }
	public int Quantity { get; set; }

	
	public override string ToString ()
	{
		return string.Format ("[Id: Id={0}, UserID={1},  ItemName={2}, Quantity={3}]", ID, UserID, ItemName, Quantity);
	}
}
