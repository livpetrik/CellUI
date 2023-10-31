using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuestionDisplay : MonoBehaviour
{
    public GameObject screenQuestion; // question text
    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    void Start()
    {
        screenQuestion.GetComponent<Text>().text = "What is produced in the mitochondria?";
        answerA.GetComponent<Text>().text = "Ribosomes";
        answerB.GetComponent<Text>().text = "ATP";
        answerC.GetComponent<Text>().text = "Daughter Cells";
    }

    void Update()
    {
        
    }
}