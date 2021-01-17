using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Vector3 movement = new Vector3();

    private void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
}
