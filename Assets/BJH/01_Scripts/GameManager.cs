using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GameManager : MonoBehaviourPun
{
    public GameObject spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.SerializationRate = 60;

        // 나의 플레이어 생성
        PhotonNetwork.Instantiate("Character", spawnPoint.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
