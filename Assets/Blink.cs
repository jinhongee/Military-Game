using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Blink : MonoBehaviour
{
    Text flashingText;
    // Start is called before the first frame update
    void Start()
    {
        flashingText = GetComponent<Text>();
        StartCoroutine(BlinkText());
    }

    public IEnumerator BlinkText(){
        while(true){
            flashingText.text = "";
            yield return new WaitForSeconds(.5f);
            flashingText.text = "시작하려면 화면을 터치하세요";
            yield return new WaitForSeconds(.5f);
        }
    }
}
