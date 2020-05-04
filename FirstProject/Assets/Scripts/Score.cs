using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public float playerInitPosZ;
    public Transform player;
    public Text score;

    void Start()
    {
        playerInitPosZ = player.position.z;
    }

    // Update is called once per frame
    void Update () {
        score.text = (player.position.z - playerInitPosZ).ToString("0");
    }
}
