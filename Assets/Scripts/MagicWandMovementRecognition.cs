using System.Linq;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class MagicWandMovementRecognition : MonoBehaviour
{
    [SerializeField] private GameObject rightHand;
    [SerializeField] private GameObject leftHand;
    [SerializeField] private bool isLeftHand;

    private const int POSITION_COUNT = 30;
    private Vector3[] rightHandPositions = new Vector3[POSITION_COUNT];
    private Vector3[] leftHandPositions = new Vector3[POSITION_COUNT];

    private int index = 0;
    
    void Update()
    {
        index++;
        if (index >= POSITION_COUNT)
        {
            index = 0;
        }
        rightHandPositions[index] = rightHand.transform.position;
        leftHandPositions[index] = leftHand.transform.position;
        // rightHandText.text = $"RightHand: {rightHand.transform.position}";

        var result = isLeftHand ? Check(leftHandPositions, index) : Check(rightHandPositions, index);
        switch (result)
        {
            case "Lumos":
                MagicWand.ReadyLumos().Forget();
                break;
            case "Nox":
                MagicWand.ReadyNox().Forget();
                break;
        }
    }

    private string Check(Vector3[] positions, int idx)
    {
        var oldestIndex = idx + 1 >= POSITION_COUNT ? 0 : idx + 1;
        var oldestPos = positions[oldestIndex];
        
        var aveX = positions.Select(rp => rp.x - oldestPos.x).Average();
        var aveZ = positions.Select(rp => rp.z - oldestPos.z).Average();
        if (Mathf.Abs(aveX) > 0.1f || Mathf.Abs(aveZ) > 0.1f)
        {
            //Debug.Log("左右にぶれすぎです");
            return string.Empty;
        }

        var y = positions[idx].y - oldestPos.y;
        switch (y)
        {
            case > 0.1f:
                Debug.Log("ReadyLumos");
                return "Lumos";
            case < -0.1f:
                Debug.Log("ReadyNox");
                return "Nox";
            default:
                //Debug.Log("縦の動きが足りません");
                return string.Empty;
        }
    }
}
