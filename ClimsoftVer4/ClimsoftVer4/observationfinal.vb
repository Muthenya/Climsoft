'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class observationfinal
    Public Property recordedFrom As String
    Public Property describedBy As Nullable(Of Long)
    Public Property obsDatetime As Nullable(Of Date)
    Public Property obsLevel As String
    Public Property obsValue As Nullable(Of Decimal)
    Public Property flag As String
    Public Property period As Nullable(Of Integer)
    Public Property qcStatus As Nullable(Of Integer)
    Public Property qcTypeLog As String
    Public Property acquisitionType As Nullable(Of Integer)
    Public Property dataForm As String
    Public Property capturedBy As String
    Public Property mark As Nullable(Of SByte)
    Public Property temperatureUnits As String
    Public Property precipitationUnits As String
    Public Property cloudHeightUnits As String
    Public Property visUnits As String
    Public Property dataSourceTimeZone As Nullable(Of Integer)

    Public Overridable Property obselement As obselement
    Public Overridable Property station As station

End Class