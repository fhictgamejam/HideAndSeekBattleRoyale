using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    public List<PlayerMovementTeun> Players;

    public List<AudioClip> songs;

    public void AddPlayer(PlayerMovementTeun player) {
        Players.Add(player);

        player.AudioSource.clip = songs[Players.Count - 1];

        foreach (PlayerMovementTeun playingPlayer in Players) {
            playingPlayer.AudioSource.Play();
        }
    }
}