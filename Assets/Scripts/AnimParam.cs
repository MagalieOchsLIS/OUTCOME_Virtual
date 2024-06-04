using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "AmimParam", order = 1)]
public class AnimParam : ScriptableObject 
{
    [Header("Bone Angle Coefficients")]
    
    [RenameField("Head Rotation X")]
    public float pose_Rx_coef = 0.9f;
    [RenameField("Head Rotation Y")]
    public float pose_Ry_coef = 0.9f;
    [RenameField("Head Rotation Z")]
    public float pose_Rz_coef = 0.9f;
    [RenameField("AU25-Lips-Part Jaw Rotation")]
    public float AU25_jaw_coef = -1;
    [RenameField("AU26-Jaw-Drop Jaw Rotation")]
    public float AU26_jaw_coef = -4;

    [Header("Action Unit Coefficients")]

    [RenameField("AU01-Inner-Brow-Raiser Intensity")]
    public float AU01_r_coef = 100 / 5;
    [RenameField("AU02-Outer-Brow-Raiser Intensity")]
    public float AU02_r_coef = 100 / 5;
    [RenameField("AU04-Brow-Lowerer Intensity")]
    public float AU04_r_coef = 100 / 5;
    [RenameField("AU05-Upper-Lid-Raiser Intensity")]
    public float AU05_r_coef = 100 / 5;
    [RenameField("AU06-Cheek-Raiser Intensity")]
    public float AU06_r_coef = 100 / 5;
    [RenameField("AU07-Lid-Tightener Intensity")]
    public float AU07_r_coef = 100 / 5;
    [RenameField("AU09-Nose-Wrinkler Intensity")]
    public float AU09_r_coef = 100 / 5;
    [RenameField("AU10-Upper-Lip-Raiser Intensity")]
    public float AU10_r_coef = 50 / 5;
    [RenameField("AU12-Lip-Corner-Puller Intensity")]
    public float AU12_r_coef = 100 / 5;
    [RenameField("AU14-Dimpler Intensity")]
    public float AU14_r_coef = 100 / 5;
    [RenameField("AU15-Lip-Corner-Depressor Intensity")]
    public float AU15_r_coef = 100 / 5;
    [RenameField("AU17-Chin-Raiser Intensity")]
    public float AU17_r_coef = 100 / 5;
    [RenameField("AU20-Lip-Stretcher Intensity")]
    public float AU20_r_coef = 100 / 5;
    [RenameField("AU23-Lip-Tightener Intensity")]
    public float AU23_r_coef = 100 / 5;
    [RenameField("AU25-Lips-Part Intensity")]
    public float AU25_r_coef = 100 / 5;
    [RenameField("AU28-Lip-Suck Max")]
    public float AU28_max = 30;
    [RenameField("AU45-Blink Intensity")]
    public float AU45_r_coef = 100 / 5;
    
}
