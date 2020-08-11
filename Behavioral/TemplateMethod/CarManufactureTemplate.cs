using System;

namespace TemplateMethod
{
    public abstract class CarManufactureTemplate
    {
        public void ManufactureCar()
        {
            GenerateChassis();
            ApplyPaint();
            InstallDriveTrain();
            InstallInterior();
            InstallExtras();
        }

        protected abstract void GenerateChassis();
        protected abstract void ApplyPaint();
        protected abstract void InstallDriveTrain();
        protected abstract void InstallInterior();

        protected virtual void InstallExtras()
        {
            Console.WriteLine("No extras by default");
        }
    }
}