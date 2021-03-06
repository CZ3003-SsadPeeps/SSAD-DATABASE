using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizRecord
{
    public int QuizID;
    public string Question;
    public string Reward;
    public string Difficulty;

    public QuizRecord(int QuizID, string Question, string Reward, string Difficulty)
    {
        this.QuizID = QuizID;
        this.Question = Question;
        this.Reward = Reward;
        this.Difficulty = Difficulty;
    }
}
