using System.Collections;
using System.ComponentModel;
using UnityEngine;

[CreateAssetMenu(fileName = "new Tool Class", menuName = "Item/Tool")]
public class ToolClass : ItemClass
{
    [Header("Tool")] //data shared across all tool type
    public ToolType toolType;

    public enum ToolType
    {
        RottenFood,
        Plates,
        Knives
    }
    public override ItemClass GetItem() {  return this; }
    public override ToolClass GetTool() { return this; }
}
