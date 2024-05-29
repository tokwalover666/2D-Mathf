using UnityEngine;

public class bullet : MonoBehaviour
{
    public float startValue;
    public float endValue;
    public float duration;
    private float currentValue;
    private float startTime;

    private void Start()
    {
        startTime = Time.time;
        currentValue = startValue;
    }
    private void Update()
    {
        float timePassed = Time.time - startTime;
        currentValue = Mathf.Lerp(startValue, endValue, timePassed/duration);

        transform.position = new Vector3(currentValue, 0,0);
    }
}
