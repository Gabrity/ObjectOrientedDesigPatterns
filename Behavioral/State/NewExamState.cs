using System;

namespace State
{
    public class NewExamState : ExamState
    {
        public NewExamState(int attemptsRemaining) : base(attemptsRemaining)
        {
        }

        public override void ExamCompleted(Exam exam, int grade)
        {
            if (AttemptsRemaining > 0)
            {
                exam.CurrentExamState = new CompletedExamState(grade, AttemptsRemaining -1);
            }
            else
            {
                Console.WriteLine("Cannot complete exam, initial attempts were set to 0.");
            }
        }

        public override void ExamFailed(Exam exam)
        {
            exam.CurrentExamState = new FailedExamState(AttemptsRemaining - 1);
        }

        public override void ExamDropped(Exam exam)
        {
            exam.CurrentExamState = new DroppedExamState();
        }
    }
}