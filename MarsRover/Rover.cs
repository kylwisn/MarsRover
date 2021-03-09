using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{

    public class Rover
    {
        public int x; // x coordinate of the current rover's position
        public int y; // y cooridnate of the current rover's position
        public string direction; // cardinal (compass) direction of the current rover position
        public string newLocation; // Outputting the updated location


        public Rover(string location) // location = "1 2 N"
        {
            Int32.TryParse(location.Split(" ")[0], out x);
            Int32.TryParse(location.Split(" ")[1], out y);
            direction = location.Split(" ")[2];

            // End Rover directions input
        }

        public void SpinLeft() //Rover spins left
        {
            switch (direction)
            {
                case "N":
                    direction = "W";
                    break;
                case "E":
                    direction = "N";
                    break;
                case "S":
                    direction = "E";
                    break;
                case "W":
                    direction = "S";
                    break;
                default:
                    throw new ArgumentException();
            }

            // End SpinLeft
        }

        public void SpinRight() //Rover spins right
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "W":
                    direction = "N";
                    break;
                default:
                    throw new ArgumentException();
            }

            // End SpinRight
        }

        public void StepForward() //Rover steps forward
        {
            switch (direction)
            {
                case "N":
                    y++; //add one
                    break;
                case "E":
                    x++; //add one
                    break;
                case "S":
                    y--; //subtract one
                    break;
                case "W":
                    x--; //subtract one
                    break;
                default:
                    throw new ArgumentException();
            }

            // End StepForward
        }


        public void Move(string roverCommand) // Moving the rover with the roverCommand string input. Example: "LMLMLMLMM" or "MMRMMRMRRM"
        {
            //Char Array
            char[] instructions = roverCommand.ToCharArray();

            // loop through array. For each letter, call SpinLeft, SpinRight, or StepForward as commanded.
            foreach (char i in instructions)
            {

                switch (i)
                {
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    case 'M':
                        StepForward();
                        break;
                    default:
                        throw new ArgumentException();
                }

                // end for loop
            }
            
            //defining newLocation as the expected output coordinates
            newLocation = x + " " + y + " " + direction;

            // End Move
        }












    }
}
