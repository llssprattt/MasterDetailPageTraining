using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetailPageTraining.Models
{
	public class Author
	{
		public int Id { get; set; }

		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string SuffixName { get; set; }

		public string FullName { get { return $"{FirstName} {MiddleName} {LastName} {SuffixName}"; } }

		public DateTime DateOfBirth { get; set; }
		public DateTime? DateOfDeath { get; set; }

		public string DisplayDateOfBirth { get { return DateOfBirth.ToString("d"); } }
		public string DisplayDateOfDeath { get { return (DateOfDeath == null) ? string.Empty : ((DateTime)DateOfDeath).ToString("d"); } }

		public string BirthCity { get; set; }
		public string BirthProvience { get; set; }
		public string BirthCountry { get; set; }

		public string PictureUrl { get; set; }
		public string PictureHeading { get; set; }
	}

	public static class AuthorFactory
	{
		public static List<Author> GetAuthors()
		{
			var authors = new List<Author>
			{
				new Author
				{
					Id = 1,
					FirstName = "Benjamin",
					LastName = "Franklin",
					DateOfBirth = new DateTime(1706, 1, 17),
					DateOfDeath = new DateTime(1790, 1, 17),
					BirthCity = "Boston",
					BirthProvience = "Massachusetts Bay",
					BirthCountry = "British America",
					PictureUrl = "https://upload.wikimedia.org/wikipedia/commons/c/cc/BenFranklinDuplessis.jpg",
					PictureHeading = "Banjamin Franklin - North American printer, publisher, writer, scientist, inventor and statesman 79 years old.",
				},
				new Author
				{
					Id = 2,
					FirstName = "Crazy",
					LastName = "Horse",
					DateOfBirth = new DateTime(1842, 1, 1),
					DateOfDeath = new DateTime(1877, 9, 5),
					BirthCity = "Cha-O-Ha",
					BirthProvience = "",
					BirthCountry = "",
					PictureUrl = "https://upload.wikimedia.org/wikipedia/en/c/c0/Crazy_Horse_sketch.jpg",
					PictureHeading = "A 1934 sketch of Crazy Horse made by a Mormon missionary after interviewing Crazy Horse's sister, who claimed the depiction was accurate.",
				},
				new Author
				{
					Id = 3,
					FirstName = "Sitting",
					LastName = "Bull",
					DateOfBirth = new DateTime(1831, 1, 1),
					DateOfDeath = new DateTime(1890, 12, 15),
					BirthCity = "Húŋkešni",
					BirthProvience = "",
					BirthCountry = "",
					PictureUrl = "https://upload.wikimedia.org/wikipedia/commons/5/57/En-chief-sitting-bull.jpg",
					PictureHeading = "Portrait of indian chief Sitting Bull",
				},
				new Author
				{
					Id = 4,
					FirstName = "Steve",
					LastName = "Jobs",
					DateOfBirth = new DateTime(1955, 2, 24),
					DateOfDeath = new DateTime(2011, 10, 5),
					BirthCity = "San Francisco",
					BirthProvience = "California",
					BirthCountry = "United States of America",
					PictureUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b9/Steve_Jobs_Headshot_2010-CROP.jpg",
					PictureHeading = "Steve Jobs shows off the iPhone 4 at the 2010 Worldwide Developers Conference",

				},
				new Author
				{
					Id = 5,
					FirstName = "Bill",
					LastName = "Gates",
					DateOfBirth = new DateTime(1955, 10, 28),
					DateOfDeath =  null,
					BirthCity = "Medina",
					BirthProvience = "Washington",
					BirthCountry = "United States of America",
					PictureUrl = "https://upload.wikimedia.org/wikipedia/commons/1/19/Bill_Gates_June_2015.jpg",
					PictureHeading = "Head and shoulders photo of Bill Gates",
				},
				new Author
				{
					Id = 6,
					FirstName = "Martin",
					MiddleName = "Luther",
					LastName = "King",
					SuffixName = "Jr.",
					DateOfBirth = new DateTime(1929, 1, 15),
					DateOfDeath = new DateTime(1968, 4, 4),
					BirthCity = "Atlanta",
					BirthProvience = "Georgia",
					BirthCountry = "United States of America",
					PictureUrl = "https://upload.wikimedia.org/wikipedia/commons/0/05/Martin_Luther_King%2C_Jr..jpg",
					PictureHeading = "Martin Luther King",
				},
				new Author
				{
					Id = 7,
					FirstName = "Mohandas",
					LastName = "Gandhi",
					DateOfBirth = new DateTime(1869, 10, 2),
					DateOfDeath = new DateTime(1948, 1, 30),
					BirthCity = "New Delhi",
					BirthProvience = "Dehli",
					BirthCountry = "India",
					PictureUrl = "https://upload.wikimedia.org/wikipedia/commons/d/d1/Portrait_Gandhi.jpg",
					PictureHeading = "The face of Gandhi in old age—smiling, wearing glasses, and with a white sash over his right shoulder",
				},
				new Author
				{
					Id = 8,
					FirstName = "Nikola",
					LastName = "Telsa",
					DateOfBirth = new DateTime(1856, 7, 10),
					DateOfDeath = new DateTime(1943, 1, 7),
					BirthCity = "Smiljan",
					BirthProvience = "",
					BirthCountry = "Austrian Empire",
					PictureUrl = "https://upload.wikimedia.org/wikipedia/commons/d/d4/N.Tesla.JPG",
					PictureHeading = "Photograph of Nikola Tesla, a slender, moustachioed man with a thin face and pointed chin.",
				},

			};

			return authors;
		}
	}
}
