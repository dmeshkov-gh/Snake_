using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine DownLine = new HorizontalLine(0, mapWidth -2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, mapHeight - 1, '+');
            VerticalLine rightLine = new VerticalLine(mapWidth - 2, 0, mapHeight - 1, '+');
            wallList.Add(upLine);
            wallList.Add(DownLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal void Draw()
        {
            foreach(Figure wall in wallList)
            {
                wall.Draw();
            }
        }
        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
