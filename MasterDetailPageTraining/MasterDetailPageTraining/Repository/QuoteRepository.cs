using MasterDetailPageTraining.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterDetailPageTraining.Repository
{
	public class QuoteRepository
	{
		private List<Quote> _unsortedQuotes;

		public QuoteRepository()
		{
			_unsortedQuotes = QuotesFactory.GetQuotes();
		}

		public Author GetAuthorById(int authorId)
		{
			return AuthorFactory.GetAuthors().SingleOrDefault(x => x.Id == authorId);
		}

		public List<Quote> GetQuotesByAuthor(int authorId)
		{
			return _unsortedQuotes.Where(x => x.AuthorValue.Id == authorId).ToList();
		}

		public List<Quote> GetRandomQuotes()
		{
			var quotes = new List<Quote>();

			Random r = new Random();
			var authors = AuthorFactory.GetAuthors();
			foreach (var a in authors)
			{
				var quotesCount = (from x in _unsortedQuotes
								   where x.AuthorValue.Id == a.Id
								   select x.Text).Distinct().Count();

				var randomIndex = r.Next(0, (quotesCount - 1));

				var quote = _unsortedQuotes.Where(x => x.AuthorValue.Id == a.Id)
										   .ElementAt(randomIndex);
				if (quote != null)
				{
					quotes.Add(quote);
				}
			}

			return quotes;
		}
	}
}
