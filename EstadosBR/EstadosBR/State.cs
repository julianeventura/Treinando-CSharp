using System;

namespace EstadosBR
{
    public class State
    {
        public State(string name, string acronym)
        {
            this.Name = name;
            this.Acronym = acronym;
        }

        public string Name { get; set; }

        public string Acronym { get; set; }

    }

}