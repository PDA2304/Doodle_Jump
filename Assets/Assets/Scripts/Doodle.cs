using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Doodle : MonoBehaviour
{
    public static Doodle instance;
    float horizontal;
    public Rigidbody2D DoodleRigid;
    public Text text;
    private float score = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            horizontal = Input.acceleration.x;
        }

        if (Input.acceleration.x < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (Input.acceleration.x > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        DoodleRigid.velocity = new Vector2(Input.acceleration.x * 10f, DoodleRigid.velocity.y);

        float moveInput = Input.GetAxis("Horizontal");
        if (moveInput < 0)
        { // Движ влево
            DoodleRigid.velocity = new Vector2(-5, DoodleRigid.velocity.y);
        }
        else if (moveInput > 0)
        { // Движ вправо
            DoodleRigid.velocity = new Vector2(5, DoodleRigid.velocity.y);
        }

        if (DoodleRigid.velocity.y > 0 && transform.position.y > score)
        {
            score = transform.position.y;
        }
        text.text = "СЧЁТ " + Mathf.Round(score).ToString();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            SceneManager.LoadScene(1);
        }
    }
}
