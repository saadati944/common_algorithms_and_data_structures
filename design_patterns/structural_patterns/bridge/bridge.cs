using System;
using System.Threading.Tasks;

namespace designPatterns
{
    interface IDevice
    {
        public bool IsEnabled();
        public void Enable();
        public void Disable();
        public int GetVolume();
        public void SetVolume(int volume);
        public string GetName();
    }

    interface IRemote
    {
        public void TogglePower();
        public string GetName();
    }

    class Tv : IDevice
    {
        private bool _isEnabled;
        private int _volume;

        public Tv(bool isEnabled = false, int volume = 50)
        {
            _isEnabled = isEnabled;
            _volume = volume;
        }
        
        public bool IsEnabled()
        {
            return _isEnabled;
        }

        public void Enable()
        {
            _isEnabled = true;
        }

        public void Disable()
        {
            _isEnabled = false;
        }

        public int GetVolume()
        {
            return _volume;
        }

        public void SetVolume(int v)
        {
            _volume = v;
        }

        public string GetName()
        {
            return "TV";
        }
    }

    class MinimalRemote : IRemote
    {
        private IDevice _device;
        public MinimalRemote(IDevice device)
        {
            _device = device;
        }
        
        public void TogglePower()
        {
            if(_device.IsEnabled())
                _device.Disable();
            else
                _device.Enable();
            Console.WriteLine($"toggling power of {{{_device.GetName()}}} with {{{GetName()}}}. current state: {(_device.IsEnabled() ? "enabled" : "disabled")}");
        }

        public string GetName()
        {
            return "MINIMAL_REMOTE";
        }
    }
    
    class AdvancedRemote : IRemote
    {
        private IDevice _device;
        private int _lastVolume;
        
        public AdvancedRemote(IDevice device)
        {
            _device = device;
            _lastVolume = device.GetVolume();
        }
        
        public void TogglePower()
        {
            if(_device.IsEnabled())
                _device.Disable();
            else
                _device.Enable();
            Console.WriteLine($"toggling power of {{{_device.GetName()}}} with {{{GetName()}}}. current state: {(_device.IsEnabled() ? "enabled" : "disabled")}");
        }

        public void Mute()
        {
            if (_device.GetVolume() == 0)
            {
                _device.SetVolume(_lastVolume);
            }
            else
            {
                _lastVolume = _device.GetVolume();
                _device.SetVolume(0);
            }
            Console.WriteLine($"muting {{{_device.GetName()}}} with {{{GetName()}}}. current volume: {_device.GetVolume()}");
        }

        public string GetName()
        {
            return "ADVANCED_REMOTE";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IDevice device = new Tv(true, 50);
            IRemote simpleRemote = new MinimalRemote(device);
            AdvancedRemote advancedRemote = new AdvancedRemote(device);
            
            simpleRemote.TogglePower();
            simpleRemote.TogglePower();
            
            Console.WriteLine();
            
            advancedRemote.TogglePower();
            advancedRemote.TogglePower();
            
            Console.WriteLine();
            
            advancedRemote.Mute();
            advancedRemote.Mute();
        }
    }
}