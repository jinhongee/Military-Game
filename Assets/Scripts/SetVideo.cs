using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class SetVideo : MonoBehaviour
{

    private RawImage mScreen = null;
    private VideoPlayer mVideoPlayer = null;
    private GameObject front;
    private string nextScene;
    private Image actObj;

    public void StartVideo(RawImage ms, VideoPlayer mvp, GameObject fr, string ns, Image ao)
    {
        mScreen = ms;
        mVideoPlayer = mvp;
        front = fr;
        nextScene = ns;
        actObj = ao;

        //mScreen = null;
        //mVideoPlayer = null;

        if (mScreen != null && mVideoPlayer != null)
        {
            // 비디오 준비 코루틴 호출
            StartCoroutine(PrepareVideo());
        }
    }
    

    protected IEnumerator PrepareVideo()
    {
        // 비디오 준비
        mVideoPlayer.Prepare();

        // 비디오가 준비되는 것을 기다림
        while (!mVideoPlayer.isPrepared)
        {
            yield return new WaitForSeconds(0.5f);
        }

        Color sc = front.GetComponent<Image>().color;
        Debug.Log("color change");
        front.GetComponent<Image>().color = new Color(sc.r, sc.g, sc.b, 0);
        
        Debug.Log("video start");
        // VideoPlayer의 출력 texture를 RawImage의 texture로 설정한다
        mScreen.texture = mVideoPlayer.texture;

        if(!nextScene.Equals("")){
            Invoke("loadNext", 5f);
        }

        if(actObj != null){
            Debug.Log("hi");
            yield return new WaitForSeconds(5f);
            actObj.enabled = true;
        }


        
    }

    void loadNext(){
        SceneManager.LoadScene(nextScene);
    }
    
}
