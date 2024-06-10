using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Persona
    {
		private string firstName;
		private string lastName;
		private string phone;
		private string city;
        private string state;

        public string FirstName
        {
			get { return firstName; }
			set { firstName = value; }
		}

		public string LastName
        {
			get { return lastName; }
			set { lastName = value; }
		}

		public string Phone
		{
			get { return phone; }
			set { phone = value; }
		}

		public string City
        {
			get { return city; }
			set { city = value; }
		}

		public string State
		{
			get { return state; }
			set { state = value; }
		}

		private string age;

		public string Age
		{
			get { return age; }
			set { age = value; }
		}
		private string gender;

		public string Gender
		{
			get { return gender; }
			set { gender = value; }
		}

		public Persona()
		{
			FirstName = "";
			LastName = "";
			Phone = "";
			City = "";
			State = "";
			Age = "";
			Gender = "";
		}

	}
}
