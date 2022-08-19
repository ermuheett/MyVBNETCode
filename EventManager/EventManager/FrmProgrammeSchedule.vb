
Imports System.Data.SqlClient


Public Class FrmProgrammeSchedule
    Private Sub FrmProgrammeSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'When this form is loaded we need to create slots or slots will be already created..

        Dim cmdGetEventSlots As New SqlCommand("Select noofdays from EventMaster where EventID = '" & strActEventID & "'", EventCon)

        Dim rdrGetDays As SqlDataReader

        Dim intSlots As Integer = 0


        EventCon.Open()


        rdrGetDays = cmdGetEventSlots.ExecuteReader

        If rdrGetDays.Read Then


            intSlots = rdrGetDays("noofdays")


        End If



        EventCon.Close()







    End Sub
End Class