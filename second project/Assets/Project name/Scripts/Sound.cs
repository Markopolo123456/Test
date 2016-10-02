using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {

    public AudioSource sound;

    void OnCollisionEnter(Collision collision) {
        sound.Play();
    }
    
}
