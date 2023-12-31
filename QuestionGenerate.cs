using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer; // correct answer
    public bool displayingQuestion = false; // question is not currently displayed

    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            QuestionDisplay.newQuestion = "What is produced in the mitochondria?";
            QuestionDisplay.newA = "DNA";
            QuestionDisplay.newB = "ATP";
            QuestionDisplay.newC = "RNA";
            QuestionDisplay.newD = "Cholesterol";
            actualAnswer = "B";
        }
    }
}
