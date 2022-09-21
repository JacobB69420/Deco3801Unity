using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private string toCommonRoom = "Common Room";
    [SerializeField] private string toMeetingRoom = "Meeting Room";
    [SerializeField] private string toCreator = "CharacterCreator";
    [SerializeField] private string toOverworld = "Overworld";

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
}
