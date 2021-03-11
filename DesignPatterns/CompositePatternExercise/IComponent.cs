using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePatternExercise
{
    public interface IComponent
    {
        public void Play();
        public void SetPlaybackSpeed(float speed);
        public string GetName();
    }
}
