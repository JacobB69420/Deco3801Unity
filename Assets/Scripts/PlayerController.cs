using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Hashtable = ExitGames.Client.Photon.Hashtable;

public class PlayerController : MonoBehaviourPunCallbacks, IPunInstantiateMagicCallback
{

    private float speed = 4f;
    private Vector2 playerMovement;
    private Animator animator;

	Rigidbody2D myRigidbody;

	PhotonView PV;

	PlayerManager playerManager;


	void Awake()
	{
		myRigidbody = GetComponentInChildren<Rigidbody2D>();
		PV = GetComponentInChildren<PhotonView>();

		playerManager = PhotonView.Find((int)PV.InstantiationData[0]).GetComponent<PlayerManager>();
	}

	void Start()
	{
		if(PV.IsMine)
		{
			animator = GetComponentInChildren<Animator>();
			myRigidbody = GetComponentInChildren<Rigidbody2D>();
		}
		else
		{
			Destroy(myRigidbody);
		}
	}


    public void OnPhotonInstantiate(PhotonMessageInfo info)
    {
        object[] instantiationData = info.photonView.InstantiationData;
        BodyPartManagerUnique bpm = GetComponentInChildren<BodyPartManagerUnique>();
        int[] bodyIndexes = (int[]) instantiationData[1];
        for(int i = 0; i < 4; i++){
            bpm.bodyPartIndexes[i] = bodyIndexes[i];
        }
        BodyPartManagerUnique bpm2 = GetComponentInChildren<BodyPartManagerUnique>();
        Debug.Log(bpm2.bodyPartIndexes[0]);
    }


    private void FixedUpdate()
    {
        if(!PV.IsMine)
			return;
        playerMovement = Vector2.zero;
        playerMovement.x = Input.GetAxisRaw("Horizontal");
        playerMovement.y = Input.GetAxisRaw("Vertical");

        UpdateAnimationAndMove();
    }


	private void UpdateAnimationAndMove()
    {
        if (playerMovement != Vector2.zero)
        {
            MoveCharacter();
            animator.SetFloat("moveX", playerMovement.x);
            animator.SetFloat("moveY", playerMovement.y);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }
    }

    private void MoveCharacter()
    {
        myRigidbody.MovePosition(myRigidbody.position + playerMovement * speed * Time.deltaTime);
    }

}