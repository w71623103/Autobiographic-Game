using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelshowing : MonoBehaviour
{
    public SpriteRenderer spriteR;

    // Start is called before the first frame update
    void Start()
    {
        spriteR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        spriteR.sortingOrder = -Mathf.FloorToInt(1000 + 100 * transform.position.y);
    }
}
