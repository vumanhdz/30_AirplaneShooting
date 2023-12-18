using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscripts : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame Vertical
    void Update()
    {
        float deltaY = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float deltaX = Input.GetAxis("Horizontal") * Time.deltaTime*speed;
        
        float newYpos = transform.position.y + deltaY;
        float newXpos = transform.position.x + deltaX;
        
        transform.position = new Vector2(newXpos, newYpos);
    }
}
