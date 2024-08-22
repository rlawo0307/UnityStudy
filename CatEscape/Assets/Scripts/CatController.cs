using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatController : MonoBehaviour
{
    public Button btnR;

    void Start()
    {
        //btnR.onClick.AddListener(RightButtonClick); // AddListener : 대리자 형식
        btnR.onClick.AddListener(() => { // 람다연산자로 익명 메서드 사용
            Debug.Log("오른쪽 버튼 클릭됨");

            this.transform.Translate(1, 0, 0);
        }); 

    }

    public void LeftButtonClick()
    {
        Debug.Log("왼쪽 버튼 클릭됨");
        this.transform.Translate(-1, 0, 0);
    }

    public void RightButtonClick()
    {
        Debug.Log("오른쪽 버튼 클릭됨");
    }
}
