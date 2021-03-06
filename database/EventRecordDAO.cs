using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Database
{
    public class EventRecordDAO : SqliteHelper
    {

        private const String TABLE_NAME = "Event";
        private const String KEY_EventID = "EventID";
        private const String KEY_Content = "Content";
        private const String KEY_Amount = "Amount";


        public EventRecordDAO() : base()
        {
            IDbCommand dbcmd = getDbCommand();
            dbcmd.CommandText = "CREATE TABLE IF NOT EXISTS " + TABLE_NAME + " ( " +
                KEY_EventID + " INT PRIMARY KEY, " +
                KEY_Content + " TEXT NOT NULL, " +
                KEY_Amount + " INT NOT NULL)";
            dbcmd.ExecuteNonQuery();
        }

        public void addData(EventRecord eventRecord)
        {
            IDbCommand dbcmd = getDbCommand();
            dbcmd.CommandText =
                "INSERT INTO " + TABLE_NAME
                + " ( "
                + KEY_EventID + ", "
                + KEY_Content + ", "
                + KEY_Amount + " ) "

                + "VALUES ( '"
                + eventRecord.EventID + "', '"
                + eventRecord.Content + "', '"
                + eventRecord.Amount + "' )";
            dbcmd.ExecuteNonQuery();
        }

    }
}