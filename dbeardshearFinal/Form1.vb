'Derik Beardshear
'Final

Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form1

    Dim selectedUser As New User()
    Dim currentEnemy As New Enemy()
    Dim userList As New BindingList(Of User)
    Dim enemyList As New List(Of Enemy)
    Dim genRandom As New Random()
    Dim lastId As Integer = 0
    Dim dsUser As New DataSet()

    Dim actionCost As Integer = 0
    Dim enemyIndex As Integer = 0

    WithEvents enemySource As New BindingSource

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        lbxCharacters.DataSource = userList
        lbxCharacters.DisplayMember = "Name"



        Dim dbConnection As SqlConnection = openDbConnection()
        Dim daUser As New SqlDataAdapter("SELECT * FROM Users", dbConnection)
        Dim daEnemy As New SqlDataAdapter("SELECT * FROM Enemy", dbConnection)

        daUser.FillSchema(dsUser, SchemaType.Source, "Users")
        daUser.Fill(dsUser, "Users")

        daEnemy.FillSchema(dsUser, SchemaType.Source, "Enemy")
        daEnemy.Fill(dsUser, "Enemy")

        Dim userTable As DataTable = dsUser.Tables("Users")

        Try

            For Each charRow As DataRow In userTable.Rows

                Dim dbUser As New User()

                dbUser.ID = CInt(charRow.Item("Id"))
                dbUser.Name = charRow.Item("Name").ToString
                dbUser.MaxHp = CInt(charRow.Item("MaxHp"))
                dbUser.Hi = CInt(charRow.Item("Hi"))
                dbUser.Kills = CInt(charRow.Item("Kills"))
                dbUser.CurrentHp = CInt(charRow.Item("CurrentHp"))

                userList.Add(dbUser)
                selectedUser = dbUser

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            daUser.Dispose()
            dbConnection.Close()
            dbConnection.Dispose()

        End Try



        Dim enemyTable As DataTable = dsUser.Tables("Enemy")

        Try

            For Each charRow As DataRow In enemyTable.Rows

                Dim dbEnemy As New Enemy()

                dbEnemy.eID = CInt(charRow.Item("Id"))
                dbEnemy.EName = charRow.Item("Name").ToString
                dbEnemy.EHp = CInt(charRow.Item("Hp"))
                dbEnemy.eStrong = CInt(charRow.Item("Strong"))
                dbEnemy.eFast = CInt(charRow.Item("Fast"))
                dbEnemy.healing = CInt(charRow.Item("healing"))

                enemyList.Add(dbEnemy)
                currentEnemy = dbEnemy

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            daUser.Dispose()
            dbConnection.Close()
            dbConnection.Dispose()

        End Try

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        Dim newUser As New User()

        If txtName.Text = "" Then

            MessageBox.Show("Please enter a name")

        Else

            newUser.Name = txtName.Text

            Dim itemCount As Integer = lbxCharacters.Items.Count

            lbxCharacters.SelectedIndex = itemCount - 1
            userList.Add(newUser)
            selectedUser = newUser
            selectedUser.CurrentHp = selectedUser.MaxHp
            showUser()
            txtName.Text = ""

        End If

        If selectedUser.Name = "J. G. Wentworth" Then

            selectedUser.MaxHp = 877
            selectedUser.CurrentHp = 877
            lblTitle.Text = "It's your money use it when you need it."

        ElseIf selectedUser.Name = "Josh" Then

            lblUserName.Text = "Best VB Teacher"

        ElseIf selectedUser.Name = "Derik" Then

            lblTitle.Text = "Hello Creator"

        ElseIf selectedUser.Name = "Wimp" Then

            selectedUser.MaxHp = 1000
            selectedUser.CurrentHp = 1000

        ElseIf selectedUser.Name = "Hardcore" Then

            selectedUser.MaxHp = 150
            selectedUser.CurrentHp = 150

        ElseIf selectedUser.Name = "CENA" Then

            lblUserName.Text = ""
            lblUserHp.Text = ""
            lblUserHi.Text = ""
            lblKills.Text = ""

        ElseIf selectedUser.Name = "Link" Then

            lblTitle.Text = "Open your eyes"

        ElseIf selectedUser.Name = "Snake" Then

            lblNameInput.Text = "A Hind D?!?!"

        ElseIf selectedUser.Name = "Collin" Then

            lblNameInput.Text = "Hi Collin!"

        ElseIf selectedUser.Name = "Ezio" Then

            lblTitle.Text = "Nothing is true, everything is permitted"

        ElseIf selectedUser.Name = "Cartman" Then

            lblTitle.Text = "I'M NOT FAT, I'M BIG BONED!"

        ElseIf selectedUser.Name = "Zelda" Then

            lblTitle.Text = "Sorry no second quest =("

        ElseIf selectedUser.Name = "EndGame" Then

            selectedUser.Kills = 8

        End If

    End Sub

    Private Sub lbxCharacters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxCharacters.SelectedIndexChanged
        If Not lbxCharacters.SelectedItem Is Nothing Then

            selectedUser = CType(lbxCharacters.SelectedItem, User)
            showUser()
            enemyIndex = selectedUser.Kills

        End If


    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click


        If Not lbxCharacters.SelectedItem Is Nothing Then

            If dsUser.Tables("Users").Rows.Contains(selectedUser.ID) Then

                dsUser.Tables("Users").Rows.Find(selectedUser.ID).Delete()
                Dim dbConnection = openDbConnection()
                Dim daUser As New SqlDataAdapter("SELECT * FROM Users", dbConnection)
                Dim cmdBuild As New SqlCommandBuilder(daUser)
                Dim userTable As DataTable = dsUser.Tables("Users")

                daUser.DeleteCommand = cmdBuild.GetDeleteCommand()
                daUser.Update(dsUser, "Users")

                daUser.Dispose()
                dbConnection.Close()
                dbConnection.Dispose()

            End If

            userList.RemoveAt(lbxCharacters.SelectedIndex)

        End If

    End Sub

    Private Sub showUser()

        If Not lbxCharacters.SelectedItem Is Nothing Then

            lblGameName.Text = ""
            lblUserName.Text = selectedUser.Name
            lblUserHp.Text = selectedUser.CurrentHp.ToString()
            lblUserHi.Text = selectedUser.Hi.ToString()
            lblKills.Text = selectedUser.Kills.ToString()

        End If

    End Sub

    Private Sub showEnemy()

        lblEName.Text = currentEnemy.EName
        lblEHP.Text = currentEnemy.EHp.ToString()

    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        If Not lbxCharacters.SelectedItem Is Nothing Then

            Dim dbConnection As SqlConnection = openDbConnection()
            Dim daUser As New SqlDataAdapter("SELECT * FROM Users", dbConnection)
            Dim cmdBuild As New SqlCommandBuilder(daUser)
            Dim charTable As DataTable = dsUser.Tables("Users")

            daUser.InsertCommand = cmdBuild.GetInsertCommand()
            daUser.UpdateCommand = cmdBuild.GetUpdateCommand()


            If Not charTable.Rows.Contains(selectedUser.ID) Then

                Dim newCharRow As DataRow = charTable.NewRow()
                populatedRow(newCharRow)
                charTable.Rows.Add(newCharRow)
                selectedUser.ID = CInt(newCharRow.Item("Id"))

            Else

                Dim existingRow As DataRow = charTable.Rows.Find(selectedUser.ID)
                populatedRow(existingRow)

            End If

            Try
                daUser.Update(dsUser, "Users")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                daUser.Dispose()
                dbConnection.Close()
                dbConnection.Dispose()
            End Try

        End If


    End Sub

    Private Sub eBrain()

        While actionCost > 0

            If genRandom.Next(1, 3) = 2 And actionCost > 1 Then

                selectedUser.CurrentHp -= currentEnemy.eStrong
                actionCost -= 2
                showUser()

            Else

                selectedUser.CurrentHp -= currentEnemy.eFast
                actionCost -= 1
                showUser()

            End If

        End While

        If selectedUser.CurrentHp <= 0 Then
            MessageBox.Show("You are dead. Soon your cat will be with you. I mean who else will be looking after them?")
            dead()
            showUser()
            showEnemy()

        End If


    End Sub

    Private Sub dead()

        selectedUser.MaxHp -= 50
        selectedUser.CurrentHp = selectedUser.MaxHp
        selectedUser.Hi = 5

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If selectedUser.Name Is Nothing Then

            MessageBox.Show("Please select character.")

        Else

            currentEnemy = enemyList(enemyIndex)
            showEnemy()


        End If

    End Sub

    Private Function openDbConnection() As SqlConnection

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Derik\Documents\Visual Studio 2015\Projects\dbeardshearFinal\dbeardshearFinal\Wmbtbg.mdf;Integrated Security=True"
        Dim dbConnection As New SqlConnection(connectionString)
        dbConnection.Open()


        Return dbConnection

    End Function

    Private Sub populatedRow(row As DataRow)

        row.Item("Name") = selectedUser.Name
        row.Item("MaxHp") = selectedUser.MaxHp
        row.Item("Hi") = selectedUser.Hi
        row.Item("Kills") = selectedUser.Kills
        row.Item("CurrentHp") = selectedUser.CurrentHp

    End Sub

    Private Sub btnStrong_Click(sender As Object, e As EventArgs) Handles btnStrong.Click

        If selectedUser.Name Is Nothing Then

            MessageBox.Show("Please select character.")

        Else

            currentEnemy = enemyList(enemyIndex)
            showEnemy()


        End If

        currentEnemy.EHp -= 50
        showEnemy()

        If Not currentEnemy.EHp > 0 Then

            MessageBox.Show("Congratulations!")
            selectedUser.Kills += 1
            selectedUser.MaxHp += 25
            selectedUser.CurrentHp += currentEnemy.healing
            If Not enemyIndex = 8 Then

                enemyIndex += 1
                If enemyIndex >= 5 Then
                    selectedUser.Hi += 1
                End If
                currentEnemy = enemyList(enemyIndex)
                showUser()
                showEnemy()


            Else

                MessageBox.Show("You Win!!!!!!!!!!!!!!!!!!!! Now go play a real game.")

            End If


        Else

            actionCost = 2
            eBrain()

        End If

    End Sub

    Private Sub btnFast_Click(sender As Object, e As EventArgs) Handles btnFast.Click

        If selectedUser.Name Is Nothing Then

            MessageBox.Show("Please select character.")

        Else

            currentEnemy = enemyList(enemyIndex)
            showEnemy()


        End If

        currentEnemy.EHp -= 26
        showEnemy()

        If Not currentEnemy.EHp > 0 Then

            MessageBox.Show("Congratulations!")
            selectedUser.Kills += 1
            selectedUser.MaxHp += 25
            selectedUser.CurrentHp += currentEnemy.healing

            If Not enemyIndex = 9 Then

                enemyIndex += 1
                If enemyIndex >= 5 Then
                    selectedUser.Hi += 1
                End If
                currentEnemy = enemyList(enemyIndex)
                showUser()
                showEnemy()


            Else

                MessageBox.Show("You Win!!!!!!!!!!!!!!!!!!!! Now go play a real game.")
            End If
        Else

            actionCost = 1
            eBrain()

        End If

    End Sub

    Private Sub btnHeal_Click(sender As Object, e As EventArgs) Handles btnHeal.Click

        If selectedUser.Name Is Nothing Then

            MessageBox.Show("Please select character.")

        Else


            currentEnemy = enemyList(enemyIndex)
            showEnemy()


        End If

        If selectedUser.CurrentHp = selectedUser.MaxHp Then

            MessageBox.Show("Health already at max.")

        Else


            selectedUser.CurrentHp = selectedUser.MaxHp
            selectedUser.Hi -= 1
            showUser()

            actionCost = 1
            eBrain()
        End If

    End Sub

End Class
