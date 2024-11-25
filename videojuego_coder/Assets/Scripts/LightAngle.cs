using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAngle : MonoBehaviour
{
        // Pulse light's range between original range
        // and half of the original one

        float duration = 3.0f;
        float originalAngle;

        Light lt;

        void Start()
        {
            lt = GetComponent<Light>();
            originalAngle = lt.spotAngle;
        }

        void Update()
        {
            var amplitude = Mathf.PingPong(Time.time, duration);

            // Transform from 0..duration to 0.5..1 range.
            amplitude = amplitude / duration * 0.5f + 0.5f;

            // Set light range.
            lt.spotAngle = originalAngle * amplitude;
        }
    
}
