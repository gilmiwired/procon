using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NetWorkManager : MonoBehaviourPunCallbacks
{
    // 最大人数
    [SerializeField] private int maxPlayers = 3;

    // 公開・非公開
    [SerializeField] private bool isVisible = true;

    // 入室の可否
    [SerializeField] private bool isOpen = true;

    // 部屋名
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
        // シーンの自動同期: 無効
        PhotonNetwork.AutomaticallySyncScene = false;
    }


    // Start is called before the first frame update
    private void Start()
    {
        // Photonに接続
        Connect();
    }

    // Photonに接続する
    private void Connect()
    {
        if (PhotonNetwork.IsConnected == false)
        {
            PhotonNetwork.ConnectUsingSettings();
        }
    }


    // ニックネームを付ける
    private void SetMyNickName(string nickName)
    {
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.LocalPlayer.NickName = nickName;
        }
    }

    // ロビーに入る
    private void JoinLobby()
    {
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.JoinLobby();
        }
    }

    // 1. 部屋を作成して入室する
    public void CreateAndJoinRoom()
    {
        // ルームオプションの基本設定
        RoomOptions roomOptions = new RoomOptions
        {
            // 部屋の最大人数
            MaxPlayers = (byte)maxPlayers,

            // 公開
            IsVisible = isVisible,

            // 入室可
            IsOpen = isOpen
        };
        roomName = IF.GetComponent<InputField>().text;
        // 部屋を作成して入室する
        if (PhotonNetwork.InLobby)
        {
            roomPanel.SetActive(false);
            PhotonNetwork.CreateRoom(roomName, roomOptions);
        }
    }


    // 2. 部屋に入室する （存在しなければ作成して入室する）
    public void JoinOrCreateRoom()
    {
        // ルームオプションの基本設定
        RoomOptions roomOptions = new RoomOptions
        {
            // 部屋の最大人数
            MaxPlayers = (byte)maxPlayers,

            // 公開
            IsVisible = isVisible,

            // 入室可
            IsOpen = isOpen
        };

        roomName = IF_2.GetComponent<InputField>().text;
        // 入室 (存在しなければ部屋を作成して入室する)
        if (PhotonNetwork.InLobby)
        {
            roomPanel.SetActive(false);
        }
    }


    // 3. 特定の部屋に入室する
    public void JoinRoom(string targetRoomName)
    {
        if (PhotonNetwork.InLobby)
        {
            PhotonNetwork.JoinRoom(targetRoomName);
        }
    }


    // 4. ランダムな部屋に入室する
    public void JoinRandomRoom()
    {
        if (PhotonNetwork.InLobby)
        {
            PhotonNetwork.JoinRandomRoom();
        }
    }

    // 部屋から退室する
    public void LeaveRoom()
    {
        if (PhotonNetwork.InRoom)
        {
            // 退室
            PhotonNetwork.LeaveRoom();
        }
    }
    // Photonに接続した時
    public override void OnConnected()
    {
        // ニックネームを付ける
        SetMyNickName("Player");
    }

    // マスターサーバーに接続した時
    public override void OnConnectedToMaster()
    {
        // ロビーに入る
        PhotonNetwork.Instantiate(gametile.name, Vector3.zero, Quaternion.identity, 0);
        JoinLobby();
    }

    //コルーチン関数を定義
    private IEnumerator room_Delay() //コルーチン関数の名前
    {         //コルーチンの内容]
        yield return new WaitForSeconds(10f);
        PhotonNetwork.Instantiate(gametile.name, Vector3.zero, Quaternion.identity, 0);
        vm.delete_rp = 1;
    }


    // 部屋に入室した時
    public override void OnJoinedRoom()
    {

        waitroomPanel.SetActive(true);
        roomPanel.SetActive(false);
        waittext.text = "待機人数"+PhotonNetwork.CurrentRoom.PlayerCount + " / " + PhotonNetwork.CurrentRoom.MaxPlayers;
         nametext.text = "部屋の名前:" + PhotonNetwork.CurrentRoom.Name;
        // 部屋の情報を表示
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