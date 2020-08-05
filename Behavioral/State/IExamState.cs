namespace State
{
    public interface IExamState
    {
        void ExamCompleted(Exam exam, int grades);
        void ExamFailed(Exam exam);
        void ExamDropped(Exam exam);
    }
}