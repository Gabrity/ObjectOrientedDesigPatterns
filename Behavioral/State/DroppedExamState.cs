using System;

namespace State
{
    public class DroppedExamState : ExamState
    {
        public DroppedExamState() : base(0)
        {
        }

        public override void ExamCompleted(Exam exam, int grade)
        {
            Console.WriteLine($"Exam was dropped by the student. Dropped exam cannot get completed state.");
        }

        public override void ExamFailed(Exam exam)
        {
            Console.WriteLine($"Exam was dropped by the student. Dropped exam cannot get failed state.");
        }

        public override void ExamDropped(Exam exam)
        {
            Console.WriteLine($"Exam was already dropped by the student.");
        }
    }
}