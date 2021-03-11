using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePattern
{
    public interface IStructure
    {
        public void Enter();
        public void Exit();
        public void Location();
        public string GetName();
    }
}
