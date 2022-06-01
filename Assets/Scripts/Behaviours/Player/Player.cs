using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Vector3 mousePosition;
    public float mouseSpeed = 0.1f;
    public int health = 3;
    public Image[] hearts;
    Rigidbody2D rb;
    public float speed = 6;
    public bool shieldCooldowm = true;
    public int cooldown = 10;
    public float duration = 1.5f;
    public GameObject shield;
    Vector2 position = new Vector2(0f, 0f);

    void Update()
    {
        UpdateHealth();

        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        position = Vector2.Lerp(transform.position, mousePosition, mouseSpeed);

        // Player movement with keyboard
        float horizontalMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.position += new Vector3(horizontalMove, 0);

        float verticalmMove = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.position += new Vector3(0, verticalmMove);

        // Activate shield
        if (Input.GetKeyDown(KeyCode.Mouse1) && shieldCooldowm == true)
        {
            shield.SetActive(true);
            StartCoroutine(Deactivate());
            StartCoroutine(Cooldown());
            shieldCooldowm = false;
        }
    }

    private void UpdateHealth()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }


    private void FixedUpdate()
    {
        rb.MovePosition(position);
    }

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(cooldown);
        shieldCooldowm = true;
    }

    IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(duration);
        shield.SetActive(false);
    }
}
