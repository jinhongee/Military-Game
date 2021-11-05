using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectFirst : MonoBehaviour
{
    
    public Dialogue dl;
    public DialogueFund dlf; 
    public static int route;
    public decision alert;
    public void path1(){
        route = 1;
        alert.ready("[우수한 병사] 선택지를 고르셨습니다.\n이 결정은 앞으로의 군생활을 결정지으니 신중히 선택해주십시오\n결정하겠습니까?");
    }

    public void path2(){
        route = 2;
        alert.ready("[평범한 병사] 선택지를 고르셨습니다.\n이 결정은 앞으로의 군생활을 결정지으니 신중히 선택해주십시오\n결정하겠습니까?");
    }

    public void path3(){
        route = 3;
        alert.ready("[폐급 병사] 선택지를 고르셨습니다.\n이 결정은 앞으로의 군생활을 결정지으니 신중히 선택해주십시오\n결정하겠습니까?");
    }
}
