using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharSelect : MonoBehaviour
{

    public GameObject soldier1;
    public GameObject soldier2;
    public GameObject soldier3;
    public static Image mainChar;
    public Dialogue dl;
    public DialogueFund dlf; 
    

    public void click1(){

        Color diffcolor = soldier2.GetComponent<Image>().color;
        diffcolor = new Color(0, 0, 0, 1);
        soldier2.GetComponent<Image>().color = diffcolor;
        soldier3.GetComponent<Image>().color = diffcolor;

        Color objColor = soldier1.GetComponent<Image>().color;
        objColor = new Color(255, 255, 255, 1);
        soldier1.GetComponent<Image>().color = objColor;

        mainChar = soldier1.GetComponent<Image>();
    }

    public void click2(){

        Color diffcolor = soldier1.GetComponent<Image>().color;
        diffcolor = new Color(0, 0, 0, 1);
        soldier1.GetComponent<Image>().color = diffcolor;
        soldier3.GetComponent<Image>().color = diffcolor;
        
        Color objColor = soldier2.GetComponent<Image>().color;
        objColor = new Color(255, 255, 255, 1);
        soldier2.GetComponent<Image>().color = objColor;

        mainChar = soldier2.GetComponent<Image>();
    }

    
    public void click3(){

        Color diffcolor = soldier1.GetComponent<Image>().color;
        diffcolor = new Color(0, 0, 0, 1);
        soldier1.GetComponent<Image>().color = diffcolor;
        soldier2.GetComponent<Image>().color = diffcolor;
        
        Color objColor = soldier3.GetComponent<Image>().color;
        objColor = new Color(255, 255, 255, 1);
        soldier3.GetComponent<Image>().color = objColor;

        mainChar = soldier3.GetComponent<Image>();
    }

    public void decide(){
        dl.DialogueBox.SetActive(true);
        dlf.extra.SetActive(false);
        
        dlf.NextLine();
    }

}
