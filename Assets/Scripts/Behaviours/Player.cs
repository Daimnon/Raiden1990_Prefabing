using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 3;
    public bool shieldCooldowm = true;
    public bool shieldActive = false;
    public float cooldown = 10;
    public float duration = 1.5f;
    public GameObject shield;

    void Update()
    {
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
            shieldActive = true;
        }
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
        shieldActive = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(this.gameObject);
        }
    }
}
