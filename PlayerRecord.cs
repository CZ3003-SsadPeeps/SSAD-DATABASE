public class PlayerRecord
{
    public int PlayerID { get; }

    public string Name { get; }

    public int CreditEarned { get; }

    public long DateAchieved { get; }

    public PlayerRecord(int ID = -1, string name, int credit, long dateAchieved)
    {
        this.PlayerID = ID;
        this.Name = name;
        this.CreditEarned = credit;
        this.DateAchieved = dateAchieved;
    }
}
