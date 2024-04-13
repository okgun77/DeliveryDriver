using UnityEngine;
using UnityEngine.UIElements;

public class Delivery : MonoBehaviour
{
    [SerializeField] private float destroyDelay = 0.5f;
    private bool hasPackage = false;

    private void OnCollisionEnter2D(Collision2D _collision)
    {
        Debug.Log("Ouch!!"); 
    }

    private void OnTriggerEnter2D(Collider2D _collision)
    {
        if (_collision.tag == "Package" && !hasPackage)
        {
            Debug.Log("패키지 픽업 완료!");
            hasPackage = true;
            Destroy(_collision.gameObject, destroyDelay);
            
        }

        if (_collision.tag == "Customer" && hasPackage)
        {
            Debug.Log("패키지 배달 완료");
            hasPackage = false;
        }
    }
}
