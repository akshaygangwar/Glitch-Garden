using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;
	private AudioSource audioSource;

	void Awake() {
		DontDestroyOnLoad (gameObject);
	}
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}
	
	void OnLevelWasLoaded(int level){
		audioSource.PlayOneShot (levelMusicChangeArray [level]);
	}
}
