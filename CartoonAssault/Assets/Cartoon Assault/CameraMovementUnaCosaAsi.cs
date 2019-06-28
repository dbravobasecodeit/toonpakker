using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementUnaCosaAsi : MonoBehaviour
{
    public Transform playerCar;
    public float cameraDistance = 30.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate() {
        transform.position = new Vector3(playerCar.position.x, 0, -9);
    }
}
