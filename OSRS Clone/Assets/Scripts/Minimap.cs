using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public Transform player;
    public Transform mainCamera;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newpos = player.transform.position;
        newpos.y = transform.position.y;

        transform.position = newpos;

        //rotate with camera instead of player, use player.eulerAngles.y for player rotation
        transform.rotation = Quaternion.Euler(90f, mainCamera.eulerAngles.y, 0f);
    }
}
