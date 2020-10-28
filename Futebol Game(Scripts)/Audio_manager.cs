using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_manager : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioSource musicaBK;
    public static Audio_manager instance;

    public AudioClip[] clipsFX;
    public AudioSource sonsFX;
    public void SonsFXToca(int index)
    {
        sonsFX.clip = clipsFX[index];
        sonsFX.Play();
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }
    AudioClip GetRandom()
    {
        return clips[Random.Range(0, clips.Length)];
    }
    // Update is called once per frame
    void Update()
    {
        if (!musicaBK.isPlaying)
        {
            musicaBK.clip = GetRandom();
            musicaBK.Play();
        }
    }
}
