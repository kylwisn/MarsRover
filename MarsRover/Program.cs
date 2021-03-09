using System;


// Mission Objective: 
// Rover: Position and location represented by (x,y,z). Where z is a compass direction (N, E, W, S)
//  2 rovers in play
// Plateau: Rectulangualr grid positions (x,y,z). Where (0,0,N) means X=0, Y=0, Z=N or bottom left of the grid and the rover is facing north. (0,1) is up one grid block from (0,0) and (1,1) is one grid block to the right of (0,1).
//      Maximum Coordinates -> (Max x, Max y)
// Command (Message): String, (aaaaaaaa) represented by (L, R, M) where L= spin left 90 degrees left, R= spins rover 90 degrees right and M= moves the rover forward by 1.
// Input = 5 lines
//  1. Plateau size (5:5)
//  2. Array of RoverInstruction objects, where RoverInstruction object contains:
//      a. RoverInstruction -> (first line)
//      b. RoverCommand -> (Second Line)
// Output = 2 lines
//
// Expected behaviors
//  1. Rover should spin left: SpinLeft()
//  2. Rover should spin right: SpinRight()
//  3. Rover should move forward: StepForward()
//  4. Rover should go to 1 N N after the first set of inputs
//  5. Rover should now move. 



namespace MarsRover
{
    class Program
    {

        static void Main(string[] args)
        {
            //string startLocation;
            string moveCommand;
            string startLocation;

            //Enter starting location
            Console.Write("First Rover: Enter starting location: ");
            startLocation = Console.ReadLine();

            //Enter the instruction string
            Console.Write("First Rover: Enter instruction string: ");
            moveCommand = Console.ReadLine();

            //Create rover1 object
            Rover rover1 = new Rover(startLocation);
            
            //Launching the Move function of rover1 with the moveCommand string
            rover1.Move(moveCommand);

            //Reporting the final position of rover1
            Console.WriteLine("Rover 1 final position: " + rover1.newLocation);


            //Visual line break for separating rovers in the console
            Console.WriteLine();
            Console.WriteLine();


            //Enter starting location
            Console.Write("Second Rover: Enter starting location: ");
            startLocation = Console.ReadLine();

            //Enter the instruction string
            Console.Write("Second Rover: Enter instruction string: ");
            moveCommand = Console.ReadLine();

            //Create rover2 object
            Rover rover2 = new Rover(startLocation);

            //Launching the Move function of rover2 with the moveCommand string
            rover2.Move(moveCommand);

            //Reporting the final position of rover2
            Console.WriteLine("Rover 2 final position: " + rover2.newLocation);

            // End Main
        }


    }
}
