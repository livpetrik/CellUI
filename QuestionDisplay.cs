using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuestionDisplay : MonoBehaviour
{
    public GameObject screenQuestion;
    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;
    public static string newQuestion;
    public static string newA;
    public static string newB;
    public static string newC;
    public static string newD;

    void Start()
    {
        screenQuestion.GetComponent<TMPro.TextMeshProUGUI>().text = "What is produced in the mitochondria?"; 
        answerA.GetComponent<Text>().text = "Ribosomes";
        answerB.GetComponent<Text>().text = "ATP";
        answerC.GetComponent<Text>().text = "Daughter Cells";
    }

    void Update()
    {
        
    }
}
