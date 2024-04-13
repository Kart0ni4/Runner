using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour
{
    public float speed = 5f;
    public float acceleration = 1f;
    private float baseSpeed;

    void Start()
    {
        baseSpeed = speed;
        StartCoroutine(IncreaseSpeed());
    }

    public void ApplySpeed(float boostAmount)
    {
        speed += boostAmount;

    }
    public void ApplySpeedBoost(float boostAmount)
    {
        speed += boostAmount;

    }

    IEnumerator IncreaseSpeed()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            ApplySpeed(1f);
        }
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}

