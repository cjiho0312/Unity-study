using UnityEngine;

public class Audiomanager : MonoBehaviour
{
    [SerializeField] static AudioSource audiosource;

    private void Awake()
    {
        audiosource = GetComponent<AudioSource>();
    }

    public static void Emit(AudioClip audioclip)
    {
        audiosource.PlayOneShot(audioclip);
    }

    
}
