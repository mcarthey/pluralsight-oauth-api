using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OAuth.Api.Demo.Models
{
    public class Lesson
    {
        public int LessonNumber { get; set; }
        public List<QASet> QASets { get; set; }

        public Lesson()
        {
            LessonNumber = 1;
            QASets = GetQaSets();
        }

        private List<QASet> GetQaSets()
        {
            return new List<QASet>
            {
                new QASet { Question = "What is your favorite color?", Answer = "Blue" },
                new QASet { Question = "What is the airspeed velocity of an unladen swallow?", Answer = "African or European" },
                new QASet { Question = "What is your quest?", Answer = "To seek the holy grail" }
            };
        }
    }

    public class QASet
    {
        public string Question { get; set; }
        public string Answer { get; set; }

    }
}