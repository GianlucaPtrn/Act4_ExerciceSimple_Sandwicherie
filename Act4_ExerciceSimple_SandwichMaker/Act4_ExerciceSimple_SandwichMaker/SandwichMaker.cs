using System;
using System.Collections.Generic;
using System.Text;

namespace Act4_ExerciceSimple_SandwichMaker
{
    class SandwichMaker
    {
		private string[] _proteine = new string[4] {"steak", "hamburger", "poison", "jambon"};
		private string[] _condiments = new string[4] { "moyonnaise", "ketchup", "andalouse", "fromagère" };
		private string[] _pain = new string[4] { "pain blanc", "pain gris", "pain complet", "baguette" };
		private string[] _crudités = new string[4] { "salade", "tomate", "cornichon", "ognion" };

        public string[] Proteine
        {
			get{ 
				return _proteine; 
			}
			set{
                _proteine = value; 
			}
		}
        public string[] Condiments
        {
            get{
                return _condiments;
            }
            set{
                _condiments = value;
            }
        }
        public string[] Pain
        {
            get{
                return _pain;
            }
            set{
                _pain = value;
            }
        }
        public string[] Crudités
        {
            get
            {
                return _crudités;
            }
            set
            {
                _crudités = value;
            }
        }

        public SandwichMaker(string[] proteine, string[] condiments, string[] pain, string[] crudités)
        {
            this._proteine = proteine;
            this._condiments = condiments;
            this._pain = pain;
            this._crudités = crudités;
        }

        public string SentenceSandwich(string _proteine, string _condiments, string _pain, string _crudités)
        {
            for(int s = 0; s < 4; s++){
                Random nbrAlea = new Random();
                int chooseIngr = nbrAlea.Next(4);
             
                if(s == 0)
                {
                    _proteine = Proteine[chooseIngr];
                }
                else if (s == 1)
                {
                    _condiments = Condiments[chooseIngr];
                }
                else if (s == 2)
                {
                    _pain = Pain[chooseIngr];
                }
                else if (s == 3)
                {
                    _crudités = Crudités[chooseIngr];
                }
            }
            
            string sentence = "voici votre sandwich : " + Pain + "," + Proteine + "," + Condiments + "," + Crudités; 
            return sentence;
        }
    }
}
