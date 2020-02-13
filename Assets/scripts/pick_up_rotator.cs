using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pick_up_rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log("回転開始");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
