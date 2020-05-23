using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    // Start is called before the first frame update
    public Light luz;
    void Start()
    {
           
    }
     

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        luz.enabled = true;
        luz.intensity = Mathf.Abs(Mathf.Sin(Time.time) * 5);
    }
    private void OnTriggerExit(Collider other)
    {
        luz.enabled = false;
    }
}
