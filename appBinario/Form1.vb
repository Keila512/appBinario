Imports System.IO
Imports System.Text

Namespace My
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnLeer_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim ofd As OpenFileDialog = New OpenFileDialog()
            ofd.Filter = "txt|*.txt"

            If ofd.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            Dim sr As StreamReader = New StreamReader(ofd.FileName)
            RichTextBox1.Text = sr.ReadToEnd()
            sr.Close()
        End Sub

        Private Sub btnEscribr_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim sfd As SaveFileDialog = New SaveFileDialog()
            sfd.Filter = "txt|*.txt"

            If sfd.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            Dim sw As StreamWriter = New StreamWriter(sfd.FileName)
            sw.Write(RichTextBox1.Text)
            sw.Close()
        End Sub

        Private Sub btnBinario_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim sfd As SaveFileDialog = New SaveFileDialog()
            sfd.Filter = "txt|*.txt"

            If sfd.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            Dim sw As StreamWriter = New StreamWriter(sfd.FileName)
            Dim binaryString As String = ToBinary(ConvertToByteArray(RichTextBox1.Text, Encoding.ASCII))
            sw.Write(binaryString)
            sw.Close()
        End Sub

        Public Shared Function ConvertToByteArray(ByVal str As String, ByVal encoding As Encoding) As Byte()
            Return encoding.GetBytes(str)
        End Function

        Public Shared Function ToBinary(ByVal data As Byte()) As String
            Return String.Join(" ", data.[Select](Function(byt) Convert.ToString(byt, 2).PadLeft(8, "0"c)))
        End Function
    End Class
End Namespace

