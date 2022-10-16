using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using Photon.Realtime;
using System.Linq;
using System.IO;


public class Launcher : MonoBehaviourPunCallbacks
{
	public static Launcher Instance;
	public SO_CharacterBody characterBody;

	[SerializeField] TMP_InputField roomNameInputField;
	[SerializeField] TMP_Text errorText;
	[SerializeField] TMP_Text roomNameText;
	[SerializeField] Transform roomListContent;
	[SerializeField] GameObject roomListItemPrefab;
	[SerializeField] Transform playerListContent;
	[SerializeField] GameObject PlayerListItemPrefab;
	[SerializeField] GameObject startGameButton;

	void Awake()
	{
		Instance = this;
	}

	void Start()
	{
		Debug.Log("Connecting to Master");
		PhotonNetwork.ConnectUsingSettings();

	}

	public override void OnConnectedToMaster()
	{
		Debug.Log("Connected to Master");
		PhotonNetwork.JoinLobby();
		PhotonNetwork.AutomaticallySyncScene = true;

	}

	public override void OnJoinedLobby()
	{
		//MenuManager.Instance.OpenMenu("title");
		Debug.Log("Joined Lobby");
		CreateRoom("0");
	}

	public override void OnCreateRoomFailed(short returnCode, string message){
		JoinRoom();
	}

	public void CreateRoom(string i)
	{
		PhotonNetwork.CreateRoom(i);
	}

	public override void OnJoinedRoom()
	{
		StartGame();
	}

	public override void OnMasterClientSwitched(Player newMasterClient)
	{
		startGameButton.SetActive(PhotonNetwork.IsMasterClient);
	}


	public void StartGame()
	{
		//PhotonNetwork.LoadLevel(1);
		PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PlayerManager"), Vector3.zero, Quaternion.identity);
	}

	public void LeaveRoom()
	{
		PhotonNetwork.LeaveRoom();
	}

	public void JoinRoom()
	{
		PhotonNetwork.JoinRoom("0");
		Debug.Log("Joined Room");

		//MenuManager.Instance.OpenMenu("loading");
	}



}