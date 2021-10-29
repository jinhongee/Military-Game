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
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        if(selection.activeSelf){
            selection.SetActive(false);
        }
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

    void startDialogue(){
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
        if(index == 2){
            index++;
            DialogueBox.SetActive(false);
            selection.SetActive(true);
        } else if(index < lines.Length-1){
            Debug.Log("index: "+index);
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        } else {
            DialogueBox.SetActive(false);
            //selection.SetActive(true);
        }
    }
}
