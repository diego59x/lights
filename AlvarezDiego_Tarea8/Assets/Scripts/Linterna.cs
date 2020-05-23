using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Linterna : MonoBehaviour
{
    // Start is called before the first frame update
    private Light luz;
    private AudioSource on;
    public Text scoreText;
    void Start()
    {
        on = GetComponent<AudioSource>();
        scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
        luz = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { //aca puedes cambiar la letra por la que quieras que
          //prenda y apague la luz

            if (luz.enabled == true)
            {
               

                luz.enabled = false;

            }
            else
            {
                on.Play();
                luz.enabled = true;
            }

        }
        Ray myRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f));
        RaycastHit hitInfo;
        if (Physics.Raycast(myRay, out hitInfo))
        {
            if (hitInfo.collider.CompareTag("Cube"))
            {

                scoreText.text = "That is a: " + hitInfo.collider.ToString();
                
            }
            else
            {
                scoreText.text = " ";
            }

        }



    }

}