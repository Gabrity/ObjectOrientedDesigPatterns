namespace State
{
    public abstract class ExamState : IExamState
    {
        public int AttemptsRemaining { get; }

        protected ExamState(int attemptsRemaining)
        {
            AttemptsRemaining = attemptsRemaining;
        }
        
        public abstract void ExamCompleted(Exam exam, int grade);
        public abstract void ExamFailed(Exam exam);
        public abstract void ExamDropped(Exam exam);
    }
}