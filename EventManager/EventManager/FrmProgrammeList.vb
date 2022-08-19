
Imports System.Data.SqlClient


Public Class FrmProgrammeList
    Private Sub FrmProgrammeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cmdGetEvents As New SqlCommand("Select * from EventMaster where Status = 'A'", EventCon)
        Dim rdrGetEvents As SqlDataReader


        EventCon.Open()


        rdrGetEvents = cmdGetEvents.ExecuteReader

        While rdrGetEvents.Read

            LstEvents.Items.Add(rdrGetEvents("EventID") & "    |   " & rdrGetEvents("EventName"))


        End While

        EventCon.Close()




    End Sub

    Private Sub butnOK_Click(sender As Object, e As EventArgs) Handles butnOK.Click

        Dim strEventDetails As String
        Dim strEventInfo As String()


        strEventDetails = LstEvents.SelectedItem.ToString


        strEventInfo = Split(strEventDetails, "  |   ", -1)

        strActEventID = strEventInfo(0)

        FrmProgrammeSchedule.Show()


    End Sub
End Class