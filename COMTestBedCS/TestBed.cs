using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace COMTestBedCS
{
    // [GeneratedComInterface]
    [Guid("26a0aa6d-5aba-458f-92b4-b9a30ae0c65c")]
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ITestBed
    {
        int GetXPTO();
        void SetXPTO(int value);
    }

    //[GeneratedComClass]
    [Guid("3e178f98-522e-4e95-8a9c-6d80dc48b7d5")]
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    internal class TestBed : ITestBed
    {
        private int _XPTO = 1024;

        public int GetXPTO() => _XPTO;
        public void SetXPTO(int value)=>_XPTO = value;
    }
}
