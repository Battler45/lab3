using System;
using System.Collections.Generic;
using System.Drawing;

namespace lab3_CV
{
    public class BorderFinder
    {
        public static BorderFinder GetInstance() => new BorderFinder();
        private static Walker FindBorderNeighborInSquareAroundWalker(Bitmap image, Walker walker, Color borderColor)
        {
            var neighbor = walker.Copy();
            for (var i = 0; i < 8; i++)
            {
                neighbor.MoveAhead();
                if (image.GetColor(neighbor.Position) == borderColor)
                    return neighbor;
                neighbor.TurnLeft();
            }
            return null;
        }
        public List<Point> FindBorder(Bitmap image, Point start, Color borderColor)
        {
            var border = new List<Point> { start };
            var walker = Walker.GetInstance(start);
            do
            {
                walker.TurnRight();
                var walkerBorderNeighbor = FindBorderNeighborInSquareAroundWalker(image, walker, borderColor);
                if (walkerBorderNeighbor == null) continue;
                border.Add(walkerBorderNeighbor.Position);
                walker = walkerBorderNeighbor;
            } while (walker.Position != start);
            return border;
        }
        private class Walker
        {
            private Direction _direction;
            private Point _position;
            public Point Position => _position;
            private Walker(Point position, Direction direction = Direction.Right) => (_position, _direction) = (position, direction);
            public static Walker GetInstance(Point position) => new Walker(position);
            public void TurnRight() => _direction = (Direction)(((int)_direction + 6) % 8);
            public void TurnLeft() => _direction = (Direction)(((int)_direction + 2) % 8);
            public Walker Copy() => new Walker(_position, _direction);
            public void MoveAhead() => Move(_direction);
            private void Move(Direction direction)
            {
                switch (direction)
                {
                    case Direction.Right:
                        _position.Offset(1, 0);
                        break;
                    case Direction.Up:
                        _position.Offset(0, 1);
                        break;
                    case Direction.Left:
                        _position.Offset(-1, 0);
                        break;
                    case Direction.Down:
                        _position.Offset(0, -1);
                        break;
                    case Direction.UpRight:
                        _position.Offset(1, 1);
                        break;
                    case Direction.UpLeft:
                        _position.Offset(-1, 1);
                        break;
                    case Direction.DownLeft:
                        _position.Offset(-1, -1);
                        break;
                    case Direction.DownRight:
                        _position.Offset(1, -1);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
                }
            }
            private enum Direction
            {
                Right, UpRight, Up, UpLeft, Left, DownLeft, Down, DownRight
            }
        }
    }
}