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
    public GameObject dialogueBox;
    private int index;
    //public FadeToBlack fadeToBlack;
    //private int index;

    void Start()
    {    
        textComponent.text = string.Empty;
        Debug.Log("call");
        //StartCoroutine(startDialogue());
        index = -1;
        Debug.Log("end");
    }

    // Update is called once per frame
    void Update()
    {
        if(index==-1 && dialogueBox.activeSelf){
            index = 0;
            StartCoroutine(TypeLine());
        }
        if(Input.GetMouseButtonDown(0)){
            if(textComponent.text == lines[index]){
                NextLine();
            } else {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    // IEnumerator startDialogue(){
    //     index = 0;
    //     yield return new WaitForSeconds(7f);
    //     StartCoroutine(TypeLine());
    // }

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

