using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    #region Variables
    public GameObject player; //Grabs the Player
    public Player plyr;
    public GameObject exitPortal; //Grabs the Exit Portal
    public KillZone killZone;
    public Transform spawnPoint;

    #region CheckPoints
    public GameObject checkPoint1;
    public GameObject checkPoint2;
    public GameObject checkPoint3;
    public GameObject checkPoint4;
    public GameObject checkPoint5;
    #endregion
    #endregion
    #region PortalEnter
    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = exitPortal.transform.position; //Move the player from the start portal to the exit portal's location
        plyr.playerVelocity = Vector3.zero;
        plyr.lapNum++;
        killZone.spawnpoint = spawnPoint;

        checkPoint1.SetActive(true);
        checkPoint2.SetActive(true);
        checkPoint3.SetActive(true);
        checkPoint4.SetActive(true);
        checkPoint5.SetActive(true);

    }
    #endregion
}
