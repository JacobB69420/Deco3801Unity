using UnityEngine;
using UnityEngine.UI;

public class FaceSelector : MonoBehaviour
{   
    // First we are required to specify required face object and current selections

    // Full Face
    [SerializeField] private SO_Face face;
    // Face Selections
    [SerializeField] private FaceSelection[] faceSelections;


    // Start is called before the first frame update
    private void Start()
    {
        // Get All Current Body Parts
        for (int i = 0; i < faceSelections.Length; i++)
        {
            GetCurrentFaceParts(i);
        }
    }

    public void NextBodyPart(int partIndex)
    {
        if (ValidateIndexValue(partIndex))
        {
            if (faceSelections[partIndex].facePartCurrentIndex < faceSelections[partIndex].faceOptions.Length - 1)
            {
                faceSelections[partIndex].facePartCurrentIndex++;
            }
            else
            {
                faceSelections[partIndex].facePartCurrentIndex = 0;
            }

            UpdateCurrentPart(partIndex);
        }
    }

    public void PreviousBody(int partIndex)
    {
        if (ValidateIndexValue(partIndex))
        {
            if (faceSelections[partIndex].facePartCurrentIndex > 0)
            {
                faceSelections[partIndex].facePartCurrentIndex--;
            }
            else
            {
                faceSelections[partIndex].facePartCurrentIndex = faceSelections[partIndex].faceOptions.Length - 1;
            }

            UpdateCurrentPart(partIndex);
        }    
    }

    private bool ValidateIndexValue(int partIndex)
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

    private void UpdateCurrentPart(int partIndex)
    {
        // Update Selection Name Text
        faceSelections[partIndex].facePartTextComponent.text = faceSelections[partIndex].faceOptions[faceSelections[partIndex].facePartCurrentIndex].Name;
        // Update Character Body Part
        face.faceComponents[partIndex].faceComponent = faceSelections[partIndex].faceOptions[faceSelections[partIndex].facePartCurrentIndex];
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