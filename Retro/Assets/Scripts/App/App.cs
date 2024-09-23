using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class App : MonoBehaviour
{
    //App : 게임에 들어가기 전에 실행해야 할 것들. 게임이 끝날때까지 살아있음
    //새로운 씬이 로딩되면 이전 씬의 모든 것들의 메모리 해제, App을 살려놓기 위해 Object.DontDestroyOnLoad 사용

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        SceneManager.LoadScene("TitleScene");

        Debug.Log("타이틀 씬 로드 완료");
    }
}
