using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject light, lightCollider;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.transform.name == "Player" || collision.transform.name == "Cube")
        {
            anim.SetInteger("isDown", +1);
            light.SetActive(false);
            lightCollider.SetActive(false);
        }
    }
}
