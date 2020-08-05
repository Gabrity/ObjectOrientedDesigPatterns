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
            exam1.ExamCompleted(3);
            exam1.ExamCompleted(3);
            exam1.ExamCompleted(2);
            exam1.ExamCompleted(4); // got a better grade at attempt 5

            var exam2 = new Exam("Stochastic Calculus", 3);
            exam2.ExamFailed();
            exam2.ExamFailed();
            exam2.ExamDropped(); // exam cannot be moved out of this state
            exam2.ExamFailed();
            exam2.ExamCompleted(5);

            var exam3 = new Exam("Discrete Mathematics", 2);
            exam3.ExamFailed();
            exam3.ExamFailed(); // ran out of attempts
            exam3.ExamCompleted(5);
            exam3.ExamFailed();
            exam3.ExamDropped();
        }
    }
}
