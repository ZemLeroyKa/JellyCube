using UnityEngine;

public class JellyVertex
{
    public int ID;
    public Vector3 position;
    public Vector3 velocity, force;

    public JellyVertex(int _id, Vector3 _pos)
    {
        ID = _id;
        position = _pos;

    }

    public void Shake(Vector3 target, float m, float s, float d)
    {
        force = (target - position) * s;
        velocity = (velocity + force / m) * d;
        position += velocity;
        if ((velocity + force + force / m).magnitude < 0.001f)
        {
            position = target;
        }

    }
}
