namespace State
{
    public class Exam
    {
        public string ExamName { get; set; }

        public IExamState CurrentExamState { get; set; }

        public Exam(string examName, int attempts)
        {
            ExamName = examName;
            CurrentExamState = new NewExamState(attempts);
        }

        public void ExamDropped()
        {
            CurrentExamState.ExamDropped(this);
        }

        public void ExamCompleted(int grade)
        {
            CurrentExamState.ExamCompleted(this, grade);
        }

        public void ExamFailed()
        {
            CurrentExamState.ExamFailed(this);
        }
    }
}
