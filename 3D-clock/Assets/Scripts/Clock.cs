using UnityEngine;
using System;

public class Clock : MonoBehaviour
{

    private const float degreesPerHour = 30f;
    private const float degreesPerMinute = 6f;
    private const float degreesPerSecond = 6f;

    public Transform hoursTransform;
    public Transform minutesTransform;
    public Transform secondsTransform;
    public bool continuous;
    
    private void Update()
    {
        // hoursTransform.Rotate(new Vector3(0, hour * 30, 0));
        hoursTransform.localRotation =   Quaternion.Euler(0f, DateTime.Now.Hour * degreesPerHour, 0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, DateTime.Now.Minute * degreesPerMinute, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, DateTime.Now.Second * degreesPerSecond, 0f);
    }

}
