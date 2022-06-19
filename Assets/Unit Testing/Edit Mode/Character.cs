using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPatterns
{
    public class Character : MonoBehaviour, ICharacter
    {
        public Inventory _inventory { get; set; }
        public int health { get; set; }
    }
}
