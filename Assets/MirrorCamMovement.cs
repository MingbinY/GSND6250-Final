using UnityEngine;

public class MirrorCamMovement : MonoBehaviour
{
    public Transform playerTarget;
    public Transform mirror;

    public float maxZ = 25f;

    private void Start()
    {
        playerTarget = Camera.main.transform;
    }

    private void Update()
    {
        if (!playerTarget || !mirror) return;
        Vector3 localPlayer = mirror.InverseTransformPoint(playerTarget.position);
        //transform.position = mirror.TransformPoint(new Vector3(localPlayer.x, localPlayer.y, -localPlayer.z > maxZ ? maxZ : -localPlayer.z));

        Vector3 lookatMirror = mirror.TransformPoint(new Vector3(-localPlayer.x, localPlayer.y, localPlayer.z));
        transform.LookAt(lookatMirror);
    }
}
