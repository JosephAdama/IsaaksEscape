using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowbreak : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem Scherbe;
    public GameObject sound;
    private void OnCollisionEnter2D(Collision2D collision)
    {
            Instantiate(Scherbe, transform.position, Quaternion.identity);
            sound.GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        
    }
}
