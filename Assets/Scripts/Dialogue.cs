using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject DialogueBox;
    public GameObject selection;
    public GameObject black;
    //public FadeToBlack fadeToBlack;
    //private int index;

    public DialogueFund dialogueFund;
    private string scene = "Training";


    // Start is called before the first frame update
    void Start()
    {
        dialogueFund.InitiateProcess(textComponent, lines, textSpeed, DialogueBox, selection, black, scene);
    }

    
}
