using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI
{
    /// <summary>
    /// This class has an event that gets trigered when the 'Hello' button is pressed.
    /// </summary>
    public class HelloButton : ButtonHandler
    {
        /// <summary>
        /// This event gets invoked every time the button is pressed.
        /// </summary>
        public static UnityEvent<string> s_animalsTalk = new UnityEvent<string>();

        /// <summary>
        /// This is the UI textfield where a name can be typed.
        /// </summary>
        [SerializeField]
        private Text _nameInputField;

        /// <summary>
        /// Invokes the event if a button is pressed.
        /// </summary>
        protected override void HandleButtonClick()
        {
            base.HandleButtonClick();
            string enteredName = _nameInputField.text;
            s_animalsTalk.Invoke(enteredName);
        }
    }
}
