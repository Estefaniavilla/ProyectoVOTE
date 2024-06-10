using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Votante : Persona
    {
		private string electoralKey;
        private int section;
        private DateOnly emission;
        private DateOnly validity;

        public string ElectoralKey
        {
			get { return electoralKey; }
			set { electoralKey = value; }
		}

		public int Section
		{
			get { return section; }
			set { section = value; }
		}

		public DateOnly Emission
		{
			get { return  emission; }
			set {  emission = value; }
		}

		public DateOnly Validity
		{
			get { return validity; }
			set { validity = value; }
		}

		public Votante() 
		{
			ElectoralKey = "";
			Section = 0;
			Emission = DateOnly.FromDateTime(DateTime.Now);
			Validity = DateOnly.FromDateTime(DateTime.Now);
        }

		public Votante(string firstName, string lastName, string phone, string city, string state, string age, string gender, string electoralKey, int section, DateOnly emission, DateOnly validity)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            City = city;
            State = state;
            Age = age;
            Gender = gender;
            ElectoralKey = electoralKey;
            Section = section;
            Emission = emission;
            Validity = validity;
        }

		public string toString()
		{
			return FirstName + ", " + LastName + ", "+  Age + ", " + Gender + ", " + Phone + ", " + City + ", " + State + ", " + ElectoralKey + ", " + Section + ", " + Emission + ", " + Validity;
		}
    }
}
