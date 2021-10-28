using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeAway : MonoBehaviour
{
    public GameObject BlackOut;
    float fadeAmount;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            StartCoroutine(turnBlack());
        }
    }

    public IEnumerator turnBlack(int fadeSpeed = 1){
        Color objectColor = BlackOut.GetComponent<Image>().color;
        //float transparency = 0;

        while(BlackOut.GetComponent<Image>().color.a < 1){
            fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);
            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            BlackOut.GetComponent<Image>().color = objectColor;
            yield return null;
        }

        SceneManager.LoadScene("Prologue");
    }

}
