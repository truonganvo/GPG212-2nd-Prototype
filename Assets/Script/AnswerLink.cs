using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnswerLink : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI answForTheBomb;
    [SerializeField] EnterCode enterCode;


    private void Update()
    {
        enterCode.GetComponent<EnterCode>();
        LinkingTheAnswer();
    }

    private void LinkingTheAnswer()
    {
        answForTheBomb.text = enterCode.randomAnswer.ToString();
    }

}
