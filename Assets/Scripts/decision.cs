using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class decision : MonoBehaviour
{
    public GameObject alert;
    public Dialogue dl;
    public DialogueFund dlf; 
    public GameObject displayMs;
    public GameObject select;
    public GameObject back;
    public GameObject selection;
    private string message;
    // Start is called before the first frame update
    public void ready(string message){
        this.message = message;
        displayMs.GetComponent<Text>().text = message;
        alert.SetActive(true);
    }

    public void clickSelect(){
        dl.DialogueBox.SetActive(true);
        dlf.extra.SetActive(false);
        alert.SetActive(false);
        selection.SetActive(false);
        
        dlf.NextLine();
    }

    public void clickBack(){
        alert.SetActive(false);
    }

}
