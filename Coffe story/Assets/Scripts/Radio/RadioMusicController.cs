using System.Collections.Generic;
using UnityEngine;

public class RadioMusicController : MonoBehaviour
{
    private AudioSource _audioSource;
    [SerializeField] private List<AudioClip> _songs;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        MixSongs();
        _audioSource.loop = true;
    }

    private void MixSongs()
    {
        List<AudioClip> list = new List<AudioClip>();
        while (list.Count != _songs.Count)
        {
            int i = Random.RandomRange(0, _songs.Count);
            if (!list.Contains(_songs[i]))
            {
                list.Add(_songs[i]);
            }
        }
        _songs = list;
    }
    private int _songIndex = -1;
    private void Update()
    {

        if (!_audioSource.isPlaying)
        {
            _songIndex++;
            if (_songIndex == _songs.Count)
                _songIndex = 0;
            _audioSource.PlayOneShot(_songs[_songIndex]);         
        }
                
    }
}