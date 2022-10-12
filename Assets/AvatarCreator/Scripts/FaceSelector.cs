using UnityEngine;
using UnityEngine.UI;

public class FaceSelector : MonoBehaviour
{   
    // First we are required to specify required face object and current selections

    // Full Face
    [SerializeField] private SO_Face face;
    // Face Selections
    [SerializeField] private FaceSelection[] faceSelections;

    // Game objects and renderers
    [SerializeField] private GameObject baseSprite;
    private SpriteRenderer baseRenderer;
    [SerializeField] private GameObject hairSprite;
    private SpriteRenderer hairRenderer;
    [SerializeField] private GameObject noseSprite;
    private SpriteRenderer noseRenderer;
    [SerializeField] private GameObject exprSprite;
    private SpriteRenderer exprRenderer;
    [SerializeField] private GameObject shirtSprite;
    private SpriteRenderer shirtRenderer;
    
    // Start is called before the first frame update
    private void Start()
    {
        // Get All Current Body Parts
        for (int i = 0; i < faceSelections.Length; i++)
        {
            GetCurrentFaceParts(i);
        }
        // Initialise all sprite renderer objects
        baseRenderer = baseSprite.GetComponent<SpriteRenderer>();
        hairRenderer = hairSprite.GetComponent<SpriteRenderer>();
        noseRenderer = noseSprite.GetComponent<SpriteRenderer>();
        exprRenderer = exprSprite.GetComponent<SpriteRenderer>();
        shirtRenderer = shirtSprite.GetComponent<SpriteRenderer>();
    }

    public void NextFacePart(int partIndex)
    {
        if (ValidateFaceIndexValue(partIndex))
        {
            if (faceSelections[partIndex].facePartCurrentIndex < faceSelections[partIndex].faceOptions.Length - 1)
            {
                faceSelections[partIndex].facePartCurrentIndex++;
            }
            else
            {
                faceSelections[partIndex].facePartCurrentIndex = 0;
            }

            UpdateCurrentfacePart(partIndex);
        }
    }

    public void PreviousFace(int partIndex)
    {
        if (ValidateFaceIndexValue(partIndex))
        {
            if (faceSelections[partIndex].facePartCurrentIndex > 0)
            {
                faceSelections[partIndex].facePartCurrentIndex--;
            }
            else
            {
                faceSelections[partIndex].facePartCurrentIndex = faceSelections[partIndex].faceOptions.Length - 1;
            }

            UpdateCurrentfacePart(partIndex);
        }    
    }

    private bool ValidateFaceIndexValue(int partIndex)
    {
        if (partIndex > faceSelections.Length || partIndex < 0)
        {
            Debug.Log("Index value does not match any face components!");
            return false;
        }
        else
        {
            return true;
        }
    }

    private void GetCurrentFaceParts(int partIndex)
    {
        // Get Current Face Part Name
        faceSelections[partIndex].facePartTextComponent.text = face.faceComponents[partIndex].faceComponent.Name;
        // Get Current Face Part Animation ID
        faceSelections[partIndex].facePartCurrentIndex = face.faceComponents[partIndex].faceComponent.facePartAnimationID;
    }

    private void UpdateCurrentfacePart(int partIndex)
    {
        // Update Selection Name Text
        faceSelections[partIndex].facePartTextComponent.text = faceSelections[partIndex].faceOptions[faceSelections[partIndex].facePartCurrentIndex].Name;
        // Update Character Body Part
        face.faceComponents[partIndex].faceComponent = faceSelections[partIndex].faceOptions[faceSelections[partIndex].facePartCurrentIndex];
        // Update Sprite
        if(partIndex == 0)
        {baseRenderer.sprite = face.faceComponents[partIndex].faceComponent.component;}
        if(partIndex == 1)
        {shirtRenderer.sprite = face.faceComponents[partIndex].faceComponent.component;}
        if(partIndex == 2)
        {noseRenderer.sprite = face.faceComponents[partIndex].faceComponent.component;}
        if(partIndex == 3)
        {exprRenderer.sprite = face.faceComponents[partIndex].faceComponent.component;}
        if(partIndex == 4)
        {hairRenderer.sprite = face.faceComponents[partIndex].faceComponent.component;}
    }
}

// Class to represent current face selection
[System.Serializable]
public class FaceSelection
{
    public string faceComponentName;
    public SO_FaceComponent[] faceOptions;
    public Text facePartTextComponent;
    [HideInInspector] public int facePartCurrentIndex;
}