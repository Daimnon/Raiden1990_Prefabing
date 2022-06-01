using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed = 3;
    public bool shieldCooldowm = true;
    public bool shieldActive = false;
    public float cooldown = 10;
    public float duration = 1.5f;
    public GameObject shield;
    public int heartsRemaining = 3;
    public float MaxHp = 100;
    public float CurrentHp;
    public Image[] heartArray;

    private void Start()
    {
        CurrentHp = MaxHp;
    }

    void Update()
    {
        UpdateHealth();

        // Player movement with keyboard
        float horizontalMove = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        transform.position += new Vector3(horizontalMove, 0);

        float verticalmMove = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
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

    private void UpdateHealth()
    {
        //if ((CurrentHp / 3) * 2)
        //{
        //    heartArray[i].enabled = true;
        //}
        //else
        //{
        //    heartArray[i].enabled = false;
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(this.gameObject);
        }
    }
}
