using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


namespace UI
{
    /// <summary>
    /// This class has an event that gets trigered when the 'Give Leaves' button is pressed.
    /// </summary>
    public class GiveLeavesButton : ButtonHandler
    {

        /// <summary>
        /// This event gets invoked every time the button is pressed.
        /// </summary>
        public static UnityEvent eatLeaves = new UnityEvent();

        /// <summary>
        /// Invokes the event if a button is pressed.
        /// </summary>
        protected override void HandleButtonClick()
        {
            base.HandleButtonClick();
            eatLeaves?.Invoke();
        }
    }
}
