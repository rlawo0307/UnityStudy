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
            Debug.Log("���� ��ư�� ���õǾ����ϴ�");
        });
        this.btnBlue.onClick.AddListener(() => {
            Debug.Log("���� ��ư�� ���õǾ����ϴ�");
        });
        this.btnStart.onClick.AddListener(() => {
            //SceneManager.LoadScene("GameScene");
            AsyncOperation oper = SceneManager.LoadSceneAsync("GameScene");
            oper.completed += (obj) => { // �ε� �Ϸᰡ�Ǹ�
                GameObject go = GameObject.Find("GameMain"); // �̸����� ã�� ���� FindAnyObjectByType ���
                Debug.Log(go);
                //go.Init();
            };
        });
    }

    void Update()
    {
        
    }
}
