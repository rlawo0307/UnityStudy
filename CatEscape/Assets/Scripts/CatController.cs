using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatController : MonoBehaviour
{
    public Button btnR;

    void Start()
    {
        //btnR.onClick.AddListener(RightButtonClick); // AddListener : �븮�� ����
        btnR.onClick.AddListener(() => { // ���ٿ����ڷ� �͸� �޼��� ���
            Debug.Log("������ ��ư Ŭ����");

            this.transform.Translate(1, 0, 0);
        }); 

    }

    public void LeftButtonClick()
    {
        Debug.Log("���� ��ư Ŭ����");
        this.transform.Translate(-1, 0, 0);
    }

    public void RightButtonClick()
    {
        Debug.Log("������ ��ư Ŭ����");
    }
}
