using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Database
{
    public class PlayerRecordDAO : SqliteHelper
    {

        private const String TABLE_NAME = "PlayerRecord";
        private const String KEY_PlayerID = "PlayerID";
        private const String KEY_Name= "Name";
        private const String KEY_DateAchieved = "DateAchieved";
        private const String KEY_CreditEarned = "CreditEarned";

        public PlayerRecordDAO() : base()
        {
            IDbCommand dbcmd = getDbCommand();
            dbcmd.CommandText = "CREATE TABLE IF NOT EXISTS " + TABLE_NAME + " ( " +
                KEY_PlayerID + " INT PRIMARY KEY, " +
                KEY_Name + " TEXT NOT NULL, "+
                KEY_DateAchieved + " TEXT NOT NULL, " +
                KEY_CreditEarned + " REAL NOT NULL)";
            dbcmd.ExecuteNonQuery();
        }

        public void addData(PlayerRecord player)
        {
            IDbCommand dbcmd = getDbCommand();
            dbcmd.CommandText =
                "INSERT INTO " + TABLE_NAME
                + " ( "
                + KEY_PlayerID + ", "
                + KEY_Name + ", "
                + KEY_DateAchieved + ", "
                + KEY_CreditEarned + " ) "

                + "VALUES ( '"
                + player.PlayerID + "', '"
                + player.Name + "', '"
                + player.DateAchieved + "', '"
                + player.CreditEarned + "' )";
            dbcmd.ExecuteNonQuery();

        }

        public override IDataReader getDataByString(string str)
        	{
            		Debug.Log(Tag + "Getting Location: " + str);

            		IDbCommand dbcmd = getDbCommand();
            		dbcmd.CommandText =
                		"SELECT * FROM " + TABLE_NAME + " WHERE " + KEY_PlayerID + " = '" + str + "'";
            		return dbcmd.ExecuteReader();
        	}
    }
}