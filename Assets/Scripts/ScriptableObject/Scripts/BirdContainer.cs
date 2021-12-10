using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Bird Container", menuName = "Script Obj/Bird Container")]
public class BirdContainer : ScriptableObject
{
    [SerializeField] private List<BirdScriptObj> _birds;
    public int Count => _birds.Count;

    public BirdScriptObj this[int index]
    {
        get => _birds[index];
    }
}
