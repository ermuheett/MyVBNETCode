
Imports System.Data.SqlClient


Public Class FrmEventMaster
    Private Sub FrmEventMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cmdTempTab As New SqlCommand("Select EVID from TempTab", EventCon)

        Dim rdrTempTab As SqlDataReader


        EventCon.Open()


        rdrTempTab = cmdTempTab.ExecuteReader

        If rdrTempTab.Read Then

            lblEventID.Text = rdrTempTab("EVID").ToString


        End If


        EventCon.Close()


    End Sub

    Private Sub butnOK_Click(sender As Object, e As EventArgs) Handles butnOK.Click

        If TxtEventName.Text = "" Or TxtStartDate.Text = "" Or TxtContactPerson.Text = "" Or TxtEventName.Text = "" Or TxtMobileNo.Text = "" Then

            MsgBox("Enter Complete Fields", vbCritical + vbOKOnly)
        Else

            Dim cmdEventAdd As New SqlCommand("insert into EventMaster Values (" & lblEventID.Text & ",'" & TxtEventName.Text & "','" & TxtEventAddress.Text & "','" & TxtStartDate.Text & "','" & TxtEndDate.Text & "','" & CboDays.SelectedItem.ToString & "','" & TxtContactPerson.Text & "','" & TxtMobileNo.Text & "','" & TxtEmailID.Text & "','A')", EventCon)
            EventCon.Open()

            cmdEventAdd.ExecuteNonQuery()


            EventCon.Close()


            MsgBox("The Event has been Successfully Saved...!!!!", vbInformation + vbOKOnly, "Saved Successfully..!!!!")


            TxtContactPerson.Text = ""
            TxtEmailID.Text = ""
            TxtStartDate.Text = ""
            TxtEndDate.Text = ""
            TxtEventName.Text = ""
            TxtEventAddress.Text = ""
            TxtMobileNo.Text = ""
            TxtEventName.Focus()



            ' Update Event ID 

            Dim cmdTempTab As New SqlCommand("update TempTab set EVID = EVID + 1", EventCon)

            EventCon.Open()

            cmdTempTab.ExecuteNonQuery()

            EventCon.Close()


            'Get new Event ID

            cmdTempTab = New SqlCommand("Select EVID from TempTab", EventCon)

            Dim rdrTempTab As SqlDataReader


            EventCon.Open()


            rdrTempTab = cmdTempTab.ExecuteReader

            If rdrTempTab.Read Then

                lblEventID.Text = rdrTempTab("EVID").ToString


            End If


            EventCon.Close()



        End If



    End Sub
End Class