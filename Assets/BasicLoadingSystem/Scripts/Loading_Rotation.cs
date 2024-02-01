//Source Link:https://www.youtube.com/watch?v=ltu27NLeIWc&t=311s&pp=ygUUbG9hZGlnbiBzY3JlZW4gdW5pdHk%3D&ab_channel=zonlib

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading_Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform Main_Icon;
    public float Time_Step;
    public float One_Step_Angle;

    public float Start_Time;

    void Start()
    {
        Start_Time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - Start_Time >= Time_Step)
        {
            Vector3 Icon_Angle = Main_Icon.localEulerAngles;
            Icon_Angle.z += One_Step_Angle;
            
            Main_Icon.localEulerAngles = Icon_Angle;
            Start_Time  = Time.time;
        }
    }
}
