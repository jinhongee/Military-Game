using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Vid1 : MonoBehaviour
{
    public RawImage mScreen = null;
    public VideoPlayer mVideoPlayer = null;
    public GameObject front;
    public GameObject dialoguebox;
    public Image bed;
    public SetVideo sv;

    
    void Start()
    {
        if(bed.enabled == true || dialoguebox.activeSelf){
            bed.enabled = false;
            dialoguebox.SetActive(false);
        }
        sv.StartVideo(mScreen, mVideoPlayer, front, "", bed);
    }
}
