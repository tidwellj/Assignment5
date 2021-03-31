using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Save
{
    public List<int> livingTargetPositions = new List<int>();
    public List<int> livingTargetsTypes = new List<int>();

    
    public string name;
    public float time;
    public int lives;
    public string pSpeed;
    public int score;
}