using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhoneLib;

namespace FactoryTest
{
    public interface ISmartPhoneFactory
    {
        IProcessor GetProcessor();
        ICamera GetCamera();
        IScreen GetScreen();
    }

    public class HighEndSmartPhone: ISmartPhoneFactory
    {
        public IProcessor GetProcessor() { return new HighEndProcessor();  }
        public ICamera GetCamera() { return new HighEndCamera(); }
        public IScreen GetScreen() { return new HighEndScreen(); }
    }

    public class LowEndSmartPhone : ISmartPhoneFactory
    {
        public virtual IProcessor GetProcessor() { return new LowEndProcessor(); }
        public ICamera GetCamera() { return new LowEndCamera(); }
        public IScreen GetScreen() { return new LowEndScreen(); }
    }

    public class AveragedSmartPhone : LowEndSmartPhone
    {
        public override IProcessor GetProcessor() { return new HighEndProcessor(); }
    }

    public class SmartPhoneShop
    {
        private ISmartPhoneFactory[] _smFactory = new ISmartPhoneFactory[3];

        public ISmartPhoneFactory this[int i]
        {
            get
            {
                return _smFactory[i];
            }
            set
            {
                _smFactory[i] = value;
            }

        }

        public SmartPhoneShop(ISmartPhoneFactory smFactory, int i)
        {
            _smFactory[i] = smFactory;
        }

        public void CreateSmartPhone(int i)
        {
            IProcessor processor = _smFactory[i].GetProcessor();
            ICamera camera = _smFactory[i].GetCamera();
            IScreen screen = _smFactory[i].GetScreen();

            processor.GetNumberOfCores();
            processor.GetProcessorVersion();

            if (processor.GetType() == typeof(HighEndProcessor))
            {
                HighEndProcessor he_processor = (HighEndProcessor)processor;

                he_processor.GetSpecialCharacteristics();
            }
            //
            camera.GetLensesSize();
            camera.GetPixelResolution();
            //
            screen.GetDisplayResolution();
            screen.GetDisplayType();
        }
    }
}
