Public Class frmMain
#Region "Declaration"
    Dim ListItem, ImportListItem, RandomItem As String
    Dim ImportedItem As String()
    Dim ListCount, ImportListCount, TotalCount, RandomNumber, NumberLimit As Double
    Dim CheckedVal As Boolean
#End Region
    Private Sub AddItems(ItemName As String)
        ItemName = Replace(ItemName, " ", "")
        ListCount = LBItems.Items.Count
        If ListCount > 0 Then
            For Each Count As String In LBItems.Items
                If ItemName = Count Then
                    CheckedVal = True
                    Exit For
                Else
                    CheckedVal = False
                End If
            Next
            Select Case CheckedVal
                Case True
                    MsgBox("Item already exists in list!")
                Case False
                    LBItems.Items.Add(ItemName)
            End Select
        Else
            LBItems.Items.Add(ItemName)
        End If
        NumberCount()
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        ImportListCount = 0
        ImportListItem = InputBox("Paste values here:")
        ImportedItem = Split(ImportListItem)
        For Each NewItem As String In ImportedItem
            ImportListCount += 1
        Next
        For Import As Integer = 0 To ImportListCount - 1
            ListItem = ImportedItem(Import)
            If ListItem <> " " AndAlso ListItem <> vbNullString Then
                AddItems(ListItem)
            End If
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtAdd.Text = vbNullString Then
            MsgBox("Please insert a value into the textbox.")
        Else
            ImportListCount = 0
            ImportListItem = txtAdd.Text
            ImportedItem = Split(ImportListItem, vbNewLine)
            For Each NewItem As String In ImportedItem
                ImportListCount += 1
            Next
            For Import As Integer = 0 To ImportListCount - 1
                ListItem = ImportedItem(Import)
                If ListItem <> " " AndAlso ListItem <> vbNullString AndAlso ListItem <> vbNewLine Then
                    AddItems(ListItem)
                End If
            Next
        End If
        txtAdd.Focus()
        txtAdd.SelectAll()
    End Sub

    Private Sub txtAdd_KeyDown(sender As Object, e As KeyPressEventArgs) Handles txtAdd.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            ImportListCount = 0
            ImportListItem = txtAdd.Text
            ImportedItem = Split(ImportListItem, vbNewLine)
            For Each NewItem As String In ImportedItem
                ImportListCount += 1
            Next
            For Import As Integer = 0 To ImportListCount - 1
                ListItem = ImportedItem(Import)
                If ListItem <> " " AndAlso ListItem <> vbNullString AndAlso ListItem <> vbNewLine Then
                    AddItems(ListItem)
                End If
            Next
            txtAdd.SelectAll()
        End If
    End Sub

    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click
        TotalCount = LBItems.Items.Count
        Dim NewRandom As New Random
        If TotalCount > 0 Then
            NumberLimit = InputBox("How many random numbers do you want generated?")
            If NumberLimit > TotalCount Then
                MsgBox("The value of random items is more than the total number of items in the list!")
            Else
                Dim CheckRandom As Boolean
                Do Until ReturnedValues.lbRandom.Items.Count = NumberLimit
                    RandomNumber = NewRandom.Next(0, TotalCount)
                    RandomItem = LBItems.Items(RandomNumber)
                    CheckRandom = ReturnedValues.lbRandom.Items.Contains(RandomItem)
                    Select Case CheckRandom
                        Case True
                            Console.WriteLine("Match found!")
                        Case False
                            ReturnedValues.lbRandom.Items.Add(RandomItem)
                    End Select

                Loop
                ReturnedValues.Show()
            End If
        Else
            MsgBox("Please add items to the list first!")
        End If
    End Sub
    Private Sub NumberCount()
        lblCount.Text = LBItems.Items.Count().ToString()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim Selected As String
        Selected = LBItems.SelectedItem()
        LBItems.Items.Remove(Selected)
        NumberCount()
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        LBItems.Items.Clear()
        ReturnedValues.lbRandom.Items.Clear()
        NumberCount()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim AboutData As String
        AboutData = "A simple program that gives returns a specified number" & vbNewLine & "of random values give user provided information." & vbNewLine & "Copyright (C)  2013  Timur Lavrenti Kiyivinski" & vbNewLine & vbNewLine & "This program is free software: you can redistribute it and/or modify" & vbNewLine & "it under the terms of the GNU General Public License as published by" & vbNewLine & "the Free Software Foundation, either version 3 of the License, or" & vbNewLine & "(at your option) any later version." & vbNewLine & vbNewLine & "This program is distributed in the hope that it will be useful," & vbNewLine & "but WITHOUT ANY WARRANTY; without even the implied warranty of" & vbNewLine & "MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the" & vbNewLine & "GNU General Public License for more details." & vbNewLine & vbNewLine & "You should have received a copy of the GNU General Public License" & vbNewLine & "along with this program.  If not, see <http://www.gnu.org/licenses/>."
        MessageBox.Show(AboutData, "About", MessageBoxButtons.OK)
    End Sub

End Class
