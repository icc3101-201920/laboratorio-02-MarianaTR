using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902.Card
{
    public class Card
    {
        //Atributos
        private string name;
        private string type;
        private string effect;

        //GET AND SET
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                this.type = value;
            }
        }
        public string Effect
        {
            get
            {
                return effect;
            }
            set
            {
                this.effect = value;
            }
        }


        //CONSTRUCTOR

        public Card(string name,string type, string effect)
        {
            this.name = name;
            this.type = type;
            this.effect = effect;
        }
    }
}
