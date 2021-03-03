using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRecord
{
    public int PlayerID;
    public string Name;
    public float CreditEarned;
    public string DateAchieved;

    public PlayerRecord(int ID, string name, float credit, string dateAchieved)
    {
        this.PlayerID=ID;
        this.Name = name;
        this.CreditEarned = credit;
        this.DateAchieved = dateAchieved;
    }
}
