﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookAtPed : MonoBehaviour
{
    private bool isTargettingPed;
    private bool canLookAtPed;
    private Transform targetPed;


    public GameObject[] Peds;

    public Rigidbody CarRigidbody;
    public Transform PlayerHead;
    public float MaxTrackingDistance;
    public float MinTrackingDistance;
    public float MaxHeadRotation;
    public bool EnableTracking;
    [HideInInspector]
    public bool trackingEnabledWhenYielding;
    private bool trackingEnabled;


    public bool IsTargettingPed { get => isTargettingPed; }
    public bool CanLookAtPed { get => canLookAtPed; }
    public Transform TargetPed { get => targetPed; }

    private float targetAngle;


    private void Start()
    {
        Peds = GameObject.FindGameObjectsWithTag("Pedestrian");
        trackingEnabled = EnableTracking;
    }

    private void Update()
    {
        if (CarRigidbody.velocity.magnitude < 0.1f && CarRigidbody.velocity.magnitude > -0.1f && !trackingEnabledWhenYielding)
        {
            trackingEnabled = false;
        }
        else
        {
            trackingEnabled = EnableTracking;
        }

        LookForPeds();

        if (isTargettingPed)
        {
            Ray targetRay = new Ray(PlayerHead.position, (TargetPed.position - PlayerHead.position) + (new Vector3(0.0f,PlayerHead.position.y,0.0f) - new Vector3(0.0f,TargetPed.position.y,0.0f)));
            targetAngle = Vector3.Angle(transform.forward, targetRay.direction);
            if (targetAngle < MaxHeadRotation)
            {
                canLookAtPed = true;
            }
            else
            {
                canLookAtPed = false;
            }
        }
    }

    private void LookForPeds()
    {
        if (!isTargettingPed && trackingEnabled)
        {
            foreach (GameObject ped in Peds)
            {
                var distance = Vector3.Distance(transform.position, ped.transform.position);
                if (distance < MaxTrackingDistance && distance > MinTrackingDistance)
                {
                    targetPed = ped.transform;
                    isTargettingPed = true;
                }
            }
        }
        else
        {
            float distance = 0.0f;

            if (!(TargetPed is null))
            {
                distance = Vector3.Distance(transform.position, TargetPed.position);
            }

            if (distance > MaxTrackingDistance || distance < MinTrackingDistance || !trackingEnabled)
            {
                targetPed = null;
                isTargettingPed = false;
                canLookAtPed = false;
            }
        }
    }

}
