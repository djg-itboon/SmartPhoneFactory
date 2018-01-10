using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneLib
{
    public interface IProcessor
    {
        void GetNumberOfCores();
        void GetProcessorVersion();
    }

    public interface ICamera
    {
        void GetLensesSize();
        void GetPixelResolution();
    }

    public interface IScreen
    {
        void GetDisplayType();
        void GetDisplayResolution();
    }
    public class Processor : IProcessor
    {
        private int  _numberofCores;
        private string _processorVersion;

        //
       
        public int NumberOfCores { get { return _numberofCores; } set { _numberofCores = value; } }
        public string ProcessorVersion { get { return _processorVersion; } set { _processorVersion = value; } }
        public void GetNumberOfCores()
        {
            //return this._numberofCores;
            Console.WriteLine("NumberOfCores: {0}", this.NumberOfCores);
        }
        public virtual void  GetProcessorVersion()
        {
            //return _processorVersion;
            Console.WriteLine("Low/Mid Processor: {0}", this.ProcessorVersion);
        }

    }

    public class Camera : ICamera
    {
        private decimal _lensesSize;
        private int _pixelResolution;

        //

        public decimal LensesSize { get { return _lensesSize; } set { _lensesSize = value; } }
        public int PixelResolution { get { return _pixelResolution; } set { _pixelResolution = value; } }
        public void GetLensesSize()
        {
            //return this._numberofCores;
            Console.WriteLine("Lenses Size: {0}", this.LensesSize);
        }
        public virtual void GetPixelResolution()
        {
            //return _processorVersion;
            Console.WriteLine("Pixel Resolution: {0}ppp", this.PixelResolution );
        }

    }

    public class Screen : IScreen
    {
        private string _displayType;
        private int _displayResolution;

        //

        public string DisplayType { get { return _displayType; } set { _displayType = value; } }
        public int DisplayResolution { get { return _displayResolution; } set { _displayResolution = value; } }
        public void GetDisplayType()
        {
            //return this._numberofCores;
            Console.WriteLine("DisplayType: {0}", this.DisplayType);
        }
        public virtual void GetDisplayResolution()
        {
            //return _processorVersion;
            Console.WriteLine("DisplayResolution: {0}p", this.DisplayResolution);
        }

    }

    public class HighEndProcessor : Processor
    {
        private string _specialCharacteristics;
        public string SpecialCharacteristics { get { return _specialCharacteristics; } set { _specialCharacteristics = value; } }
        public HighEndProcessor()
        {
            this.NumberOfCores = 8;
            this.ProcessorVersion = "Exynos 5";
            SpecialCharacteristics = "This is the new flagship smartphone";
        }

        public override void GetProcessorVersion()
        {
            //return _processorVersion;
            Console.WriteLine("High end processor: {0}", this.ProcessorVersion);
        }

        public void GetSpecialCharacteristics()
        {
            //return _processorVersion;
            Console.WriteLine("Special Characteristics: {0}", this.SpecialCharacteristics);
        }
    }

    public class LowEndProcessor : Processor
    {
        public LowEndProcessor()
        {
            this.NumberOfCores = 2;
            this.ProcessorVersion = "MediaTeck";
        }
    }

    public class HighEndCamera : Camera
    {
        private string _specialCharacteristics;
        public string SpecialCharacteristics { get { return _specialCharacteristics; } set { _specialCharacteristics = value; } }
        public HighEndCamera()
        {
            LensesSize = 2.5m;
            PixelResolution = 448;
        }
    }

    public class LowEndCamera : Camera
    {
        private string _specialCharacteristics;
        public string SpecialCharacteristics { get { return _specialCharacteristics; } set { _specialCharacteristics = value; } }
        public LowEndCamera()
        {
            LensesSize = 1.0m;
            PixelResolution = 224;
        }
    }

    public class HighEndScreen : Screen
    {
        private string _specialCharacteristics;
        public string SpecialCharacteristics { get { return _specialCharacteristics; } set { _specialCharacteristics = value; } }
        public HighEndScreen()
        {
            DisplayType = "AMOLED";
            DisplayResolution = 1080;
        }
    }
    public class LowEndScreen : Screen
    {
        public LowEndScreen()
        {
            DisplayType = "LED";
            DisplayResolution = 480;
        }
    }

}
