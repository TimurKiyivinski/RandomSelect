'RandomSelect V1.2
'============

'A simple program that gives returns a specified number
'of random values give user provided information.
'Copyright (C)  2014  Timur Lavrenti Kiyivinski

'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.

'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.

'You should have received a copy of the GNU General Public License
'along with this program.  If not, see <http://www.gnu.org/licenses/>.
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
                    MsgBox("Item " & ItemName & " already exists in list!")
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
            NumberLimit = InputBox("How many random numbers do you want selected?")
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
        txtAdd.Text = String.Empty
        NumberCount()
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        LBItems.Items.Clear()
        ReturnedValues.lbRandom.Items.Clear()
        NumberCount()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim AboutData As String
        AboutData = "Random Select V1.2" + vbNewLine + "A simple program that gives returns a specified number" & vbNewLine & "of random values give user provided information." & vbNewLine & "Copyright (C)  2014  Timur Lavrenti Kiyivinski" & vbNewLine & vbNewLine & "This program is free software: you can redistribute it and/or modify" & vbNewLine & "it under the terms of the GNU General Public License as published by" & vbNewLine & "the Free Software Foundation, either version 3 of the License, or" & vbNewLine & "(at your option) any later version." & vbNewLine & vbNewLine & "This program is distributed in the hope that it will be useful," & vbNewLine & "but WITHOUT ANY WARRANTY; without even the implied warranty of" & vbNewLine & "MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the" & vbNewLine & "GNU General Public License for more details." & vbNewLine & vbNewLine & "You should have received a copy of the GNU General Public License" & vbNewLine & "along with this program.  If not, see <http://www.gnu.org/licenses/>."
        MessageBox.Show(AboutData, "About", MessageBoxButtons.OK)
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim myRange As String
        Dim rangeSplit As String()
        Dim testCount, minVal, maxVal, countVal, limVal As Double
        myRange = InputBox("Please input the minimum value, maximum value followed by the number of random numbers you want generated, separated by commas." + vbNewLine + "For example: 5,20,15 will generate 15 random numbers from the range 5-20.")
        rangeSplit = myRange.Split(",")
        For Each X As String In rangeSplit
            testCount += 1
        Next
        If testCount = 3 Then
            minVal = CDbl(rangeSplit(0))
            maxVal = CDbl(rangeSplit(1))
            countVal = CDbl(rangeSplit(2))
            limVal = countVal
        Else
            MsgBox("Your value was not properly formatted!")
            Exit Sub
        End If
        If maxVal <= minVal Then
            MsgBox("Maximum value must be greater than minimum value!")
            Exit Sub
        ElseIf minVal >= maxVal Then
            MsgBox("Minimum value must be smaller than maximum value!")
            Exit Sub
        End If
        If countVal <= 1 Then
            MsgBox("Please input more than 1 for random number count!")
            Exit Sub
        End If
        If (maxVal - minVal + 1) <= countVal Then
            MsgBox("You have requested more random numbers than possible!")
            Exit Sub
        End If
        Dim myRandomDbl As New Random
        Dim myRandomValue As Double = 1
        'We test how many random values can actually be inserted.
        Dim matchesFound, missesFound As Double
        missesFound = 0
        matchesFound = 0
        Console.WriteLine("Max:" & maxVal.ToString)
        Console.WriteLine("Min:" & minVal.ToString)
        If LBItems.Items.Count > 0 Then
            For limitTest = minVal To maxVal
                For Each addedItems As String In LBItems.Items
                    If limitTest = addedItems Then
                        matchesFound += 1
                        Exit For
                    End If
                Next
            Next
            missesFound = (maxVal - minVal) - matchesFound
            Console.WriteLine(matchesFound.ToString & " matches found in list")
            Console.WriteLine(missesFound.ToString & " misses found in list")
            If missesFound < countVal Then
                countVal = missesFound
            End If
            If missesFound = 0 AndAlso matchesFound = countVal Then
                countVal = 0
            End If
        End If
        If countVal <= 0 Then
            MsgBox("All values within this range are already in the list.")
            Exit Sub
        End If
        If countVal <> limVal Then
            Dim appContinue As DialogResult
            appContinue = MessageBox.Show("Because there are duplicates within the limit of the range specified, only " & countVal.ToString() & " can be generated." & vbNewLine & "Should the application continue generating these values?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If appContinue = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If
        Dim addedRandom As Double
        Do Until addedRandom = countVal
            myRandomValue = myRandomDbl.Next(minVal, maxVal)
            'Console.WriteLine(myRandomValue.ToString)
            If LBItems.Items.Count <= 0 Then
                AddItems(myRandomValue.ToString)
                addedRandom += 1
            Else
                Select Case LBItems.FindString(myRandomValue.ToString)
                    Case ListBox.NoMatches
                        AddItems(myRandomValue.ToString)
                        addedRandom += 1
                    Case Else

                End Select
            End If
        Loop
    End Sub
End Class
