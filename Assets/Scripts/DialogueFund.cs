<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueFund : MonoBehaviour
{
    private TextMeshProUGUI textComponent;
    private string[] lines;
    private float textSpeed;
    private GameObject DialogueBox;
    private GameObject selection;
    private GameObject black;
    private string scene;
    private int index;
    public FadeToBlack fadeToBlack;
    // Start is called before the first frame update
    public void InitiateProcess(TextMeshProUGUI tc, string[] ln, float ts, GameObject db, GameObject sl, GameObject bl, string sn)
    {
        textComponent = tc;
        lines = ln;
        textSpeed = ts;
        DialogueBox = db;
        selection = sl;
        black = bl;
        scene = sn;

        if(selection.activeSelf || black.activeSelf){
            selection.SetActive(false);
            black.SetActive(false);
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
            
            black.SetActive(true);
            StartCoroutine(fadeToBlack.turnBlack(black, scene));
            //DialogueBox.SetActive(false);
        }
    }

}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueFund : MonoBehaviour
{
    private TextMeshProUGUI textComponent;
    private string[] lines;
    private float textSpeed;
    private GameObject DialogueBox;
    private GameObject selection;
    private GameObject black;
    private string scene;
    private int index;
    public FadeToBlack fadeToBlack;
    // Start is called before the first frame update
    public void InitiateProcess(TextMeshProUGUI tc, string[] ln, float ts, GameObject db, GameObject sl, GameObject bl, string sn)
    {
        textComponent = tc;
        lines = ln;
        textSpeed = ts;
        DialogueBox = db;
        selection = sl;
        black = bl;
        scene = sn;

        if(selection.activeSelf || black.activeSelf){
            selection.SetActive(false);
            black.SetActive(false);
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
            
            black.SetActive(true);
            StartCoroutine(fadeToBlack.turnBlack(black, scene));
            //DialogueBox.SetActive(false);
        }
    }

}
>>>>>>> b542cb10d24c343a5ae4be3357a1cc393227706b
