using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
public class SpritRendererBehaviour : MonoBehaviour
{
    private SpriteRenderer spriteRendererObj;

    public ColorData ColorDataObj;

    public UnityEvent startEvent;

    // Start is called before the first frame update
    void Start()
    {
        spriteRendererObj = GetComponent<SpriteRenderer>();
        startEvent.Invoke();
    }

    public void ChangeSpriteColor(ColorData colorDataObj)
    {
        spriteRendererObj.color = colorDataObj.value;
    }
}

