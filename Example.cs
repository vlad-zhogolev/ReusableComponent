using UnityEngine;
using LabyrinthGame.Labyrinth;

namespace Playground
{
    public class Example : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Tile[,] tiles = new Tile[3, 3];
            tiles[0, 0] = new Tile(Tile.Type.Straight);
            tiles[0, 1] = new Tile(Tile.Type.Straight);
            tiles[0, 2] = new Tile(Tile.Type.Straight);

            tiles[1, 0] = new Tile(Tile.Type.Straight);
            tiles[1, 1] = new Tile(Tile.Type.Straight);
            tiles[1, 2] = new Tile(Tile.Type.Straight);

            tiles[2, 0] = new Tile(Tile.Type.Straight);
            tiles[2, 1] = new Tile(Tile.Type.Straight);
            tiles[2, 2] = new Tile(Tile.Type.Straight);

            Tile freeTile = new Tile(Tile.Type.Junction);

            Labyrinth labyrinth = new Labyrinth(tiles, freeTile);
            Debug.Log("Labyrinth created");

            var source = new Vector2Int(0, 0);
            var target = new Vector2Int(1, 0);
            var isReachable = labyrinth.IsReachable(source, target);
            Debug.LogFormat("Tile ({0}, {1}) is {2}reachable from tile ({3}, {4})", target.x, target.y, isReachable ? "" : "not ", source.x, source.y);
        }
    }
}
