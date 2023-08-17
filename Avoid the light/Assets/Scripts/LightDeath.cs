using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LightDeath : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "Player")
        {
            player.SetActive(false);
        }
    }
}
