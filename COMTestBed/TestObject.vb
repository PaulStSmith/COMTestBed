Imports System.Runtime.InteropServices.Marshalling

<GeneratedComInterface>
Public Interface ITestObject
    Property XPTO As Integer
End Interface

<GeneratedComClass>
Public Class TestObject
    Implements ITestObject

    Public Property XPTO As Integer = 1024 Implements ITestObject.XPTO
End Class
