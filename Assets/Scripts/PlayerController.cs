using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float laneOffset = 2f;
    private int currentLane = 1;
    private float baseSpeed = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Move(-1);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Move(1);
        }
    }

    public void ApplySpeedBoost(float boostAmount)
    {
        baseSpeed += boostAmount;
    }

    void Move(int direction)
    {
        int newLane = currentLane + direction;
        if (newLane >= 0 && newLane <= 2)
        {
            transform.position += new Vector3(direction * laneOffset, 0, 0);
            currentLane = newLane;
        }
    }
}

