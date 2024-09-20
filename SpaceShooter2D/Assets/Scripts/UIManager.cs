using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] GameObject enemyAGo;

    // Start is called before the first frame update
    void Start()
    {
        enemyAGo.onChangeState= (score) => {
            scoreText.text = score..ToString();
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
