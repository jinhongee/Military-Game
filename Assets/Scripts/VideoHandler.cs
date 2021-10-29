using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoHandler : MonoBehaviour
{
    public RawImage mScreen = null;
    public VideoPlayer mVideoPlayer = null;
    public GameObject front;
    public SetVideo sv;

    
    void Start()
    {
        sv.StartVideo(mScreen, mVideoPlayer, front, "Intro", null);
    }
    

    /*
    public void PlayVideo()
    {
        if (mVideoPlayer != null && mVideoPlayer.isPrepared)
        {
            // 비디오 재생
            Debug.Log("start now");
            mVideoPlayer.Play();
        }
    }

    public void StopVideo()
    {
        if (mVideoPlayer != null && mVideoPlayer.isPrepared)
        {
            // 비디오 멈춤
            mVideoPlayer.Stop();
        }
    }
    */
}
