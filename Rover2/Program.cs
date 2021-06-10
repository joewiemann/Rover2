using System;

namespace RoverApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rover rover = new Rover();
            int[] inputValues;
            int width, height;
       
            Console.WriteLine("Enter Size Of Field ('5 5'):");
          
            string input = Console.ReadLine();
            if (TryParseIntegerList(input, out inputValues))
            {
                if (inputValues.Length == 2)
                {
                    width = inputValues[0];
                    height = inputValues[1];
                }
                Grid grid = new Grid(width, height);
                Console.WriteLine("Enter Position and Direction Rover Is Facing: ('1 2 N'):");
                input = Console.ReadLine();
                if(TryParsePositionAndHeading(input, rover))
                {
                    Console.WriteLine("Enter Direction and movements for the Rover: ('MMRMMRMRRM");
                    input = Console.ReadLine();
                    char command = default;
                    int i;
                    for (i = 0; i < input.Length; i++)
                    {
                        command = input[i];
                        if (!Rover.PerformCommand(command, rover))
                            Console.WriteLine("Command Failed:{0}, {1}, {2}, {3}", command, rover.x, rover.y, rover.heading);
                    }

                    Console.WriteLine("{1} {2} {3}", command, rover.x, rover.y, rover.heading);
                }
            }
        
         }

        public static bool TryParseIntegerList(string input, out int[] inputValues)
        {
            inputValues = default;
            string[] splits = input.Split(" ");
            int[] result = new int[splits.Length];
            for (int i = 0; i < splits.Length; i++)
            {
                if (!int.TryParse(splits[i].Trim(), out result[i]))
                {
                    return false;
                }
            }
            inputValues = result;
            return true;
        }
        public static bool TryParsePositionAndHeading(string input, Rover rover)
        {
            string[] splits = input.Split(" ");

            if (splits.Length == 3)
            {
                int x, y;
                char heading;

                if (!int.TryParse(splits[0].Trim(), out x))
                    return false;
                
                if (!int.TryParse(splits[1].Trim(), out y))
                    return false;
                
                if (!char.TryParse(splits[2].Trim(), out heading))
                    return false;

                rover.x = x;
                rover.heading = heading;
                rover.y = y;
                return true;
            }
            return false;
        }
    }
}
