using System;

namespace State
{
    public class CompletedExamState : ExamState
    {
        public int Grade { get; }

        public CompletedExamState(int grade, int attemptsRemaining) : base(attemptsRemaining)
        {
            Grade = grade;
        }
        
        public override void ExamCompleted(Exam exam, int grade)
        {
            if (AttemptsRemaining > 0)
            {
                if (grade > Grade)
                {
                    exam.CurrentExamState = new CompletedExamState(grade, AttemptsRemaining - 1);
                }
                else
                {
                    Console.WriteLine($"Exam is already completed with grade: {Grade}. New grade is not larger then the previous one.");
                    exam.CurrentExamState = new CompletedExamState(Grade, AttemptsRemaining - 1);
                }
            }
            else
            {
                Console.WriteLine("Exam cannot be attempted again, no more attempts left.");
            }
        }

        public override void ExamFailed(Exam exam)
        {
            exam.CurrentExamState = new FailedExamState(AttemptsRemaining -1);
        }

        public override void ExamDropped(Exam exam)
        {
            Console.WriteLine($"Exam was completed with grade: {Grade}. Completed exam cannot get dropped state.");
        }
    }
}