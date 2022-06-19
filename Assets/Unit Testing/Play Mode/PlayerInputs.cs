using UnityEngine;

namespace ProgrammingPatterns
{
    public class PlayerInputs : IPlayerInputs
    {
        public float Vertical => Input.GetAxis("Vertical");
    }
}