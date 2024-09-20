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
            Debug.Log("���ڵ� ���� �Ϸ�");
            
        };
        blackKnight.onAttackComplete = () => {
            Debug.Log("�� ���� �Ϸ�");
        };

        lizardWarrior.Attack();
        blackKnight.Attack();
    }
}
