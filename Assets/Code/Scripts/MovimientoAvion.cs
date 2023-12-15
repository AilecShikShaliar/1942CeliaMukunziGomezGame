using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAvion : MonoBehaviour
{
    public float velocidadAvion = 15f;
    public string axe, axe2;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    void FixedUpdate()
    {
        float verticalMovement = Input.GetAxis(axe);
        float horizontalMovement = Input.GetAxis (axe2);

        rb.velocity = new Vector2(verticalMovement, horizontalMovement).normalized  * velocidadAvion;
       


    
    }
}
