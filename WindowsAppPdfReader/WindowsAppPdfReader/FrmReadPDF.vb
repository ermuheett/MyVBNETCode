
Imports System
Imports System.Text
Imports GemBox.Document
Imports System.Text.RegularExpressions


Public Class FrmReadPDF
    Private Sub frmReadData_Click(sender As Object, e As EventArgs) Handles frmReadData.Click



    End Sub

    Private Sub butnTestCode_Click(sender As Object, e As EventArgs) Handles butnTestCode.Click

        If OFDPdfRead.ShowDialog Then


            ' If using Professional version, put your serial key below.
            ComponentInfo.SetLicense("FREE-LIMITED-KEY")


            Dim strPath As String = OFDPdfRead.FileName

            lblPath.Text = strPath


            Dim document As DocumentModel = DocumentModel.Load(strPath)

            Dim sb As New StringBuilder()

            ' Read PDF file's document properties.
            '  sb.AppendFormat("Author: {0}", document.DocumentProperties.BuiltIn(BuiltInDocumentProperty.Author)).AppendLine()
            ' sb.AppendFormat("DateContentCreated: {0}", document.DocumentProperties.BuiltIn(BuiltInDocumentProperty.DateLastSaved)).AppendLine()

            ' Sample's input parameter.
            '' Dim pattern As String = "(?<Name:>\d+)\s+(?<Registration No:>\d+\.\d{2})\s+(?<Total>\d+\.\d{2})"

            MsgBox(document.Content.ToString(0))




            Dim pattern As String = "(?<Name:>\d+)\s+"

            Dim regex As Regex = New Regex("Name:")

            Dim row As Integer = 0
            Dim line As StringBuilder = New StringBuilder()

            ' Read PDF file's text content and match a specified regular expression.

            For Each match As Match In regex.Matches(document.Content.ToString())
                line.Length = 0
                line.AppendFormat("Result: {0}: ", ++row)

                ' Either write only successfully matched named groups or entire match.
                Dim hasAny As Boolean = False
                For i As Integer = 1 To match.Groups.Count - 1
                    Dim groupName As String = regex.GroupNameFromNumber(i)
                    Dim matchGroup As Group = match.Groups(i)
                    If (matchGroup.Success And groupName <> i.ToString()) Then
                        line.AppendFormat("{0}= {1}, ", groupName, matchGroup.Value)
                        hasAny = True
                    End If
                Next

                If (hasAny) Then
                    line.Length -= 2
                Else
                    line.Append(match.Value)
                End If

                sb.AppendLine(line.ToString())
            Next

            ' Console.WriteLine(sb.ToString())
            MsgBox(sb.ToString())

        End If
    End Sub



End Class
