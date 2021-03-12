using System;
using System.Collections.Generic;
using System.Text;
using MasterDetailPageTraining.Messages;
using Prism.Events;

namespace MasterDetailPageTraining.Events
{
    public class AuthorQuoteNavigationEvent : PubSubEvent<AuthorQuoteNavigationMessage>
    {
    }
}
