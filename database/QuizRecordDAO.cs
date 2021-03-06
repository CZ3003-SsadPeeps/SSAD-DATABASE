using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Database
{
    public class QuizRecordDAO : SqliteHelper
    {

        private const String TABLE_NAME = "Quiz";
        private const String KEY_QuizID = "QuizID";
        private const String KEY_Question = "Question";
        private const String KEY_Reward = "Reward";
        private const String KEY_Difficulty = "Difficulty";


        public QuizRecordDAO() : base()
        {
            IDbCommand dbcmd = getDbCommand();
            dbcmd.CommandText = "CREATE TABLE IF NOT EXISTS " + TABLE_NAME + " ( " +
                KEY_QuizID + " INT PRIMARY KEY, " +
                KEY_Question + " TEXT NOT NULL, " +
                KEY_Reward + " TEXT NOT NULL, " +
                KEY_Difficulty + " TEXT NOT NULL)";
            dbcmd.ExecuteNonQuery();
        }

        public void addData(QuizRecord quizRecord)
        {
            IDbCommand dbcmd = getDbCommand();
            dbcmd.CommandText =
                "INSERT INTO " + TABLE_NAME
                + " ( "
                + KEY_QuizID + ", "
                + KEY_Question + ", "
                + KEY_Reward + ", "
                + KEY_Difficulty + " ) "

                + "VALUES ( '"
                + quizRecord.QuizID + "', '"
                + quizRecord.Question + "', '"
                + quizRecord.Reward + "', '"
                + quizRecord.Difficulty + "' )";
            dbcmd.ExecuteNonQuery();
        }

    }
}