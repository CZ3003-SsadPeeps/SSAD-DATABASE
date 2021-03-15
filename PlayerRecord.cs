public class PlayerRecord
{
    public int PlayerID { get; set; }

    public string Name { get; set; }

    public int CreditEarned { get; set; }

    public long DateAchieved { get; set; }

    public PlayerRecord(int ID = -1, string name, int credit, long dateAchieved)
    {
        this.PlayerID = ID;
        this.Name = name;
        this.CreditEarned = credit;
        this.DateAchieved = dateAchieved;
    }
}
