using System.Linq;
using UnityEngine;
using Edgar.Unity;

[CreateAssetMenu(menuName = "Super_Rad/Input Setup", fileName = "Level Input Setup")]
public class LevelInputSetupTask : DungeonGeneratorInputBaseGrid2D
{
  public LevelGraph LevelGraph;

  public RoomTemplatesConfig RoomTemplates;

  /// <summary>
  /// This is the main method of the input setup.
  /// It prepares the description of the level for the procedural generator.
  /// </summary>
  /// <returns></returns>
  protected override LevelDescriptionGrid2D GetLevelDescription()
  {
    var levelDescription = new LevelDescriptionGrid2D();

    // Go through individual rooms and add each room to the level description
    // Room templates are resolved based on their type
    foreach (var room in LevelGraph.Rooms.Cast<LevelRoom>())
    {
      levelDescription.AddRoom(room, RoomTemplates.GetRoomTemplates(room).ToList());
    }

    // Go through individual connections and for each connection create a corridor room
    foreach (var connection in LevelGraph.Connections.Cast<LevelConnection>())
    {
      var corridorRoom = ScriptableObject.CreateInstance<LevelRoom>();
      corridorRoom.Type = LevelRoomType.Corridor;
      levelDescription.AddCorridorConnection(connection, corridorRoom, RoomTemplates.CorridorRoomTemplates.ToList());
    }

    return levelDescription;
  }
}
