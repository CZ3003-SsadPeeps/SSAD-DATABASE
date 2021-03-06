using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Database;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerRecord player1 = new PlayerRecord(5,"abc",123,123);
        PlayerRecord player2 = new PlayerRecord(6,"abc",123,123);
        PlayerRecordDAO a =  new PlayerRecordDAO();
        //a.deleteAllData();
        //EventRecord event1 = new EventRecord(13, "add money",100);
        //EventRecordDAO eventRecordDAO = new EventRecordDAO();
        //eventRecordDAO.addData(event1);

        // a.doNothing();
        a.addData(player1);
        a.addData(player2);
        List<PlayerRecord> players = a.RetrievePlayerRecords();
        foreach(PlayerRecord player in players)
        {
            Debug.Log(player.DateAchieved);
        }
        // // System.Data.IDataReader reader = a.getDataByString("1");
        // // while(reader.Read())
        // // {
        // //     Debug.Log(reader[1].ToString());
        // // }

        // // Delete  all data
        // // a.deleteAllData();
        // a.deleteDataByString("1");

        // Stock stock1 = new Stock("Tesla",1000,200,(float) 5.50);
        // Stock stock2 = new Stock("GME",1000,200,(float) 5.50);
        // Stock[] stocks = new Stock[2];
        // stocks[0]=stock1;
        // stocks[1]=stock2;
        // StockDAO b = new StockDAO();
        // b.StoreStock(stocks);
        // List<Stock> stocks = b.RetrieveStocks();
        // foreach(Stock stock in stocks)
        // {
        //     Debug.Log(stock.companyName);
        // }
        // b.doNothing();
        // b.addData(stock1); 
        // System.Data.IDataReader reader = b.getDataByString("Tesla");
        // while(reader.Read())
        // {
        //     Debug.Log(reader[1].ToString());
        // }
        //b.deleteDataByString("Tesla");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
