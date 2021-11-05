using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueTrain : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject DialogueBox;
    private int index;
    //public FadeToBlack fadeToBlack;
    //private int index;

    void Start(){
        textComponent.text = string.Empty;
        startDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            if(textComponent.text == lines[index]){
                NextLine();
            } else {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    public void startDialogue(){
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine(){ 
        foreach(char c in lines[index].ToCharArray()){
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void NextLine(){
        if(index < lines.Length-1){
            Debug.Log("index: "+index);
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        } 
        // else { 
        //     black.SetActive(true);
        //     StartCoroutine(fadeToBlack.turnBlack(black, scene));
        //     //DialogueBox.SetActive(false);
        // }
    }




}

