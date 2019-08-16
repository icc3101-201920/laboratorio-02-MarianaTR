using Laboratorio_1_OOP_201902.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Board
    {
        //Constantes
        private const int DEFAULT_NUMBER_OF_PLAYERS = 2;

        //Atributos
        private List<CombatCard>[] meleeCards;
        private List<CombatCard>[] rangeCards;
        private List<CombatCard>[] longRangeCards;

        private SpecialCard[] specialMeleeCards;
        private SpecialCard[] specialRangeCards;
        private SpecialCard[] specialLongRangeCards;

        private SpecialCard[] captainCards;
        private List<SpecialCard> weatherCards;
        private Player jugador;



        //Propiedades
        public List<CombatCard>[] MeleeCards
        {
            get
            {
                return this.meleeCards;
            }
        }
        public List<CombatCard>[] RangeCards
        {
            get
            {
                return this.rangeCards;
            }
        }
        public List<CombatCard>[] LongRangeCards
        {
            get
            {
                return this.longRangeCards;
            }
        }
        public SpecialCard[] SpecialMeleeCards
        {
            get
            {
                return this.specialMeleeCards;
            }
            set
            {
                this.specialMeleeCards = value;
            }
        }
        public SpecialCard[] SpecialRangeCards
        {
            get
            {
                return this.specialRangeCards;
            }
            set
            {
                this.specialRangeCards = value;
            }
        }
        public SpecialCard[] SpecialLongRangeCards
        {
            get
            {
                return this.specialLongRangeCards;
            }
            set
            {
                this.specialLongRangeCards = value;
            }
        }
        public SpecialCard[] CaptainCards
        {
            get
            {
                return this.captainCards;
            }
        }
        public List<SpecialCard> WeatherCards
        {
            get
            {
                return this.weatherCards;
            }
        }


        //Constructor
        public Board()
        {
            this.meleeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.rangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.longRangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.weatherCards = new List<SpecialCard>();
            this.captainCards = new SpecialCard[DEFAULT_NUMBER_OF_PLAYERS];
           
        }

        

        //Metodos
        public void AddMeleeCard(int PlayerId, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddRangeCard(int PlayerId, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddLongRangeCard(int PlayerId, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddCaptainCard(int PlayerId, SpecialCard specialCard)
        {
            throw new NotImplementedException();
        }
        public void AddWeatherCard(int PlayerId, SpecialCard specialCard)
        {
            throw new NotImplementedException();
        }
        public void DestroyMeleeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroyRangeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroyLongRangeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialMeleeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialRangeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialLongRangeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroyWeatherCard(int PlayerId)
        {
            throw new NotImplementedException();
        }

        //NUEVOS METODOS
        public void AddCombatCard(int playerId, CombatCard combatCard)
        {
            string tipo = combatCard.Type;
            if (tipo == "melee")
            {
                meleeCards[playerId].Add(combatCard);
            }
            else if (tipo == "range")
            {
                rangeCards[playerId].Add(combatCard);
            }
            else if (tipo=="longRange")
            {
                LongRangeCards[playerId].Add(combatCard);
            }
            return;

        }

        public void AddSpecialCard(SpecialCard specialCard, int playerId, string buffType)
        {
            string ty = specialCard.Type;
            if (ty == "melee")
            {
                if (specialMeleeCards[playerId] == null)
                {
                    specialMeleeCards[playerId] = specialCard;
                }
                else
                {
                    Console.WriteLine("Ya  tiene una Special Card Melee");
                }
            }
            else if (ty == "range")
            {
                if (SpecialRangeCards[playerId] == null)
                {
                    SpecialRangeCards[playerId] = specialCard;
                }
                else
                {
                    Console.WriteLine("Ya tiene  una Special Card Range");
                }
            }
            else if (ty == "longRange")
            {
                if (SpecialLongRangeCards[playerId] == null)
                {
                    SpecialLongRangeCards[playerId] = specialCard;
                }
                else
                {
                    Console.WriteLine("Ya tiene  una Special Card  LongRange");
                }
            }
            
        }

        public void DestroyCombatCard(int playerId)
        {
            meleeCards[playerId].Clear();
            rangeCards[playerId].Clear();
            longRangeCards[playerId].Clear();
            return;
        }

        public void DestroySpecialCards(int playerId)   //inclui un parametro porque segun yo faltaba para poder hacer de cada jugador
        {
            SpecialMeleeCards[playerId] = null;
            SpecialLongRangeCards[playerId] = null;
            specialRangeCards[playerId] = null;
            return;

        }

        public Array GetMeleeAttackPoints()
        {
            //retornar en un arregglo cada punto de ataca del jugador

            int primerJugador = 0;
            int segundoJugador = 0;
            int i = 0;
            while (i < 3)
            {
                for (int j = 0; j < meleeCards[i].Count; j++)
                {
                    if (i == 0)
                    {
                        primerJugador += meleeCards[i][j].AttackPoints;
                    }
                    else
                    {
                        segundoJugador += meleeCards[i][j].AttackPoints;
                    }
                }
                
                
            }
            int[,] arrayR = new int[primerJugador, segundoJugador];
            return arrayR;

        }

        public Array GetRangeAttackPoints()
        {
            int jugador0 = 0;
            int jugador1 = 0;
            int i = 0;
            
            while (i<3)
            {
                for (int j=0; j<rangeCards[i].Count; j++)
                {
                    if (i == 0)
                    {
                        jugador0 += rangeCards[i][j].AttackPoints;
                    }
                    else
                    {
                        jugador1 += rangeCards[i][j].AttackPoints;
                    }
                        
                }
                i++;
            }

            int[,] contador = new int[jugador0, jugador1];
            return contador;

        }

        public Array GetLongRangeAttackPoints()
        {
            int J0 = 0;
            int J1 = 0;
            int i = 0;
            while (i<3)
            {
                for (int j=0; j < LongRangeCards[i].Count; j++)
                {
                    if (i==0)
                    {
                        J0 += LongRangeCards[i][j].AttackPoints;
                    }
                    else
                    {
                        J1 += LongRangeCards[i][j].AttackPoints;
                    }
                }
                i++;
            }

            int[,] puntaje = new int[J0, J1];
            return puntaje;
        }

    }
}
