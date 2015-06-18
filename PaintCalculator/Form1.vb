Public Class Form1
    Dim height1, lenghtA, lenghtB, lenghtC, lenghtD, lenghtE, lenghtF, lenghtG, lenghtH, result, price As Integer
    Dim webadress As String = "http://news.bbc.co.uk/weather/forecast/8"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton4.Checked = True
    End Sub
    Private Sub TextBox1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.Text = ""
    End Sub
    Private Sub TextBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            TextBox1.Text = "height"
        End If
    End Sub

    Private Sub TextBox2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox2.MouseClick
        TextBox2.Text = ""
    End Sub
    Private Sub TextBox2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Leave
        If TextBox2.Text = "" Then
            TextBox2.Text = "wall A lenght"
        End If
    End Sub

    Private Sub TextBox3_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox3.MouseClick
        TextBox3.Text = ""
    End Sub
    Private Sub TextBox3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.Leave
        If TextBox3.Text = "" Then
            TextBox3.Text = "wall B lenght"
        End If
    End Sub

    Private Sub TextBox4_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox4.MouseClick
        TextBox4.Text = ""
    End Sub
    Private Sub TextBox4_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.Leave
        If TextBox4.Text = "" Then
            TextBox4.Text = "wall C lenght"
        End If
    End Sub

    Private Sub TextBox5_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox5.MouseClick
        TextBox5.Text = ""
    End Sub
    Private Sub TextBox5_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.Leave
        If TextBox5.Text = "" Then
            TextBox5.Text = "wall D lenght"
        End If
    End Sub

    Private Sub TextBox6_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox6.MouseClick
        TextBox6.Text = ""
    End Sub
    Private Sub TextBox6_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.Leave
        If TextBox6.Text = "" Then
            TextBox6.Text = "wall E lenght"
        End If
    End Sub

    Private Sub TextBox7_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox7.MouseClick
        TextBox7.Text = ""
    End Sub
    Private Sub TextBox7_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.Leave
        If TextBox7.Text = "" Then
            TextBox7.Text = "wall F lenght"
        End If
    End Sub

    Private Sub TextBox8_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox8.MouseClick
        TextBox8.Text = ""
    End Sub
    Private Sub TextBox8_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.Leave
        If TextBox8.Text = "" Then
            TextBox8.Text = "wall G lenght"
        End If
    End Sub

    Private Sub TextBox9_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox9.MouseClick
        TextBox9.Text = ""
    End Sub
    Private Sub TextBox9_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.Leave
        If TextBox9.Text = "" Then
            TextBox9.Text = "wall H lenght"
        End If
    End Sub


    'button calculate below
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Not IsNumeric(TextBox1.Text) And TextBox1.Text <> vbNullString Then
            MsgBox("Please enter height")
            Return
        End If
        If Not IsNumeric(TextBox2.Text) And TextBox2.Text <> vbNullString Then
            TextBox2.Text = "0"
        End If
        If Not IsNumeric(TextBox3.Text) And TextBox3.Text <> vbNullString Then
            TextBox3.Text = "0"
        End If
        If Not IsNumeric(TextBox4.Text) And TextBox4.Text <> vbNullString Then
            TextBox4.Text = "0"
        End If
        If Not IsNumeric(TextBox5.Text) And TextBox5.Text <> vbNullString Then
            TextBox5.Text = "0"
        End If
        If Not IsNumeric(TextBox6.Text) And TextBox6.Text <> vbNullString Then
            TextBox6.Text = "0"
        End If
        If Not IsNumeric(TextBox7.Text) And TextBox7.Text <> vbNullString Then
            TextBox7.Text = "0"
        End If
        If Not IsNumeric(TextBox8.Text) And TextBox8.Text <> vbNullString Then
            TextBox8.Text = "0"
        End If
        If Not IsNumeric(TextBox9.Text) And TextBox9.Text <> vbNullString Then
            TextBox9.Text = "0"
        End If

        height1 = TextBox1.Text()
        lenghtA = TextBox2.Text()
        lenghtB = TextBox3.Text()
        lenghtC = TextBox4.Text()
        lenghtD = TextBox5.Text()
        lenghtE = TextBox6.Text()
        lenghtF = TextBox7.Text()
        lenghtG = TextBox8.Text()
        lenghtH = TextBox9.Text()

        If RadioButton1.Checked = True Then
            'Luxury calc
            If RadioButton4.Checked = True Then
                'meters
                result = (height1 * lenghtA) + (height1 * lenghtB) + (height1 * lenghtC) + (height1 * lenghtD) + (height1 * lenghtE) + (height1 * lenghtF) + (height1 * lenghtG) + (height1 * lenghtH)
                Label11.Text = result & " m²"
                price = result * 1.75
                Label12.Text = "£" & price
            End If

            If RadioButton5.Checked = True Then
                'feet
                result = (height1 * lenghtA) + (height1 * lenghtB) + (height1 * lenghtC) + (height1 * lenghtD) + (height1 * lenghtE) + (height1 * lenghtF) + (height1 * lenghtG) + (height1 * lenghtH)
                If result = 1 Then
                    Label11.Text = result & " foot²"
                End If
                If result <> 1 Then
                    Label11.Text = result & " feet²"
                End If
                price = result / 3.28083989501312 * 1.75
                Label12.Text = "£" & price
            End If
        End If


        If RadioButton2.Checked = True Then
            'standard calc
            If RadioButton4.Checked = True Then
                'meters
                result = (height1 * lenghtA) + (height1 * lenghtB) + (height1 * lenghtC) + (height1 * lenghtD) + (height1 * lenghtE) + (height1 * lenghtF) + (height1 * lenghtG) + (height1 * lenghtH)
                Label11.Text = result & " m²"
                price = result * 1
                Label12.Text = "£" & price
            End If
            If RadioButton5.Checked = True Then
                'feet
                result = (height1 * lenghtA) + (height1 * lenghtB) + (height1 * lenghtC) + (height1 * lenghtD) + (height1 * lenghtE) + (height1 * lenghtF) + (height1 * lenghtG) + (height1 * lenghtH)
                If result = 1 Then
                    Label11.Text = result & " foot²"
                End If
                If result <> 1 Then
                    Label11.Text = result & " feet²"
                End If
                price = result / 3.28083989501312 * 1
                Label12.Text = "£" & price
            End If
        End If

        If RadioButton3.Checked = True Then
            'economy calc
            If RadioButton4.Checked = True Then
                'meters
                result = (height1 * lenghtA) + (height1 * lenghtB) + (height1 * lenghtC) + (height1 * lenghtD) + (height1 * lenghtE) + (height1 * lenghtF) + (height1 * lenghtG) + (height1 * lenghtH)
                Label11.Text = result & " m²"
                price = result * 0.45
                Label12.Text = "£" & price
            End If
            If RadioButton5.Checked = True Then
                'feet
                result = (height1 * lenghtA) + (height1 * lenghtB) + (height1 * lenghtC) + (height1 * lenghtD) + (height1 * lenghtE) + (height1 * lenghtF) + (height1 * lenghtG) + (height1 * lenghtH)
                If result = 1 Then
                    Label11.Text = result & " foot²"
                End If
                If result <> 1 Then
                    Label11.Text = result & " feet²"
                End If
                price = result / 3.28083989501312 * 0.45
                Label12.Text = "£" & price
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start(webadress)
    End Sub

    Private Sub HowToUseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowToUseToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class
' Created by Maksym Makuch
' All rights reserved
