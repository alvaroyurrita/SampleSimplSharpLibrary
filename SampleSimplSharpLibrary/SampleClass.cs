using Crestron.SimplSharp;
using SampleSimplSharpLibrarySecondNamespace;
using System;

namespace SampleSimplSharpLibrary
{
    public class SampleClass
    {
        public event EventHandler SampleEvent;
        public event EventHandler<MyEventArgs> SampleComplexEvent;

        public delegate void SampleDelegate();
        public delegate int IntSampleDelegate(int intParameter);
        public delegate SimplSharpString SimplSharpStringSampleDelegate(SimplSharpString simplSharpStringParameter);
        public delegate uint uintSampleDelegate(uint sampleUintParameter);
        public delegate ushort ushortSampleDelegate(ushort ushortParameter);
        public delegate short shortSampleDelegate(short shortParameter);

        public SampleDelegate SampleDelegateProperty { get; set; }
        public IntSampleDelegate IntSampleDelegateProperty { get; set; }
        public SimplSharpStringSampleDelegate SimplSharpStringSampleDelegateProperty { get; set; }
        public uintSampleDelegate uintSampleDelegateProperty { get; set; }
        public ushortSampleDelegate ushortSampleDelegateProperty { get; set; }
        public shortSampleDelegate shortSampleDelegateProperty { get; set; }

        public int intSampleField = 0;
        public string stringSampleField = "";
        public SimplSharpString simplSharpStringSampleField = "";
        public uint uintSampleField = 0;
        public ushort ushortSampleField = 0;
        public short shortSampleField = 0;
        public SampleStructure sampleStructureSampleField = new SampleStructure();
        public SampleSubClass sampleSubClassSampleField = new SampleSubClass();


        public string SampleString { get; set; } = "";
        public SimplSharpString SampleSimplSharpString { get; set; } = "";
        public int SampleInt { get; set; } = 0;
        public uint SampleUint { get; set; } = 0;
        public short SampleShort { get; set; } = 0;
        public ushort SampleUshort { get; set; } = 0;
        public SampleStructure SampleSampleStructure { get; set; } = new SampleStructure();
        public SampleSubClass SampleSampleSubClass { get; set; } = new SampleSubClass();

        public ClassInDifferentNamespace ClassInDifferentNamespace = new ClassInDifferentNamespace();

        public SampleClass() { CrestronConsole.PrintLine("Sample Class Constructor"); }

        public void SampleVoidMethod()
        {
            const string result = "Sample Void Method";
            CrestronConsole.PrintLine(result);
        }

        public string SampleStringMethod(string stringParameter)
        {
            const string result = "Sample String Method";
            CrestronConsole.PrintLine(result);
            return result;
        }

        public SimplSharpString SampleSimplSharpStringMethod(SimplSharpString simplSharpStringParameter)
        {
            const string result = "Sample SimplSharpString Method";
            CrestronConsole.PrintLine(result);
            return result;
        }

        public int SampleIntMethod(int intParameter)
        {
            const int result = 99;
            CrestronConsole.PrintLine(result.ToString());
            return result;
        }

        public uint SampleUintMethod(uint uintParameter)
        {
            const uint result = 99;
            CrestronConsole.PrintLine(result.ToString());
            return result;
        }

        public short SampleShortMethod(short ushortParameter)
        {
            const short result = 99;
            CrestronConsole.PrintLine(result.ToString());
            return result;
        }

        public ushort SampleUshortMethod(ushort ushortParameter)
        {
            const ushort result = 99;
            CrestronConsole.PrintLine(result.ToString());
            return result;
        }

        public SampleStructure SampleStructureMethod()
        {
            var result = new SampleStructure
            {
                SampleStructureString = "Sample Structure String",
                SampleStructureSimplSharpString = "Sample Structure SimplSharpString",
                SampleStructureInt = 99,
                SampleStructureUint = 99,
                SampleStructureShort = 99,
                SampleStructureUshort = 99
            };
            CrestronConsole.PrintLine(result.SampleStructureString);
            CrestronConsole.PrintLine(result.SampleStructureSimplSharpString.ToString());
            CrestronConsole.PrintLine(result.SampleStructureInt.ToString());
            CrestronConsole.PrintLine(result.SampleStructureUint.ToString());
            CrestronConsole.PrintLine(result.SampleStructureShort.ToString());
            CrestronConsole.PrintLine(result.SampleStructureUshort.ToString());
            return result;
        }
        
        public void FireSampleEvent()
        {
            SampleEvent?.Invoke(this, EventArgs.Empty);
        }
        
        public void FireSampleComplexEvent()
        {
            SampleComplexEvent?.Invoke(this, new MyEventArgs
            {
                EventUshort = 99,
                EventInt = 99,
                EventShort = 99,
                EventString = "Event String",
                EventUint = 99,
                EventSimplSharpString = "Event SimplSharpString"
            });
        }
    }

    public struct SampleStructure
    {
        public string SampleStructureString;
        public SimplSharpString SampleStructureSimplSharpString;
        public int SampleStructureInt;
        public uint SampleStructureUint;
        public short SampleStructureShort;
        public ushort SampleStructureUshort;
    }

    public class SampleSubClass
    {
        public SampleSubClass() { }
        public string SampleStructureString = "";
        public SimplSharpString SampleStructureSimplSharpString = "";
        public int SampleStructureInt;
        public uint SampleStructureUint;
        public short SampleStructureShort;
        public ushort SampleStructureUshort;
    }

    public class MyEventArgs : EventArgs
    {
        public string EventString { get; set; } = "";
        public SimplSharpString EventSimplSharpString { get; set; } = "";
        public int EventInt { get; set; } 
        public uint EventUint { get; set; } 
        public short EventShort { get; set; } 
        public ushort EventUshort { get; set; } 
    }
}