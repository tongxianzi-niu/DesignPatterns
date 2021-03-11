using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePatternExercise
{
    public class PlayList : IComponent
    {
        public string playListName;
        public List<IComponent> playList;
        public PlayList(string playListName)
        {
            this.playListName = playListName;
            this.playList = new List<IComponent>();
        }

        public string GetName()
        {
            return this.playListName;
        }

        public void Play()
        {
            foreach (IComponent component in this.playList)
            {
                component.Play();
            }
        }

        public void SetPlaybackSpeed(float speed)
        {
            foreach (IComponent component in this.playList)
            {
                component.SetPlaybackSpeed(speed);
            }
        }

        public void Add(IComponent component)
        {
            this.playList.Add(component);
        }

        public void Remove(IComponent component)
        {
            this.playList.Remove(component);
        }
    }
}
