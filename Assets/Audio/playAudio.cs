using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class playAudio : MonoBehaviour {

	public AudioClip music;

	// Use this for initialization
	void Start () 
	{
		audio.clip = music;
		audio.Play();
	}

}

