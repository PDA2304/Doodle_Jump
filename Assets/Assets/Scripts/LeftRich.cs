using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRich : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.name == "Doodle")
        {
            if(name  == "A")
            {
                collision.gameObject.transform.position = new Vector3(2.1F, collision.gameObject.transform.position.y, 0f);

            }
            if (name == "B")
            {
                collision.gameObject.transform.position = new Vector3(-2.1F, collision.gameObject.transform.position.y, 0f);
            }
        }
    }
}
