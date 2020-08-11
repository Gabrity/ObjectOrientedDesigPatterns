using System;

namespace TemplateMethod
{
    public class ExpensiveCarManufacturer : CarManufactureTemplate
    {
        protected override void GenerateChassis()
        {
            Console.WriteLine("Manufacturing carbon fiber chassis");
        }

        protected override void ApplyPaint()
        {
            Console.WriteLine("Applying black paint");
        }

        protected override void InstallDriveTrain()
        {
            Console.WriteLine("Installing twin turbo V6 engine");
        }

        protected override void InstallInterior()
        {
            Console.WriteLine("Installing leather interior");
        }

        protected override void InstallExtras()
        {
            Console.WriteLine("Enable self-driving feature");
        }
    }
}