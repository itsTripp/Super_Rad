using System;
using UnityEngine;
using Edgar.Unity;

[Serializable]
public class RoomTemplatesConfig
{
  public GameObject[] DefaultRoomTemplates;

  public GameObject[] TeleportRoomTemplates;

  #region hide

  public GameObject[] TreasureRoomTemplates;

  public GameObject[] EntranceRoomTemplates;

  public GameObject[] ExitRoomTemplates;

  public GameObject[] CorridorRoomTemplates;

  public GameObject[] SecretRoomTemplates;

  public GameObject[] BossRoomTemplates;

  #endregion

  public GameObject[] GetRoomTemplates(LevelRoom room)
  {
    switch (room.Type)
    {
      case LevelRoomType.Teleport:
        return TeleportRoomTemplates;

      case LevelRoomType.Treasure:
        return TreasureRoomTemplates;

      case LevelRoomType.Entrance:
        return EntranceRoomTemplates;

      case LevelRoomType.Exit:
        return ExitRoomTemplates;

      case LevelRoomType.Secret:
        return SecretRoomTemplates;

      case LevelRoomType.Boss:
        return BossRoomTemplates;

      default:
        return DefaultRoomTemplates;
    }
  }
}