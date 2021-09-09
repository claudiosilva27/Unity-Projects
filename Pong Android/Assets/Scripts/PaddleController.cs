using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
  public Rigidbody2D rb;
  public bool isPlayer1;
  public float speed;
  private float movimento;
    void Start()
    {
    rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {

    if (isPlayer1)
    {
      movimento = Input.GetAxisRaw("Vertical");
    }
    else
    {
      movimento = Input.GetAxisRaw("Vertical");
    }

    rb.velocity = new Vector2(rb.velocity.x, movimento * speed);

    Movement();

    }

  private void Movement()
  {









  }

    /*
    foreach (Touch touch in Input.touches)
    {

      Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
      Vector2 myPosition = rb.position;

      

      if (Mathf.Abs(touchPosition.x - myPosition.x) <= 2)
      {
        myPosition.y = Mathf.Lerp(myPosition.y, touchPosition.y, 10);
        myPosition.y = Mathf.Clamp(myPosition.y, -2.7f, 4.2f);
        rb.position = myPosition;
      }
    }
    */
  
    
}
