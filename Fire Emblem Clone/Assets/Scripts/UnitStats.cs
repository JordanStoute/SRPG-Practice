using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UnitStats : MonoBehaviour
{
    [SerializeField] protected int maxHP;
    [SerializeField] protected int strength;
    [SerializeField] protected int defense;
    [SerializeField] protected int speed;
    [SerializeField] protected int move;
    [SerializeField] protected int range;

    public int currentHP;
}
