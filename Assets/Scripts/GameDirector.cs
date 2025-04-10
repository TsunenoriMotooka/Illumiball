using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public Hole holdRed;
    public Hole holdBlue;
    public Hole holdGreen;
    public GameObject message;

    // void OnGUI()
    // {
    //     if (holdeBlue.IsHolding() && holdeRed.IsHolding() && holdeGreen.IsHolding())
    //     {
    //         GUI.matrix = Matrix4x4.Scale(Vector3.one * 4);
    //         GUI.Label(new Rect(30, 65, 100, 30), "Game Clear!");
    //     }
    // }

    void Start()
    {
        message.SetActive(false);
    }

    void Update()
    {
        if (holdBlue.IsHolding() && holdRed.IsHolding() && holdGreen.IsHolding())
        {
            message.SetActive(true);
        }
    }
}
