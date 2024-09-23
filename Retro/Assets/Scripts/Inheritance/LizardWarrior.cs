using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LizardWarrior : Monster
{
    public override void Attack()
    {
        Debug.Log("기를 모읍니다");
        base.Attack();
    }
}
