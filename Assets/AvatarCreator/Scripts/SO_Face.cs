using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Face", menuName = "Face")]
public class SO_Face : ScriptableObject
{
// Holds details about Face component
public FacePart[] faceComponents;
}
[System.Serializable]
public class FacePart
{
    public string Name;
    public SO_FaceComponent faceComponent;
}

