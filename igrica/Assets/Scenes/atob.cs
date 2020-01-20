using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atob : MonoBehaviour
{

    public Vector2 aPosition0;
    public Vector2 aPosition1;
    void Update()
    {
        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), aPosition1, 3 * Time.deltaTime);
    }
}
