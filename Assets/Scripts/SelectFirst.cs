using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectFirst : MonoBehaviour
{
    
    public Dialogue dl;
    public DialogueFund dlf; 
    public void path(){
        
        
        dl.DialogueBox.SetActive(true);
        dl.selection.SetActive(false);
        
        dlf.NextLine();
        
        /*
        dl.GetComponent<Dialogue>().DialogueBox.SetActive(true);
        dl.GetComponent<Dialogue>().selection.SetActive(false);
        
        dl.GetComponent<Dialogue>().NextLine();
        */
        
    }
}
