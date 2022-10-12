using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Script to save sprites from selection and render them in meeting room.
public class SaveFace : MonoBehaviour
{
    [SerializeField] private GameObject MRbaseSprite;
    private SpriteRenderer MRbaseRenderer;
    [SerializeField] private GameObject MRhairSprite;
    private SpriteRenderer MRhairRenderer;
    [SerializeField] private GameObject MRnoseSprite;
    private SpriteRenderer MRnoseRenderer;
    [SerializeField] private GameObject MRexprSprite;
    private SpriteRenderer MRexprRenderer;
    [SerializeField] private GameObject MRshirtSprite;
    private SpriteRenderer MRshirtRenderer;

    [SerializeField] private SO_Face faceSaved;


    // Start is called before the first frame update
    void Start()
    {
        MRbaseRenderer = MRbaseSprite.GetComponent<SpriteRenderer>();
        MRhairRenderer = MRhairSprite.GetComponent<SpriteRenderer>();
        MRnoseRenderer = MRnoseSprite.GetComponent<SpriteRenderer>();
        MRexprRenderer = MRexprSprite.GetComponent<SpriteRenderer>();
        MRshirtRenderer = MRshirtSprite.GetComponent<SpriteRenderer>();

        MRbaseRenderer.sprite = faceSaved.faceComponents[0].faceComponent.component;
        MRhairRenderer.sprite = faceSaved.faceComponents[4].faceComponent.component;
        MRnoseRenderer.sprite = faceSaved.faceComponents[2].faceComponent.component;
        MRexprRenderer.sprite = faceSaved.faceComponents[3].faceComponent.component;
        MRshirtRenderer.sprite = faceSaved.faceComponents[1].faceComponent.component;
        
    }

    void Update() 
    {
        MRbaseRenderer.sprite = faceSaved.faceComponents[0].faceComponent.component;
        MRhairRenderer.sprite = faceSaved.faceComponents[4].faceComponent.component;
        MRnoseRenderer.sprite = faceSaved.faceComponents[2].faceComponent.component;
        MRexprRenderer.sprite = faceSaved.faceComponents[3].faceComponent.component;
        MRshirtRenderer.sprite = faceSaved.faceComponents[1].faceComponent.component;
    }

}
