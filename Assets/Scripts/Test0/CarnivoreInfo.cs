using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CarnivoreInfo : AnimalInfo
{
    public int damage;
    //������
    public CarnivoreInfo(string name, int type, int moveSpeed, int damage) : base(name, type, moveSpeed)
    {
        this.damage = damage;
    }

}
