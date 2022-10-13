using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Face Part", menuName = "Face Component")]
public class SO_FaceComponent : ScriptableObject
{
    // Store string containing names of each part
    public string Name;

    // Store Sprite of component
    public Sprite component;

    // Store animation
    public int facePartAnimationID;

    // List Containing All Body Part Animations
    public List<AnimationClip> allfacePartAnimations = new List<AnimationClip>();
}
