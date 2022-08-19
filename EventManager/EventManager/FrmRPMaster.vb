Imports System.Data.SqlClient



Public Class FrmRPMaster
    Private Sub ButnCancel_Click(sender As Object, e As EventArgs) Handles ButnCancel.Click

        Me.Hide()


    End Sub

    Private Sub FrmRPMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cmdTempTab As New SqlCommand("Select RPID from TempTab", EventCon)

        Dim rdrTempTab As SqlDataReader


        EventCon.Open()


        rdrTempTab = cmdTempTab.ExecuteReader

        If rdrTempTab.Read Then

            LblRPID.Text = rdrTempTab("RPID").ToString


        End If


        EventCon.Close()









    End Sub

    Private Sub butnOK_Click(sender As Object, e As EventArgs) Handles butnOK.Click


        If TxtAddress.Text = "" Or TxtEmail.Text = "" Or TxtMobile.Text = "" Or TxtRPDesig.Text = "" Or TxtRPName.Text = "" Or TxtRPSpecialization.Text = "" Then

            MsgBox("Enter all the Text...!!!", vbCritical + vbOKOnly, "Enter Valid and Complete Text")

        Else

            Dim cmdRP As New SqlCommand("Insert into RP_Master Values (" & LblRPID.Text & ",'" & TxtRPName.Text & "','" & TxtRPDesig.Text & "','" & TxtMobile.Text & "','" & TxtEmail.Text & "','" & TxtRPSpecialization.Text & "','A')", EventCon)

            EventCon.Open()

            cmdRP.ExecuteNonQuery()

            EventCon.Close()

            MsgBox("The Resource Person has been Successfully Added...!!!!", vbInformation + MsgBoxStyle.OkOnly, "Resource Person Saved")
            TxtAddress.Text = ""
            TxtEmail.Text = ""
            TxtMobile.Text = ""
            TxtRPDesig.Text = ""
            TxtRPName.Text = ""
            TxtRPSpecialization.Text = ""

            ' Update Rresource Person ID 

            Dim cmdTempTab As New SqlCommand("update TempTab set RPID = EVID + 1", EventCon)

            EventCon.Open()

            cmdTempTab.ExecuteNonQuery()

            EventCon.Close()


            'Get new Event ID

            cmdTempTab = New SqlCommand("Select RPID from TempTab", EventCon)

            Dim rdrTempTab As SqlDataReader


            EventCon.Open()


            rdrTempTab = cmdTempTab.ExecuteReader

            If rdrTempTab.Read Then

                LblRPID.Text = rdrTempTab("RPID").ToString


            End If


            EventCon.Close()






        End If


    End Sub
End Class