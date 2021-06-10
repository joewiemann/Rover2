using System;

public class Rover
{
    public int x { get; set; }
    public int y { get; set; }
    public char heading { get; set; }
    public Rover()
	{
	}


    public static bool PerformCommand(char command, Grid grid, Rover rover)
    {
        switch (command)
        {
            case 'L':
                if (rover.heading == 'N')
                    rover.heading = 'W';
                else if (rover.heading == 'W')
                    rover.heading = 'S';
                else if (rover.heading == 'S')
                    rover.heading = 'E';
                else if (rover.heading == 'E')
                    rover.heading = 'N';
                break;
            case 'R':
                if (rover.heading == 'N')
                    rover.heading = 'E';
                else if (rover.heading == 'E')
                    rover.heading = 'S';
                else if (rover.heading == 'S')
                    rover.heading = 'W';
                else if (rover.heading == 'W')
                    rover.heading = 'N';
                break;
            case 'M':
                if (rover.heading == 'N')
                    if (rover.y < grid.Height)
                        rover.y += 1;
                    else
                        rover.y = grid.Height;
                if (rover.heading == 'S')
                    if (rover.y > 0)
                        rover.y -= 1;
                    else
                        rover.y = 0;
                if (rover.heading == 'E')
                    if (rover.x < grid.Width)
                        rover.x += 1;
                    else
                        rover.x = grid.Width;
                if (rover.heading == 'W')
                    if (rover.x > 0)
                        rover.x -= 1;
                    else
                        rover.x = 0;
                break;

            default:
                return false;
        }
        return true;
    }
}
