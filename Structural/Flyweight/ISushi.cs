using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    /// <summary>
    /// The 'Flyweight' interface
    /// </summary>
    public interface ISushi
    {
        string Name { get; }
        string Ingredients { get; }
        decimal Price { get; }

        void Display(int orderTotal);
    }
}
