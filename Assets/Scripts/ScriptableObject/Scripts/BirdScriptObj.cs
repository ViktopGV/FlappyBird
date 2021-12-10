using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Bird", menuName = "Script Obj/Bird")]
public class BirdScriptObj : ScriptableObject
{
    public string Name;
    public string Description;
    public Sprite RepresentBirdImage;
    public RuntimeAnimatorController AnimatorController;
}
