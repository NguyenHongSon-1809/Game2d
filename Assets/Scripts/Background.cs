using UnityEngine;

public class Background : MonoBehaviour
{
    public Transform mainCam;
    public Transform midBg;
    public Transform sideBg;
    public float length;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    

    // Update is called once per frame
    void Update()
    {
        if(mainCam.position.x>midBg.position.x)
        {
            UpdateBackgroundPosition(Vector3.right);
        }
        else if (mainCam.position.x < midBg.position.x)
        {
            UpdateBackgroundPosition(Vector3.left);
        }
    }
    void UpdateBackgroundPosition(Vector3 driection)
    {
        sideBg.position= midBg.position+driection*length;
        Transform temp = midBg;
        midBg = sideBg;
        sideBg = temp;
    }
}
