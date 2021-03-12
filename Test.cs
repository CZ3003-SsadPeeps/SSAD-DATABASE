using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Database;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // PlayerRecord player1 = new PlayerRecord(5,"abc",123,123);
        // PlayerRecord player2 = new PlayerRecord(6,"abc",123,123);
        PlayerRecordDAO a =  new PlayerRecordDAO();
        // //a.deleteAllData();
        // //EventRecord event1 = new EventRecord(13, "add money",100);
        // //EventRecordDAO eventRecordDAO = new EventRecordDAO();
        // //eventRecordDAO.addData(event1);

        // // a.doNothing();
        // a.addData(player1);
        // a.addData(player2);
        // List<PlayerRecord> players = a.RetrievePlayerRecords();
        List<PlayerRecord> players = a.getDataByString("5");
        foreach(PlayerRecord player in players)
        {
            Debug.Log(player.DateAchieved);
        }

        // // Delete  all data
        // a.deleteAllData();
        // a.deleteDataByString("1");

        // StockDAO b = new StockDAO();
        // b.deleteAllData();

        // b.StoreStock(stocks);

        // Stock stock1 = new Stock("Tesla",1000,200,1,(float) 5.50);
        // Stock stock2 = new Stock("Tesla",1000,200,2,(float) 5.50);
        // Stock stock3 = new Stock("GME",1000,200,1,(float) 5.50);
        // Stock[] stocks = new Stock[3];
        // stocks[0]=stock1;
        // stocks[1]=stock2;
        // stocks[2]=stock3;
        // b.StoreStock(stocks);

        // List<Stock> res = b.RetrieveStocks();
        // List<Stock> res = b.getDataByString("Tesla");
        // foreach(Stock stock in res)
        // {
        //     Debug.Log(stock.companyName);
        // }
        // b.doNothing();
        // b.deleteDataByString("Tesla");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
