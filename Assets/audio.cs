using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;

public class audio : MonoBehaviour {
    public AudioSource _audio;
    public Sprite mute;
    public Sprite unmute;
    public GameObject button;

    void Start () {
        _audio = GetComponent<AudioSource>();
        _audio.Play();
	}
	
	
	void Update () {
		
	}

    public void PauseAudio()
    {
        if(_audio.isPlaying)
        {
            _audio.Pause();
            button.GetComponent<Image>().sprite = mute;
        }
        else
        {
            _audio.UnPause();
            button.GetComponent<Image>().sprite = unmute;
        }
    }



}
