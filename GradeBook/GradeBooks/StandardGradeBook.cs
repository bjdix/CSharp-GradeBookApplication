using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        StandardGradeBook(string name) : base(name)
        {
            Name = name;
            Type = Enums.GradeBookType.Standard;
        }
    }
}
