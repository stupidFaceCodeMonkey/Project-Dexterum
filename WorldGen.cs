using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dexterum
{
    public class WorldGen
    {
        /// <summary>
        /// класс представляющий из себя кусок глобальной карты 256х256 метров
        /// </summary>
        internal class Chunk
        {
            internal int parralel, mediana, elevation;
            FloorHex[,] Size = new FloorHex[256, 256];
            internal FloorHex[,] plain { get { return Size; } set { Size = value; } }
            /// <summary>
            /// Задает карту тайлов чанку 256х256 метров/тайлов
            /// </summary>
            /// <param name="tileMap">массив тайлов представляющий из себя карту чанка</param>
            public void SetTilesOfChunk(FloorHex[,] tileMap)
            {
                if (!(tileMap.GetLength(0) == 256) || !(tileMap.GetLength(1) == 256))
                {
                    Console.WriteLine("Wrong size");
                }
                else
                {
                    this.plain = tileMap;
                }
            }
            /// <summary>
            /// Возвращает карту чанка в виде массива 256х256
            /// </summary>
            /// <returns></returns>
            public FloorHex[,] GetTilesOfChunk()
            {
                return this.plain;
            }

        }
        /// <summary>
        /// Класс представляющий из себя стандартный тайл.
        /// </summary>
        internal class FloorHex
        {
            internal string Name { get; set; } = "Dirt";
            internal string Description { get; set; } = "Dry and sturdy dirt";
            internal char tile { get; set; } = '◘';
            internal double MovingDifficulty { get; set; } = 1;
            internal bool IsSolid { get; set; } = true;
        }
        /// <summary>
        /// Класс содержащий в себе список всех тайлов и их параметров
        /// </summary>
        internal class FloorsLib
        {
            FloorHex Dirt = new FloorHex { Name="Dirt", Description = "Dry brownish dirt", IsSolid=true,MovingDifficulty=1, tile = '◘' };
            FloorHex Air = new FloorHex { Name = "Air", Description = "You cant quite see it", IsSolid = false, MovingDifficulty = 1, tile = ' ' };
            FloorHex Sand = new FloorHex { Name = "Sand", Description = "Really small bits of rock", IsSolid = true, MovingDifficulty = 1.5, tile = ':' };
            FloorHex Stone = new FloorHex { Name = "Stone", Description = "Some kind of stone", IsSolid = true, MovingDifficulty = 1, tile = '◙' };


        }
    }
}
