using System;

namespace TemplateMethod
{
    public class BudgetCarManufacturer : CarManufactureTemplate
    {
        protected override void GenerateChassis()
        {
            Console.WriteLine("Manufacturing steel chassis");
        }

        protected override void ApplyPaint()
        {
            Console.WriteLine("Applying white paint");
        }

        protected override void InstallDriveTrain()
        {
            Console.WriteLine("Installing small engine");
        }

        protected override void InstallInterior()
        {
            Console.WriteLine("Installing budget interior");
        }
    }
}