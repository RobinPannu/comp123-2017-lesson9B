using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp123_2017_lesson9B
{
    /// <summary>
    /// this is my superhuiman class
    /// </summary>
    public class SuperHuman : Human
    class SuperHuman
    {
        //   private instance variablE
        private List<POWER> _powers;
        // PUBLIC PROPERTIES
        // CONSTRUCTOR
        public SuperHuman(string name)
            : base(name)
        {
            this._initialize();

        }
        //PRIVATE METHODS
        private void initialize()
        {
            this._powers = new List<POWER>();
        }
        // PUBLIC METHOD
    }
}
