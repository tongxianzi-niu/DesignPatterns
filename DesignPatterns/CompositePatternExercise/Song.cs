using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePatternExercise
{
    public class Song : IComponent
    {
        public string songName;
        public string artist;
        public float speed;
        public Song(string songName, string artist)
        {
            this.songName = songName;
            this.artist = artist;
        }
        public string GetName()
        {
            return this.songName;
        }

        public void Play()
        {
            Console.WriteLine("Play {0} using {1} speed", GetName(), this.speed);
        }

        public void SetPlaybackSpeed(float speed)
        {
            this.speed = speed;
        }

        public string GetArtist()
        {
            return this.artist;
        }
    }
}
