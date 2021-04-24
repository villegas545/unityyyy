using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reproducirutpaquime : MonoBehaviour
{
    public GameObject utpaquime;
    public Transform imagetarget;
    private void OnMouseDown()
    {
        Instantiate(utpaquime,imagetarget);
        Destroy(GameObject.FindGameObjectWithTag("cubos"), 0);
    }
}
