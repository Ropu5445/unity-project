using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [SerializeField] private Animator anim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "Player")
        {
            anim.Play("playerDeath");
            player.GetComponent<PlayerMovement>().enabled = false;
        }
    }
}
