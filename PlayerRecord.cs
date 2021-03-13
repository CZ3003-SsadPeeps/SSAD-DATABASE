using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRecord
{
    public int PlayerID { get; set; }
    public string Name { get; set; }
    public float CreditEarned { get; set; }
    public long DateAchieved { get; set; }

    public PlayerRecord(int ID, string name, float credit, long dateAchieved)
    {
        this.PlayerID=0;
        this.Name = name;
        this.CreditEarned = credit;
        this.DateAchieved = dateAchieved;
    }
}
