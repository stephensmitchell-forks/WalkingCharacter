﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkingCharacter
{
    /// <summary>
    /// Interface representing a modifier or shader which can be applied on the character
    /// </summary>
    public interface IModifier
    {
        // How many steps of the character is modifier/shader applied
        int Steps { get; set; }

        // Speed of transition to next key
        int TransitionSpeed { get; set; }

        // For generic collection JSON (de)serializing
        String ClassName { get; set; }

        String Name { get; set; }

        // In this method a modifier/shader should be applied on character
        void Apply(Character character);

        // Adds key to timeline with new settings of modifier
        void AddKey(int frame, Character character);

    }
}
