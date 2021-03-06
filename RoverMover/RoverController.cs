﻿using RoverMover.Interfaces;

namespace RoverMover
{
    public class RoverController : IRoverController
    {
        private Rover _rover;
        private readonly IRoverTurn _turner;
        public RoverController(IRoverTurn turn)
        {
            _rover = new Rover();
            _rover.YCoOrdinate = 0;
            _rover.XCoOrdinate = 0;
            _rover.CompassDirection = Compass.N;

            _turner = turn;
        }

        public Rover MoveForward()
        {
            if (_rover.CompassDirection == Compass.N || _rover.CompassDirection == Compass.S)
            {
                _rover.YCoOrdinate = _rover.YCoOrdinate + 1;
                if (_rover.YCoOrdinate == 101)
                    _rover.YCoOrdinate = 0;
            }
            else
            {
                if (_rover.CompassDirection == Compass.E)
                {
                    _rover.XCoOrdinate = _rover.XCoOrdinate + 1;
                    if (_rover.XCoOrdinate == 101)
                        _rover.XCoOrdinate = 0;
                }
                else
                {
                    _rover.XCoOrdinate = _rover.XCoOrdinate - 1;
                    if (_rover.XCoOrdinate == -1)
                        _rover.XCoOrdinate = 100;
                }
            }
            return _rover;
        }

        public Rover MoveBackward()
        {
            if (_rover.CompassDirection == Compass.N || _rover.CompassDirection == Compass.S)
            {
                _rover.YCoOrdinate = _rover.YCoOrdinate - 1;
                if (_rover.YCoOrdinate == -1)
                    _rover.YCoOrdinate = 100;
            }
            else
            {
                if (_rover.CompassDirection == Compass.E)
                {
                    _rover.XCoOrdinate = _rover.XCoOrdinate - 1;
                    if (_rover.XCoOrdinate == -1)
                        _rover.XCoOrdinate = 100;
                }
                else
                {
                    _rover.XCoOrdinate = _rover.XCoOrdinate + 1;
                    if (_rover.XCoOrdinate == 101)
                        _rover.XCoOrdinate = -1;
                }
            }

            return _rover;
        }

        public Rover TurnLeft()
        {
            _turner.Turn("LEFT", ref _rover);
            return _rover;
        }
        
        public Rover TurnRight()
        {
            _turner.Turn("RIGHT", ref _rover);
            return _rover;
        }
    }
}
