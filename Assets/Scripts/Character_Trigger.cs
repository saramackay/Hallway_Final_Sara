using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject character;

    private void Start()
    {
        character.SetActive(true);
    }
    void OnTriggerEnter(Collider other)
    {
        character.SetActive(false);
    }
}