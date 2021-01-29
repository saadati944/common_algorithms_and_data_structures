using System;
using System.Collections.Generic;

namespace algos
{
    class Program
    {
        // this is the maze which program wants to solve
        // '#' are the walls
        // 's' is the start point
        // 'e' is the end point
        public static string[] Maze = new string[]
        {
            "###############",
            "#s  ###### ####",
            "### ##     ####",
            "###    ## ## ##",
            "###### ##    ##",
            "##     ## #####",
            "## ######    ##",
            "## ###   ## ###",
            "## #### #######",
            "## ###        #",
            "#  ###### ### #",
            "# ####### ### #",
            "# #    ## ### #",
            "#   ##    ###e#",
            "###############"
        };

        static void Main(string[] args)
        {
            Console.WriteLine("maze :");
            Draw();

            // find start and end points
            // start point  = points[0]
            // end point    = points[1]
            Point[] points = FindStartAndEnd();

            // solve the maze
            List<Point> path = new List<Point>();
            Solve(points[0], points[1], path);

            // and finally write to standard output
            Console.WriteLine("\nsolved maze :");
            Draw(path);
        }

        /// <summary>
        /// solve the maze with DepthFirstSearch algorithm
        /// </summary>
        static bool Solve(Point start, Point end, List<Point> path)
        {
            if (path.Contains(start))
                return false;

            path.Add(start);

            if (start.Equals(end))
                return true;
            if (start.Y < Maze[0].Length - 1 && Maze[start.X][start.Y + 1] != '#' &&
                Solve(new Point(start.X, start.Y + 1), end, path))
                return true;
            if (start.X < Maze.Length - 1 && Maze[start.X + 1][start.Y] != '#' &&
                Solve(new Point(start.X + 1, start.Y), end, path))
                return true;
            if (start.Y > 0 && Maze[start.X][start.Y - 1] != '#' && Solve(new Point(start.X, start.Y - 1), end, path))
                return true;
            if (start.X > 0 && Maze[start.X - 1][start.Y] != '#' && Solve(new Point(start.X - 1, start.Y), end, path))
                return true;

            path.Remove(start);
            return false;
        }

        /// <summary>
        /// draw maze to standard output
        /// </summary>
        /// <param name="path">pass a path to this function to color the path</param>
        static void Draw(List<Point> path = null)
        {
            Console.ForegroundColor = ConsoleColor.White;
            if (path == null)
                foreach (string x in Maze)
                {
                    foreach (char y in x)
                    {
                        Console.Write(y);
                        Console.Write(y);
                    }

                    Console.WriteLine();
                }
            else
            {
                for (int i = 0; i < Maze.Length; i++)
                {
                    for (int j = 0; j < Maze[0].Length; j++)
                        if (path.Contains(new Point(i, j)))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write('+');
                            Console.Write('+');
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(Maze[i][j]);
                            Console.Write(Maze[i][j]);
                        }

                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// find start and end points accourding to 's' and 'e' characters in the maze
        /// </summary>
        /// <returns>{Point start, Point end}</returns>
        static Point[] FindStartAndEnd()
        {
            Point[] points = new Point[] {new Point(), new Point()};
            for (int i = 0; i < Maze.Length; i++)
            {
                for (int j = 0; j < Maze[0].Length; j++)
                {
                    if (Maze[i][j] == 's')
                        points[0] = new Point(i, j);
                    else if (Maze[i][j] == 'e')
                        points[1] = new Point(i, j);
                    else if (points[0].X != -1 && points[1].X != -1)
                        return points;
                }
            }

            return points;
        }

    }

    /// <summary>
    /// this is a simple class to represent a point in our world
    /// </summary>
    class Point
    {
        public int X = -1, Y = -1;

        public Point(int x = -1, int y = -1)
        {
            this.X = x;
            this.Y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj != null && ((Point) obj).X == this.X && ((Point) obj).Y == this.Y)
                return true;
            return false;
        }

        protected bool Equals(Point other)
        {
            return X == other.X && Y == other.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}