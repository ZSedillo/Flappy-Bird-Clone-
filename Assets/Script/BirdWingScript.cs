using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdWingScript : MonoBehaviour
{
    SpriteRenderer wing;
    bool isFlipped;
    float flipStartTime;

    // Start is called before the first frame update
    void Start()
    {
        wing = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            flipStartTime = Time.time;
            isFlipped = !isFlipped; // Toggle the flip state
            wing.flipY = isFlipped;
        }

        if (isFlipped && Time.time - flipStartTime >= 0.25f)
        {
            wing.flipY = false; // Reset the flip state
            isFlipped = false;
        }
    }
}