using System;

public class Rover
{
    public int x { get; set; }
    public int y { get; set; }
    public char heading { get; set; }
    public Rover()
	{
	}


    public static bool PerformCommand(char command, Rover rover)
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
                    rover.y += 1;
                if (rover.heading == 'S')
                    rover.y -= 1;
                if (rover.heading == 'E')
                    rover.x += 1;
                if (rover.heading == 'W')
                    rover.x -= 1;
                break;

            default:
                return false;
        }
        return true;
    }
}
