// Copyright Collin Westenhaver 2017
// GradeBook +++

namespace Gradebook
{
  public class Question
  {
    public int Total { get; set; }
    public string Text { get; set; }
  }

  public class Score
  {
    public Question Question { get; set; }
    public int Earned { get; set; }
    public string Details { get; set; }
  }
}
