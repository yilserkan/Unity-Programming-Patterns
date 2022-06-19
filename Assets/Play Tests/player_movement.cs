using System.Collections;
using NUnit.Framework;
using ProgrammingPatterns;
using UnityEngine;
using UnityEngine.TestTools;

public class player_movement
{
    [UnityTest]
    public IEnumerator with_positive_vertical_input_moves_forward()
    {
        GameObject playerGameObject = new GameObject();
        Player_UnitTesting player = playerGameObject.AddComponent<Player_UnitTesting>();
        MockPlayerInputs playerInputs = new MockPlayerInputs();
        playerInputs.Vertical = 1f;
        player._playerInputs = playerInputs;

        var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.SetParent(playerGameObject.transform);
        cube.transform.localPosition = Vector3.zero;
        
        yield return new WaitForSeconds(.3f);
        
        Assert.IsTrue(playerGameObject.transform.position.z > 0f);
        Assert.AreEqual(0f, playerGameObject.transform.position.x);
        Assert.AreEqual(0f, playerGameObject.transform.position.y);
    }
}
