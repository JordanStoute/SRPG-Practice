using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitStats : MonoBehaviour
{
    [SerializeField] int maxHP;
    [SerializeField] int strength;
    [SerializeField] int defense;
    [SerializeField] int speed;
    [SerializeField] int move;
    [SerializeField] int range;

    private int currentHP;

    public int CurrentHP
    {
        get
        {
            return currentHP;
        }
        set
        {
            currentHP = value;
        }
    }

    private void Start()
    {
        currentHP = maxHP;
    }
}
