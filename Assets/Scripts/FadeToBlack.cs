using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeToBlack : MonoBehaviour
{
    private float fadeAmount;
    public IEnumerator turnBlack(GameObject gmo, string str, int fadeSpeed = 1){
        Color objectColor = gmo.GetComponent<Image>().color;
        //float transparency = 0;

        while(gmo.GetComponent<Image>().color.a < 1){
            fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);
            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            gmo.GetComponent<Image>().color = objectColor;
            yield return null;
        }
        if(!str.Equals("")){
            SceneManager.LoadScene(str);
        }
    }
}
