namespace State
{
    class Program
    {
        /*
         * Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.
         */

        static void Main(string[] args)
        {
            var exam1 = new Exam("Calculus", 5);

            exam1.ExamFailed();
            exam1.CompleteExam(3);
            exam1.CompleteExam(3);
            exam1.CompleteExam(2);
            exam1.CompleteExam(4);

            var exam2 = new Exam("Stochastic Calculus", 3);
            exam2.ExamFailed();
            exam2.ExamFailed();
            exam2.DropExam();

            var exam3 = new Exam("Discrete Mathematics", 2);
            exam3.ExamFailed();
            exam3.ExamFailed();
            exam3.CompleteExam(5);
            exam3.ExamFailed();
            exam3.DropExam();
        }
    }
}
