﻿Public Class ucrMetadataStationElement

    Private Sub ucrMetadataStationElement_Load(sender As Object, e As EventArgs) Handles Me.Load
            If bFirstLoad Then
                'SetUpTableEntry 
                SetUpTableEntry("StationElement")

            AddLinkedControlFilters(ucrDataLinkInstrumentID, ucrDataLinkInstrumentID.FieldName(), "=", strLinkedFieldName:=ucrDataLinkInstrumentID.GetField(), bForceValuesAsString:=True)

            'set up the navigation control
            UcrNavigation.SetTableEntry(Me)
            UcrNavigation.AddKeyControls(ucrDataLinkInstrumentID)

            bFirstLoad = False

            'populate the values
            UcrNavigation.PopulateControl()

        End If
        End Sub
End Class