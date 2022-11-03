using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Edgar.Unity;

public class LevelRoom : RoomBase
{
  public LevelRoomType Type;

  public bool Outside;

  public override List<GameObject> GetRoomTemplates()
  {
    // We do not need any room templates here because they are resolved based on the type of the room.
    return null;
  }

  public override string GetDisplayName()
  {
    // Use the type of the room as its display name.
    return Type.ToString();
  }

  public override RoomEditorStyle GetEditorStyle(bool isFocused)
  {
    var style = base.GetEditorStyle(isFocused);

    var backgroundColor = style.BackgroundColor;

    // Use different colors for different types of rooms
    switch (Type)
    {
      case LevelRoomType.Entrance:
        backgroundColor = new Color(38 / 256f, 115 / 256f, 38 / 256f);
        break;

      case LevelRoomType.Exit:
        backgroundColor = new Color(128 / 256f, 0 / 256f, 0 / 256f);
        break;

      case LevelRoomType.Secret:
        backgroundColor = new Color(102 / 256f, 0 / 256f, 204 / 256f);
        break;

      case LevelRoomType.Teleport:
        backgroundColor = new Color(102 / 256f, 0 / 256f, 204 / 256f);
        break;

      case LevelRoomType.Treasure:
        backgroundColor = new Color(102 / 256f, 0 / 256f, 204 / 256f);
        break;

      case LevelRoomType.Boss:
        backgroundColor = Color.red;
        break;
    }

    style.BackgroundColor = backgroundColor;

    // Darken the color when focused
    if (isFocused)
    {
      style.BackgroundColor = Color.Lerp(style.BackgroundColor, Color.black, 0.7f);
    }

    return style;
  }
}
