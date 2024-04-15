using UnityEngine;
using UnityEngine.UIElements;

public class Delivery : MonoBehaviour
{
    [SerializeField] private Color32 hasPackageColor    = new Color32(1, 1, 1, 1);
    [SerializeField] private Color32 noPackageColor     = new Color32(1, 1, 1, 1);

    [SerializeField] private float destroyDelay = 0.5f;
    private bool hasPackage = false;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

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
            spriteRenderer.color = hasPackageColor;
            Destroy(_collision.gameObject, destroyDelay);
            
        }

        if (_collision.tag == "Customer" && hasPackage)
        {
            Debug.Log("패키지 배달 완료");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
