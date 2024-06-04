using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frame
{
    public int frame;
    public int face_id;
    public float timestamp;
    public float confidence;
    public bool success;

    public float gaze_angle_x;
    public float gaze_angle_y;

    public float pose_Rx;
    public float pose_Ry;
    public float pose_Rz;

    public float AU01_r;
    public float AU02_r;
    public float AU04_r;
    public float AU05_r;
    public float AU06_r;
    public float AU07_r;
    public float AU09_r;
    public float AU10_r;
    public float AU12_r;
    public float AU14_r;
    public float AU15_r;
    public float AU17_r;
    public float AU20_r;
    public float AU23_r;
    public float AU25_r;
    public float AU26_r;
    public float AU45_r;

    public bool AU01_c;
    public bool AU02_c;
    public bool AU04_c;
    public bool AU05_c;
    public bool AU06_c;
    public bool AU07_c;
    public bool AU09_c;
    public bool AU10_c;
    public bool AU12_c;
    public bool AU14_c;
    public bool AU15_c;
    public bool AU17_c;
    public bool AU20_c;
    public bool AU23_c;
    public bool AU25_c;
    public bool AU26_c;
    public bool AU28_c;
    public bool AU45_c;

    public Frame()
    {
        frame = 0;
        face_id = 0;
        timestamp = 0f;
        confidence = 0f;
        success = true;
        gaze_angle_x = 0f;
        gaze_angle_y = 0f;
        pose_Rx = 0f;
        pose_Ry = 0f;
        pose_Rz = 0f;
        AU01_r = 0f;
        AU02_r = 0f;
        AU04_r = 0f;
        AU05_r = 0f;
        AU06_r = 0f;
        AU07_r = 0f;
        AU09_r = 0f;
        AU10_r = 0f;
        AU12_r = 0f;
        AU14_r = 0f;
        AU15_r = 0f;
        AU17_r = 0f;
        AU20_r = 0f;
        AU23_r = 0f;
        AU25_r = 0f;
        AU26_r = 0f;
        AU45_r = 0f;
        AU01_c = true;
        AU02_c = true;
        AU04_c = true;
        AU05_c = true;
        AU06_c = true;
        AU07_c = true;
        AU09_c = true;
        AU10_c = true;
        AU12_c = true;
        AU14_c = true;
        AU15_c = true;
        AU17_c = true;
        AU20_c = true;
        AU23_c = true;
        AU25_c = true;
        AU26_c = true;
        AU28_c = true;
        AU45_c = true;
    }

}
