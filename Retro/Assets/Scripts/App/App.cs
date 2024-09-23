using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class App : MonoBehaviour
{
    //App : ���ӿ� ���� ���� �����ؾ� �� �͵�. ������ ���������� �������
    //���ο� ���� �ε��Ǹ� ���� ���� ��� �͵��� �޸� ����, App�� ������� ���� Object.DontDestroyOnLoad ���

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        SceneManager.LoadScene("TitleScene");

        Debug.Log("Ÿ��Ʋ �� �ε� �Ϸ�");
    }
}
