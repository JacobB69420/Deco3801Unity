using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarPartManager : MonoBehaviour
{

    private Sprite[] Skin;
    private Sprite[] Hairstyle;
    private Sprite[] Expression;
    private Sprite[] Face;

    [SerializeField] private Sprite[] spriteParts;

    // Start is called before the first frame update
    void Start()
    {
        spriteParts = Resources.LoadAll<Sprite>("Assets/AvatarCreator/Sprites/character-spritesheet-v1.0.png");
        Debug.Log(spriteParts);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
