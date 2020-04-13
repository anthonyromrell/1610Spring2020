using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject ammo;
    public AudioSource sound;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shot();
        }
    }

    void Shot()
    {
        Instantiate(ammo, transform.position, transform.rotation);
        sound.Play();
    }
}