using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Script to control Button UI. Uses unity scene management to direct players to required scene

public class ButtonUI : MonoBehaviour
{
    // Create Serialized fields to hold the correct scene to change to
    [SerializeField] private string toCommonRoom = "Common Room";
    [SerializeField] private string toMeetingRoom = "Meeting Room";
    [SerializeField] private string toCreator = "CharacterCreator";
    [SerializeField] private string toOverworld = "Overworld";
    [SerializeField] private string toWhiteboard = "Whiteboard";
    [SerializeField] private string toFace = "FaceCreator";
    [SerializeField] private string toDashboard = "Dashboard";
    [SerializeField] private string toSettings = "Settings";

    // Functions to be used with onClick in Button objects
    public void loginButton()
    {
        SceneManager.LoadScene(toCommonRoom);
    }

    public void joinButton() {
        SceneManager.LoadScene(toMeetingRoom);
    }

    public void creatorButton() {
        SceneManager.LoadScene(toCreator);
    }

    public void overworldButton() {
        SceneManager.LoadScene(toOverworld);
    }

    public void whiteboardButton(){
        SceneManager.LoadScene(toWhiteboard);
    }
    
    public void faceCreatorButtton() {
        SceneManager.LoadScene(toFace);
    }

    public void dashboardButton()
    {
        SceneManager.LoadScene(toDashboard);
    }

    public void settingsButtton()
    {
        SceneManager.LoadScene(toSettings);
    }
}
