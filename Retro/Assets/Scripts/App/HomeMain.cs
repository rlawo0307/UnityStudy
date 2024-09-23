using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeMain : MonoBehaviour
{
    public Button btnRed;
    public Button btnBlue;
    public Button btnStart;

    void Start()
    {
        this.btnRed.onClick.AddListener(() => {
            Debug.Log("레드 버튼이 선택되었습니다");
        });
        this.btnBlue.onClick.AddListener(() => {
            Debug.Log("레드 버튼이 선택되었습니다");
        });
        this.btnStart.onClick.AddListener(() => {
            //SceneManager.LoadScene("GameScene");
            AsyncOperation oper = SceneManager.LoadSceneAsync("GameScene");
            oper.completed += (obj) => { // 로드 완료가되면
                GameObject go = GameObject.Find("GameMain"); // 이름으로 찾지 말고 FindAnyObjectByType 사용
                Debug.Log(go);
                //go.Init();
            };
        });
    }

    void Update()
    {
        
    }
}
