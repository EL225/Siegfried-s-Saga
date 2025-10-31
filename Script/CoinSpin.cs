using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    public float rotationSpeed = 85f;
    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.Euler( 0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
