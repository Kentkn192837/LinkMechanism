using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiperBehavior : MonoBehaviour
{
    public GameObject camera;
    public GameObject joint1;
    // Start is called before the first frame update
    void Start()
    {
        camera.transform.position = new Vector3(-10, 0, 0);
        camera.transform.rotation = Quaternion.Euler(0, 90, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) joint1.transform.Rotate(1, 0, 0);
        if (Input.GetKey(KeyCode.RightArrow)) joint1.transform.Rotate(-1, 0, 0);
    }
}
