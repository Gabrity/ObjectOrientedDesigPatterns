using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /*
     * Observer : Define a one-to-many dependency between objects so that when one object changes state,
     * all its dependents are notified and updated automatically.
     */
    class Program
    {
        static void Main(string[] args)
        {
            var pushMessageSupplier = new PushMessageSupplier();
            var observer1 = new EmailObserver("John");
            var observer2 = new EmailObserver("Steve");

            var disposable1 = pushMessageSupplier.Subscribe(observer1);
            var disposable2 = pushMessageSupplier.Subscribe(observer2);

            pushMessageSupplier.SendMessages(new Email("Jane", "Hi boys."));

            disposable1.Dispose();

            pushMessageSupplier.SendMessages(new Email("Jane", "I am Jane."));
        }
    }
}
