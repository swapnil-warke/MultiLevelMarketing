Imports System.Data.SqlClient

Public Class conection
    Public con As SqlConnection
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public dr1 As SqlDataReader

   
    
    Public Sub connect()
        'con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\swap\backup_desktop\multilevel marketing\multi_lm.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=E:\Software\multilevel marketing\multi_lm.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    End Sub
    Public Sub done()
        cmd = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.Text

    End Sub

End Class
