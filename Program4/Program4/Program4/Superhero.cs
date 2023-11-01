using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Superhero
    {
        public string _SuperHeroName; //ssuperhoro name
        public string _BirthCity; //superhereo birth place
        public string _firstsuperpower; //superhero first power
        public int _birthYear; //superhero birth year
        public string _secondsuperpower; //superhero second power
        public bool _onEarthPlanet; // if superhero is on earth or not
        readonly char _Initial; //this is to get the first character of the superhero

        //precondition: birth year is > 0
        //postcondition: superhero is constructed with specific name, city, first super power, birth year, second super power, first letter of name
        //and if they are on planet or not
        public Superhero(String name, String city, String first, int year, string second, char I, bool onplanet)
        {

            SuperHeroName = name;
            BirthCity = city;
            FirstSuperpower = first;
            BirthYear = year;
            _secondsuperpower = second;
            _Initial = name[0];
            _onEarthPlanet = onplanet;
        }

        public string SuperHeroName
        { //precondition: none
          //postcondition : the name is returned as a string
            get { return _SuperHeroName;
                // _Initial = SuperHeroName[0];
            }

            //precondition : none
            //postcondition: set the name to the value
            set { _SuperHeroName = value; }

        }
        public string BirthCity
        {
            //precondition : none
            //postcondition : set the city as the string 
            get { return _BirthCity; }

            //precondition : none
            //postcondition : the birth city is set to the value
            set { _BirthCity = value; }

        }
        public string FirstSuperpower
        {
            //precondition : none
            //postcondition : set the first power as a string 
            get { return _firstsuperpower; }

            //precondtion : none
            //postcondition : set the first power to the value
            set { _firstsuperpower = value; }
        }

        public int BirthYear
        {
            //precondtion: none
            //postcondition: set the birth year as the returned value
            get
            {
                return _birthYear;
            }

            //precondtion: checks to see if the birthyear is greater than zero
            //postcondition: if its greater then its the value, if not then it defaults to 1999
            set
            {
                if (value > 0)
                {
                    _birthYear = value; //validation
                }
                else
                { _birthYear = 1999; } //default value
            }
        }
        public string Secondsuperpower
        {
            //precondotion: none
            //postcondtion: set the second power as the string
            get
            {
                return _secondsuperpower;
            }

            //precondtion: none
            //postcondition: set the second power to the value
            set
            {
                _secondsuperpower = value;
            }
        }
          public char Initial
           {
            //precondition: none
            //Postcondition: set the letter to as the character
               get
               {
                return _Initial;
               }

           }
           public void OnPlanetEarth()
           {//precondition: none
            //postcondition: set the bool to true
              _onEarthPlanet = true;
           }
           public void OffPlanetEarth()
        {//precondition: none
         //postcondition: set the bool to false
            _onEarthPlanet = false;
           }
        //precondition: none
        //postcondition: this sets the method to return the bool (true or false)
        public bool IsOnPlanetEarth()
        {//precondition: none
         //postcondition: set the bool vaule as the return value for the method
            return _onEarthPlanet;
        }

        public override string ToString()
        {
            //precondition: birth year >0
            //postcondition: converts the alll of the answers to string to be able to get displayed
            return $"Name: { SuperHeroName}{Environment.NewLine}"+
            $"City: { BirthCity}{Environment.NewLine}"+
            $"First Super Power: { FirstSuperpower}{Environment.NewLine}"+
            $"Born In: { BirthYear}{Environment.NewLine}"+
            $"Second Super Power: { Secondsuperpower}{Environment.NewLine}"+
            $"Planet Earth: { IsOnPlanetEarth()}{Environment.NewLine}"+
            $"Initial: { Initial}{Environment.NewLine}";
        }
    }
}
