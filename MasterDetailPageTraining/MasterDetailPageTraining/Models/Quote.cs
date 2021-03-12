using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetailPageTraining.Models
{
	public class Quote
	{
		public string Text { get; set; }
		public Author AuthorValue { get; set; }
	}

	public static class QuotesFactory
	{
		public static List<Quote> GetQuotes()
		{
			var authors = AuthorFactory.GetAuthors();
			var quotes = new List<Quote>();

			foreach (var a in authors)
			{
				switch (a.Id)
				{
					case 1:
						{
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "An investment in knowledge pays the best interest."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "You may delay, but time will not.."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Early to bed and early to rise makes a man healthy, wealthy, and wise."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Tell me and I forget, teach me and I may remember, involve me and I learn."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Well done is better than well said."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "By failing to prepare, you are preparing to fail."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Either write something worth reading or do something worth writing."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Dost thou love life? Then do not squander time, for that is the stuff life is made of."
							});
						}
						break;
					case 2:
						{
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Treat the earth well: it was not given to you by your parents, it was loaned to you by your children. We do not inherit the Earth from our Ancestors, we borrow it from our Children."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "I salute the light within your eyes where the whole universe dwells. For when you are at that center within you and I am at that place within me, we shall be one."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "We preferred our own way of living.We were no expense to the government.All we wanted was peace and to be left alone."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "I see a time of Seven Generations when all the colors of mankind will gather under the Sacred Tree of Life and the whole earth will become One Circle again."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "One does not sell the earth upon which the people walk."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "My land is where my dead lie buried."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Hokahey! Today is a good day to die."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "My friend, why should you wish to shorten my life by taking from me my shadow? (To photographer Dr. Valentine T. McGillycuddy.)"
							});
						}
						break;
					case 3:
						{
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Let us put our minds together and see what life we can make for our children."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Behold, my friends, the spring is come; the earth has gladly received the embraces of the sun, and we shall soon see the results of their love!"
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "They claim this mother of ours, the Earth, for their own use, and fence their neighbors away from her, and deface her with their buildings and their refuse."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "What white man can say I never stole his land or a penny of his money ? Yet they say that I am a thief."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "My favorite things in life don’t cost any money. It’s really clear that the most precious resource we all have is time."
							});
						}
						break;
					case 4:
						{
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "My favorite things in life don’t cost any money. It’s really clear that the most precious resource we all have is time."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Being the richest man in the cemetery doesn't matter to me. Going to bed at night saying we've done something wonderful, that's what matters to me."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Innovation distinguishes between a leader and a follower."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Sometimes when you innovate, you make mistakes. It is best to admit them quickly, and get on with improving your other innovations."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Your work is going to fill a large part of your life, and the only way to be truly satisfied is to do what you believe is great work. And the only way to do great work is to love what you do. If you haven’t found it yet, keep looking. Don’t settle. As with all matters of the heart, you’ll know when you find it."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Have the courage to follow your heart and intuition. They somehow know what you truly want to become."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Quality is more important than quantity. One home run is much better than two doubles."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "The people who are crazy enough to think they can change the world are the ones who do."
							});
						}
						break;
					case 5:
						{
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "It's fine to celebrate success but it is more important to heed the lessons of failure."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Success is a lousy teacher. It seduces smart people into thinking they can't lose."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "The Internet is becoming the town square for the global village of tomorrow."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Discrimination has a lot of layers that make it tough for minorities to get a leg up."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Technology is just a tool. In terms of getting the kids working together and motivating them, the teacher is the most important."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "If you can't make it good, at least make it look good."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "What's amazing is, if young people understood how doing well in school makes the rest of their life so much interesting, they would be more motivated. It's so far away in time that they can't appreciate what it means for their whole life."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Your most unhappy customers are your greatest source of learning."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Treatment without prevention is simply unsustainable."
							});
						}
						break;
					case 6:
						{
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Darkness cannot drive out darkness; only light can do that. Hate cannot drive out hate; only love can do that."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "The ultimate measure of a man is not where he stands in moments of comfort and convenience, but where he stands at times of challenge and controversy."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Faith is taking the first step even when you don't see the whole staircase."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "We must accept finite disappointment, but never lose infinite hope."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "I refuse to accept the view that mankind is so tragically bound to the starless midnight of racism and war that the bright daybreak of peace and brotherhood can never become a reality... I believe that unarmed truth and unconditional love will have the final word."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "The ultimate measure of a man is not where he stands in moments of comfort and convenience, but where he stands at times of challenge and controversy."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Human progress is neither automatic nor inevitable... Every step toward the goal of justice requires sacrifice, suffering, and struggle; the tireless exertions and passionate concern of dedicated individuals."
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "A genuine leader is not a searcher for consensus but a molder of consensus."
							});
						}
						break;
					case 7:
						{
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "You must be the change you wish to see in the world.",
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "The weak can never forgive. Forgiveness is the attribute of the strong.",
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Happiness is when what you think, what you say, and what you do are in harmony.",
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "An eye for eye only ends up making the whole world blind.",
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Happiness is when what you think, what you say, and what you do are in harmony.",
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Live as if you were to die tomorrow; learn as if you were to live forever.",
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "First they ignore you, then they laugh at you, then they fight you, then you win.",
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "You must not lose faith in humanity. Humanity is an ocean; if a few drops of the ocean are dirty, the ocean does not become dirty.",
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Strength does not come from physical capacity. It comes from an indomitable will.",
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "A man is but the product of his thoughts; what he thinks, he becomes.",
							});
						}
						break;
					case 8:
						{
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "Our virtues and our failings are inseparable, like force and matter. When they separate, man is no more.",
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "The scientists of today think deeply instead of clearly. One must be sane to think clearly, but one can think deeply and be quite insane.",
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "The present is theirs; the future, for which I really worked, is mine.",
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "I do not think you can name many great inventions that have been made by married men.",
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "The spread of civilisation may be likened to a fire; first, a feeble spark, next a flickering flame, then a mighty blaze, ever increasing in speed and power.",
							});
							quotes.Add(new Quote
							{
								AuthorValue = a,
								Text = "The day science begins to study non-physical phenomena, it will make more progress in one decade than in all the previous centuries of its existence.\n",
							});
						}
						break;
				};
			}

			return quotes;
		}
	}
}
