using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Database;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // PlayerRecord player1 = new PlayerRecord(1,"abc",123,"date1");
        // PlayerRecordDAO a =  new PlayerRecordDAO();
        // //a.addData(player1);
        // // System.Data.IDataReader reader = a.getDataByString("1");
        // // while(reader.Read())
        // // {
        // //     Debug.Log(reader[1].ToString());
        // // }

        // // Delete  all data
        // // a.deleteAllData();
        // a.deleteDataByString("1");

        Stock stock1 = new Stock("Tesla",1000,200,(float) 5.50);
        StockDAO b = new StockDAO();
        // b.addData(stock1); 
        // System.Data.IDataReader reader = b.getDataByString("Tesla");
        // while(reader.Read())
        // {
        //     Debug.Log(reader[1].ToString());
        // }
        b.deleteDataByString("Tesla");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
