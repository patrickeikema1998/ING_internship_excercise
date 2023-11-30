using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UI
{
    /// <summary>
    /// This class has an event that gets trigered when the 'Trick' button is pressed.
    /// </summary>
    public class TrickButton : ButtonHandler
    {
        public static UnityEvent trick = new UnityEvent();

        /// <summary>
        /// Invokes the event if a button is pressed.
        /// </summary>
        protected override void HandleButtonClick()
        {
            base.HandleButtonClick();
            trick.Invoke();
        }
    }
}
