Public Class ReturnedValues

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        Dim SafeRandomDialog As New SaveFileDialog()
        SafeRandomDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        SafeRandomDialog.FilterIndex = 1
        SafeRandomDialog.RestoreDirectory = True
        If SafeRandomDialog.ShowDialog() = DialogResult.OK Then
            Dim FileXName As String = SafeRandomDialog.FileName
            Dim SaveFile As New System.IO.StreamWriter(FileXName, False)
            For Counting As Integer = 0 To (lbRandom.Items.Count - 1)
                SaveFile.WriteLine(lbRandom.Items(Counting))
            Next
            SaveFile.Close()
        End If
    End Sub

End Class