using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeAway : MonoBehaviour
{
    public GameObject BlackOut;
    public FadeToBlack fadeToBlack;
    //float fadeAmount;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            StartCoroutine(fadeToBlack.turnBlack(BlackOut, "Prologue"));
        }
    }

}
