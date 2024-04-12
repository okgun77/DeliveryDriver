using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D _collision)
    {
        Debug.Log("Ouch!!");
    }

    private void OnTriggerEnter2D(Collider2D _collision)
    {
        Debug.Log("Pass!!!");
    }
}
