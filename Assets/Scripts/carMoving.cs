using UnityEngine;

public class carMoving : MonoBehaviour
{
    public float startValue;
    public float endValue;
    public float duration;
    private float currentValue;
    private float startTime;

    private void Start()
    {
        startTime = Time.time;
        startValue = transform.position.x;
    }
    private void Update()
    {
        float timePassed = Time.time - startTime;
        currentValue = Mathf.Lerp(startValue, endValue, timePassed / duration);

        transform.position = new Vector3(currentValue, transform.position.y, transform.position.x);
    }
}
