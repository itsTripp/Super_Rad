using System;
using System.Linq;
using UnityEngine;
using Edgar.Unity;
using Cinemachine;

    [CreateAssetMenu(menuName = "Super_Rad/PostProcessing Task", fileName = "Level PostProcessing Task")]
    public class LevelPostProcessingTask : DungeonGeneratorPostProcessingComponentGrid2D
    {
    public Transform InitialSpawn;
        public override void Run(DungeonGeneratorLevelGrid2D level)
        {
            SetSpawnPosition(level);
        }
        /// <summary>
        /// Move the player to the spawn point of the level.
        /// </summary>
        /// <param name="level"></param>
        private void SetSpawnPosition(DungeonGeneratorLevelGrid2D level)
        {
            // Find the room with the Entrance type
            var entranceRoomInstance = level
                .RoomInstances
                .FirstOrDefault(x => ((LevelRoom)x.Room).Type == LevelRoomType.Entrance);

            if (entranceRoomInstance == null)
            {
                throw new InvalidOperationException("Could not find Entrance room");
            }

            var roomTemplateInstance = entranceRoomInstance.RoomTemplateInstance;

            // Find the spawn position marker
            var spawnPosition = roomTemplateInstance.transform.Find("SpawnPosition");

            // Move the player to the spawn position
           // var player = GameObject.FindWithTag("Player");
            InitialSpawn.transform.position = spawnPosition.position;
        }
    }
