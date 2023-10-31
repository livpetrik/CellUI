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
        StartCoroutine(PushTextOnScreen());
    }

    void Update()
    {
        
    }
    IEnumerator PushTextOnScreen()
    {
        yield return new WaitForSeconds(0.25f); // decimal has to have f after
        screenQuestion.GetComponent<TMPro.TextMeshProUGUI>().text = newQuestion; 
        answerA.GetComponent<TMPro.TextMeshProUGUI>().text = newA;
        answerB.GetComponent<TMPro.TextMeshProUGUI>().text = newB;
        answerC.GetComponent<TMPro.TextMeshProUGUI>().text = newC;
        answerD.GetComponent<TMPro.TextMeshProUGUI>().text = newD;
    }
}
