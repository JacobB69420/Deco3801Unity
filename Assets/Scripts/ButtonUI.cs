using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private string toCommonRoom = "Common Room";
    [SerializeField] private string toMeetingRoom = "Meeting Room";

    public void loginButton()
    {
        SceneManager.LoadScene(toCommonRoom);
    }

    public void joinButton() {
        SceneManager.LoadScene(toMeetingRoom);
    }

}
