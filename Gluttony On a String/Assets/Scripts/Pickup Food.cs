using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build.Content;
using UnityEngine;

public class PickupFood : MonoBehaviour
{
    public Gamemanager gamemanager;
    public TMP_Text scoreText;
    public GameObject myObject;
    int scorestat;
    // Start is called before the first frame update
    void Start()
    {
        myObject.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        gamemanager.score += 1;
        scorestat = gamemanager.score;
        myObject.SetActive(false);
            Destroy(gameObject);
        scoreText.text = "Score " + scorestat;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
