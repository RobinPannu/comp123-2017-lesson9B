using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp123_2017_lesson_9B
{
    // ,summURY>
    // THIS is human abstract class
    // </summary>
    public abstract class Human

    class Program
    {
        /// <summary>
        ///  private ibnstance variable (field)
        private string _name;
        ///  PUBLIC PROPERTIES
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        ///  CONSTRUCTor
        public Human(string name)
        {
            this.Name = name
        }

        ///  PRIVATE METHODS
        ///  
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
        }
    }
}
