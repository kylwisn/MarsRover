using System;
using Xunit;
using MarsRover;


namespace MarsRoverTests
{
    public class RoverShould
    {
        [Fact]
        public void SpinLeft() //Testing spin left
        {
            //arrange
            Rover rover = new Rover("1 2 N");
            //act
            rover.SpinLeft();
            Assert.Equal("W", rover.direction);
            // End SpinLeft()
        }

        [Fact]
        public void SpinRight() //Testing spin right
        {
            //arrange
            Rover rover = new Rover("1 2 N");
            //act
            rover.SpinRight();
            //assert
            Assert.Equal("E", rover.direction);
            // End SpinRight()
        }

        [Fact]
        public void StepForward() //Testing step forward
        {
            //arrange
            Rover rover = new Rover("1 2 S");
            //act
            rover.StepForward();
            //assert
            Assert.Equal(1, rover.y);
            // End StepForward()
        }

        [Fact]
        public void ArriveAt13N() //Testing starting input and command to get 1 3 N result.
        {
            //arrange
            Rover rover = new Rover("1 2 N");
            //act
            rover.Move("LMLMLMLMM");
            //assert
            Assert.Equal("1 3 N", rover.x + " " + rover.y + " " + rover.direction);
            // End ArriveAt13N()
        }

        [Fact]
        public void ArriveAt51E() //Testing starting input and command to get 5 1 E result.
        {
            //arrange
            Rover rover = new Rover("3 3 E");
            //act
            rover.Move("MMRMMRMRRM");
            //assert
            Assert.Equal("5 1 E", rover.x + " " + rover.y + " " + rover.direction);
            // End ArriveAt13N()
        }


    }
}
