using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Kill(float test)
    {
        SpriteRenderer sprite;

        sprite = transform.GetComponent<SpriteRenderer>();

        sprite.enabled = false;

        ParticleSystem particle;

        particle = transform.GetComponent<ParticleSystem>();

        particle.Play(false);
        
        GameObject.Destroy(gameObject,5);
    }
}
