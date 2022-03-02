using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private float repeatWidth;
    private Vector3 starPos;
    void Start()
    {
        starPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;

    }

    // Update is called once per frame
    void Update()
    {
          if(transform.position.x < starPos.x - repeatWidth)
        {
            transform.position = starPos;
        }
    }
}
