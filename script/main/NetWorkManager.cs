using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NetWorkManager : MonoBehaviourPunCallbacks
{
    // �ő�l��
    [SerializeField] private int maxPlayers = 3;

    // ���J�E����J
    [SerializeField] private bool isVisible = true;

    // �����̉�
    [SerializeField] private bool isOpen = true;

    // ������
    [SerializeField] private string roomName = "";

    [SerializeField] GameObject gametile;

    [SerializeField]  GameObject roomPanel;
    [SerializeField] GameObject waitroomPanel;

    public Text waittext;
    public Text nametext;

    public InputField IF;
    public InputField IF_2;
    public valueManager vm;

    private void Awake()
    {
        // �V�[���̎�������: ����
        PhotonNetwork.AutomaticallySyncScene = false;
    }


    // Start is called before the first frame update
    private void Start()
    {
        // Photon�ɐڑ�
        Connect();
    }

    // Photon�ɐڑ�����
    private void Connect()
    {
        if (PhotonNetwork.IsConnected == false)
        {
            PhotonNetwork.ConnectUsingSettings();
        }
    }


    // �j�b�N�l�[����t����
    private void SetMyNickName(string nickName)
    {
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.LocalPlayer.NickName = nickName;
        }
    }

    // ���r�[�ɓ���
    private void JoinLobby()
    {
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.JoinLobby();
        }
    }

    // 1. �������쐬���ē�������
    public void CreateAndJoinRoom()
    {
        // ���[���I�v�V�����̊�{�ݒ�
        RoomOptions roomOptions = new RoomOptions
        {
            // �����̍ő�l��
            MaxPlayers = (byte)maxPlayers,

            // ���J
            IsVisible = isVisible,

            // ������
            IsOpen = isOpen
        };
        roomName = IF.GetComponent<InputField>().text;
        // �������쐬���ē�������
        if (PhotonNetwork.InLobby)
        {
            roomPanel.SetActive(false);
            PhotonNetwork.CreateRoom(roomName, roomOptions);
        }
    }


    // 2. �����ɓ������� �i���݂��Ȃ���΍쐬���ē�������j
    public void JoinOrCreateRoom()
    {
        // ���[���I�v�V�����̊�{�ݒ�
        RoomOptions roomOptions = new RoomOptions
        {
            // �����̍ő�l��
            MaxPlayers = (byte)maxPlayers,

            // ���J
            IsVisible = isVisible,

            // ������
            IsOpen = isOpen
        };

        roomName = IF_2.GetComponent<InputField>().text;
        // ���� (���݂��Ȃ���Ε������쐬���ē�������)
        if (PhotonNetwork.InLobby)
        {
            roomPanel.SetActive(false);
        }
    }


    // 3. ����̕����ɓ�������
    public void JoinRoom(string targetRoomName)
    {
        if (PhotonNetwork.InLobby)
        {
            PhotonNetwork.JoinRoom(targetRoomName);
        }
    }


    // 4. �����_���ȕ����ɓ�������
    public void JoinRandomRoom()
    {
        if (PhotonNetwork.InLobby)
        {
            PhotonNetwork.JoinRandomRoom();
        }
    }

    // ��������ގ�����
    public void LeaveRoom()
    {
        if (PhotonNetwork.InRoom)
        {
            // �ގ�
            PhotonNetwork.LeaveRoom();
        }
    }
    // Photon�ɐڑ�������
    public override void OnConnected()
    {
        // �j�b�N�l�[����t����
        SetMyNickName("Player");
    }

    // �}�X�^�[�T�[�o�[�ɐڑ�������
    public override void OnConnectedToMaster()
    {
        // ���r�[�ɓ���
        PhotonNetwork.Instantiate(gametile.name, Vector3.zero, Quaternion.identity, 0);
        JoinLobby();
    }

    //�R���[�`���֐����`
    private IEnumerator room_Delay() //�R���[�`���֐��̖��O
    {         //�R���[�`���̓��e]
        yield return new WaitForSeconds(10f);
        PhotonNetwork.Instantiate(gametile.name, Vector3.zero, Quaternion.identity, 0);
        vm.delete_rp = 1;
    }


    // �����ɓ���������
    public override void OnJoinedRoom()
    {

        waitroomPanel.SetActive(true);
        roomPanel.SetActive(false);
        waittext.text = "�ҋ@�l��"+PhotonNetwork.CurrentRoom.PlayerCount + " / " + PhotonNetwork.CurrentRoom.MaxPlayers;
         nametext.text = "�����̖��O:" + PhotonNetwork.CurrentRoom.Name;
        // �����̏���\��
        /* if (PhotonNetwork.InRoom)
         {
             Debug.Log("RoomName: " + PhotonNetwork.CurrentRoom.Name);
             Debug.Log("HostName: " + PhotonNetwork.MasterClient.NickName);
             Debug.Log("Slots: " + PhotonNetwork.CurrentRoom.PlayerCount + " / " + PhotonNetwork.CurrentRoom.MaxPlayers);
         }*/
        StartCoroutine("room_Delay");
        //vm.delete_rp = 1;
    }
}