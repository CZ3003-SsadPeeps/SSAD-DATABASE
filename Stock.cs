using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stock
{
    public string companyName;
    public int total;
    public int shares;
    public float price;

    public Stock(string companyName, int total, int shares, float price)
    {
        this.companyName=companyName;
        this.total=total;
        this.shares=shares;
        this.price=price;
    }
}
