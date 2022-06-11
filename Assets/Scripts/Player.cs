using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    Transform playerPos;

    public int moveDistance = 0;

    public void MovePlayer(Vector3 pos)
    {
        if (moveDistance > 0 && CalcDistance(pos))
        {
            playerPos.position = pos;
            moveDistance = 0;
        }
    }

    bool CalcDistance(Vector3 pos)
    {
        return Math.Abs(pos.x - playerPos.position.x) + Math.Abs(pos.y - playerPos.position.y) <= moveDistance;
    }

}
