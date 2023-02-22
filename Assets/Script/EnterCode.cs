using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EnterCode : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Ans;
    public int randomAnswer;
    [SerializeField] string Answer = "";
    [SerializeField] GameObject childObject;
    [SerializeField] Timer decreaseTime;

    [SerializeField] GameObject disableQACanvas;
    [SerializeField] GameObject enableASCanvas;

    public float delay = 2.0f;

    private void Start()
    {
        decreaseTime.GetComponent<Timer>();
    }
    private void Awake()
    {
        randomAnswer = Random.Range(1000, 9999);
        Answer = randomAnswer.ToString();
    }
    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    public void Execute()
    {
        if(Ans.text == Answer)
        {
            Ans.text = "Correct!";
            disableQACanvas.SetActive(false);
            enableASCanvas.SetActive(true);
        }
        else
        {
            Ans.text = "Retry!";
            Invoke("BackOut", delay);
            decreaseTime.decreaseTime();
        }
    }

    public void BackOut()
    {
        childObject.SetActive(false);
        Ans.text = "";
    }

    //For the bomb
    public void correctCode()
    {
        SceneManager.LoadScene("");
    }
}
