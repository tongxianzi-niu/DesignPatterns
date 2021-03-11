using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterPatternExercise
{
    public class CoffeeTouchscreenAdapter : ICoffeeMachine
    {
        public OldCoffeeMachine oldCoffeeMachine;

        public CoffeeTouchscreenAdapter(OldCoffeeMachine oldCoffeeMachine)
        {
            this.oldCoffeeMachine = oldCoffeeMachine;
        }

        public void ChooseFirstSelection()
        {
            oldCoffeeMachine.SelectA();
        }

        public void ChooseSecondSelection()
        {
            oldCoffeeMachine.SelectB();
        }
    }
}
