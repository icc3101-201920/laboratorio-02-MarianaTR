using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Game
    {
        //Atributos
        private Player[] players;
        private Player activePlayer;
        private Board boardGame;
        private bool endGame;
        private int i;

        //Constructor
        public Game()
        {
            Random random = new Random();
            players = new Player[2] { new Player(), new Player() };
            ActivePlayer = players[random.Next(0, 2)];
            boardGame = new Board();
            EndGame = false;
            i = 1;

        }
        //Propiedades
        public Player[] Players
        {
            get
            {
                return this.players;
            }
        }
        public Player ActivePlayer
        {
            get
            {
                return this.activePlayer;
            }
            set
            {
                activePlayer = value;
            }
        }
        public Board BoardGame
        {
            get
            {
                return this.boardGame;
            }
        }
        public bool EndGame
        {
            get
            {
                return this.endGame;
            }
            set
            {
                endGame = value;
            }
        }

        //Metodos
        public bool CheckIfEndGame()   // verificar que uno de los jugadores tenga vida 0, si tiene 0 vidas retornar true
        {
            if (players[0].LifePoints == 0 || players[1].LifePoints ==0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public int GetWinner()  //verificar cual gano con las vidas
        {
            if (CheckIfEndGame() == false)
            {
                throw new System.InvalidOperationException("No hay ganador por los momentos");  //se utiliza para mostrarle al usuario que lo que mando a hacer o verificar aun no se puede definir
            }
            else if (players[0].LifePoints == 0)
            {
                return players[1].Id;
            }
            else
            {
                return players[0].Id; 
            }
        }
        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
