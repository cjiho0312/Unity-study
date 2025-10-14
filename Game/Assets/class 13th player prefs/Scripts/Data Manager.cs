using UnityEngine;
using UnityEngine.Video;

public class DataManager : MonoBehaviour
{
    [SerializeField] public int channel;
    [SerializeField] Television television;

    void Awake()
    {
        if (!PlayerPrefs.HasKey("Channel")) { channel = 0; }

        channel = PlayerPrefs.GetInt("Channel");
    }

    public void Save()
    {
        PlayerPrefs.SetInt("Channel", channel);
        PlayerPrefs.Save();
    }

    public void Increase()
    {

        if (channel >= television.videoClip.Length -1) { channel = 0; }
        else { channel += 1; }

        Debug.Log(channel);
        Save();
        television.ShowTv();
    }

    public void Delete()
    {
        PlayerPrefs.DeleteAll();
    }
}
