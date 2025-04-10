using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public Hole holdeRed;
    public Hole holdeBlue;
    public Hole holdeGreen;

    void OnGUI()
    {
        if (holdeBlue.IsHolding() && holdeRed.IsHolding() && holdeGreen.IsHolding())
        {
            GUI.matrix = Matrix4x4.Scale(Vector3.one * 4);
            GUI.Label(new Rect(30, 65, 100, 30), "Game Clear!");
        }
    }
}
