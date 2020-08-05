using System;

namespace State
{
    public class FailedExamState : ExamState
    {
        public FailedExamState(int attemptsRemaining) : base(attemptsRemaining)
        {
        }
        
        public override void ExamCompleted(Exam exam, int grade)
        {
            if (AttemptsRemaining > 0)
            {
                exam.CurrentExamState = new CompletedExamState(grade, AttemptsRemaining - 1);
            }
            else
            {
                Console.WriteLine("Cannot complete exam, no attempts remaining.");
            }
        }

        public override void ExamFailed(Exam exam)
        {
            if (AttemptsRemaining > 0)
            {
                exam.CurrentExamState = new FailedExamState(AttemptsRemaining - 1);
            }
            else
            {
                Console.WriteLine("Exam already failed with too many attempts. It cannot be attempted again.");
            }
        }

        public override void ExamDropped(Exam exam)
        {
            exam.CurrentExamState = new DroppedExamState();
        }
    }
}