using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] LizardWarrior lizardWarrior;
    [SerializeField] BlackKnight blackKnight;

    void Start()
    {
        lizardWarrior.Init(1.067f);
        blackKnight.Init(0.933f);

        lizardWarrior.onAttackComplete = () => {
            Debug.Log("리자드 공격 완료");
            
        };
        blackKnight.onAttackComplete = () => {
            Debug.Log("블랙 공격 완료");
        };

        lizardWarrior.Attack();
        blackKnight.Attack();
    }
}
