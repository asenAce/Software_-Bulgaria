using ConsoleForum.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleForum.Utility
{
    public static class OutputUtility
    {
        public const int DeafultDelimiterLength = 20;

        public static string ShowSortedQuestions(IEnumerable<IQuestion> questions)
        {
            var sortedQuestions = questions
                  .OrderBy(q => q.Id);
            return string.Join(Environment.NewLine, questions);
        }
    }
}
