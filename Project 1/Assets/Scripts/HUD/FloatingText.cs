using UnityEngine;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour
{
    public float fadingText = 3;
    public float variation = 3f;

    public Vector3 direction = Vector3.up * 15f;

    void Start()
    {
        this.variation = Random.Range(-this.variation, this.variation);
        this.transform.position += new Vector3(Random.Range(-this.variation, this.variation), 0f, 0f);
        this.direction.x += this.variation;
    }

    private void Update()
    {
        this.transform.position += this.direction * Time.deltaTime;
        var text = GetComponent<Text>();
        var color = text.color;
        color.a -= this.fadingText * Time.deltaTime;
        text.color = color;
        if (color.a <= 0f)
        {
            Destroy(this.gameObject);
        }
    }


}
