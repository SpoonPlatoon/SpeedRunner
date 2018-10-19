using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public Player player;
    public Transform spawnpoint;
    public CheckPoint curCheckPoint;
    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "KillZone")
        {
            gameObject.transform.position = spawnpoint.position;
            player.playerVelocity = Vector3.zero;
            player.playerVelocity = Vector3.zero;
        }
    }
}
