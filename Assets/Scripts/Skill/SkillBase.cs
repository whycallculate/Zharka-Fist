using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class SkillBase : MonoBehaviour
{
    public SkillTypeTarget skillTypeTarget;
    public SkillTypeElemantal skillTypeElemantel;

    public float damage;
    public float cooldown;
    public float cost;

}
