using UnityEngine;
using UnityEngine.Video;

public class Television : MonoBehaviour
{
    [SerializeField] public VideoClip [] videoClip;
    Animator animator;
    VideoPlayer videoPlayer;

    void Start()
    {
        animator = GetComponentInParent<Animator>();
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.clip = videoClip[PlayerPrefs.GetInt("Channel")];
    }

    public void ShowTv()
    {
        animator.SetTrigger("Change");
        videoPlayer.clip = videoClip[PlayerPrefs.GetInt("Channel")];
    }

}
