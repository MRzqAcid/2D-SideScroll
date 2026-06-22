using Unity.VisualScripting;
using UnityEngine;

public class PlayerPositionHandler : MonoBehaviour
{

    [SerializeField] Vector2 playerCurretPosition;

    public Vector2 currentCheckpointPosition;

    public TransformData playerPositionData;

    private TriggerEvent playerTriggerEvent;

    void Start()
    {

       playerTriggerEvent = GetComponent<TriggerEvent>();
       currentCheckpointPosition = new Vector2 (-14f, -2);

    }

    #region
    public void OnCheckpoint(GameObject col)
    {
        Vector2 newCheckpointPosition = col.transform.position;
        currentCheckpointPosition = newCheckpointPosition;
        SavePos(currentCheckpointPosition);

    }


    public void OnTrap()
    {
        ChangePlayerPosition(currentCheckpointPosition);
    }

    public void OnFinish()
    {
        playerPositionData.ResetData();
    }
    #endregion




    private void ChangePlayerPosition(Vector2 newPosition)
    {

        transform.position = newPosition;

    }

    private void LoadPos()
    {
        playerCurretPosition = playerPositionData.position;
    }

    private void SavePos(Vector2 newPosition)
    {
        playerPositionData.position = newPosition;
    }
}
