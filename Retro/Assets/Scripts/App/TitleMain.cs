using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleMain : MonoBehaviour
{
    public Button btnTitle;

    // Start is called before the first frame update
    void Start()
    {
        btnTitle.onClick.AddListener(() => {
            SceneManager.LoadScene("HomeScene");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
