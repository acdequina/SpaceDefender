Public Class Form1
    Dim nb As Integer
    Dim subslow As Integer = 0
    Dim slow As Integer
    Dim win As Integer
    Dim bltcount As Integer
    Dim boom As Integer
    Dim lifect As Integer = 0
    Dim dead As Integer
    Dim nsync As Integer
    Dim nupdwn As Integer
    Dim n5 As Integer
    Dim n4 As Integer
    Dim n3 As Integer
    Dim n2 As Integer
    Dim n1 As Integer



    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Dim Bullets() As PictureBox = {blt1, blt2, blt3, blt4, blt5}

        Select Case e.KeyCode
            Case Keys.Space
                Bullets(bltcount).Location = ship.Location
                tshipblt.Enabled = True
                Bullets(bltcount).Visible = True
                bltcount += 1
                If bltcount = 5 Then
                    bltcount = 0
                End If
                e.Handled = True

            Case Keys.Left
                ship.Left -= 10
                e.Handled = True
            Case Keys.Right
                ship.Left += 10
                e.Handled = True

        End Select
        If ship.Bounds.IntersectsWith(en1bt.Bounds) Or ship.Bounds.IntersectsWith(en2bt.Bounds) Or ship.Bounds.IntersectsWith(en3bt.Bounds) Or ship.Bounds.IntersectsWith(en4bt.Bounds) Or ship.Bounds.IntersectsWith(en5bt.Bounds) Or ship.Bounds.IntersectsWith(bossblt.Bounds) Then
            bltcount = 0
            fxship.Enabled = True
            boom = 0

        End If


    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        bosshp.Value = 100
        en1bt.Location = New Point(en1.Location)
        en2bt.Location = New Point(en2.Location)
        en3bt.Location = New Point(en3.Location)
        en4bt.Location = New Point(en4.Location)
        en5bt.Location = New Point(en5.Location)



    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tshipblt.Tick
        Dim Bullets() As PictureBox = {blt1, blt2, blt3, blt4, blt5}

        If blt1.Bounds.IntersectsWith(en1.Bounds) Or blt2.Bounds.IntersectsWith(en1.Bounds) Or blt3.Bounds.IntersectsWith(en1.Bounds) Or blt4.Bounds.IntersectsWith(en1.Bounds) Or blt5.Bounds.IntersectsWith(en1.Bounds) Then

            boom = 1
            fxship.Enabled = True
            tshipblt.Enabled = False
            blt1.Visible = False
            blt1.Location = New Point(382, 490)
            blt2.Visible = False
            blt2.Location = New Point(382, 490)
            blt3.Visible = False
            blt3.Location = New Point(382, 490)
            blt4.Visible = False
            blt4.Location = New Point(382, 490)
            blt5.Visible = False
            blt5.Location = New Point(382, 490)

        ElseIf blt1.Bounds.IntersectsWith(en2.Bounds) Or blt2.Bounds.IntersectsWith(en2.Bounds) Or blt3.Bounds.IntersectsWith(en2.Bounds) Or blt4.Bounds.IntersectsWith(en2.Bounds) Or blt5.Bounds.IntersectsWith(en2.Bounds) Then

            boom = 2
            fxship.Enabled = True
            tshipblt.Enabled = False
            blt1.Visible = False
            blt1.Location = New Point(382, 490)
            blt2.Visible = False
            blt2.Location = New Point(382, 490)
            blt3.Visible = False
            blt3.Location = New Point(382, 490)
            blt4.Visible = False
            blt4.Location = New Point(382, 490)
            blt5.Visible = False
            blt5.Location = New Point(382, 490)

        ElseIf blt1.Bounds.IntersectsWith(en3.Bounds) Or blt2.Bounds.IntersectsWith(en3.Bounds) Or blt3.Bounds.IntersectsWith(en3.Bounds) Or blt4.Bounds.IntersectsWith(en3.Bounds) Or blt5.Bounds.IntersectsWith(en3.Bounds) Then

            boom = 3
            fxship.Enabled = True
            tshipblt.Enabled = False
            blt1.Visible = False
            blt1.Location = New Point(382, 490)
            blt2.Visible = False
            blt2.Location = New Point(382, 490)
            blt3.Visible = False
            blt3.Location = New Point(382, 490)
            blt4.Visible = False
            blt4.Location = New Point(382, 490)
            blt5.Visible = False
            blt5.Location = New Point(382, 490)

        ElseIf blt1.Bounds.IntersectsWith(en4.Bounds) Or blt2.Bounds.IntersectsWith(en4.Bounds) Or blt3.Bounds.IntersectsWith(en4.Bounds) Or blt4.Bounds.IntersectsWith(en4.Bounds) Or blt5.Bounds.IntersectsWith(en4.Bounds) Then

            boom = 4
            fxship.Enabled = True
            tshipblt.Enabled = False
            blt1.Visible = False
            blt1.Location = New Point(382, 490)
            blt2.Visible = False
            blt2.Location = New Point(382, 490)
            blt3.Visible = False
            blt3.Location = New Point(382, 490)
            blt4.Visible = False
            blt4.Location = New Point(382, 490)
            blt5.Visible = False
            blt5.Location = New Point(382, 490)

        ElseIf blt1.Bounds.IntersectsWith(en5.Bounds) Or blt2.Bounds.IntersectsWith(en5.Bounds) Or blt3.Bounds.IntersectsWith(en5.Bounds) Or blt4.Bounds.IntersectsWith(en5.Bounds) Or blt5.Bounds.IntersectsWith(en5.Bounds) Then

            boom = 5
            fxship.Enabled = True
            tshipblt.Enabled = False
            blt1.Visible = False
            blt1.Location = New Point(382, 490)
            blt2.Visible = False
            blt2.Location = New Point(382, 490)
            blt3.Visible = False
            blt3.Location = New Point(382, 490)
            blt4.Visible = False
            blt4.Location = New Point(382, 490)
            blt5.Visible = False
            blt5.Location = New Point(382, 490)


        ElseIf blt1.Bounds.IntersectsWith(boss.Bounds) Or blt2.Bounds.IntersectsWith(boss.Bounds) Or blt3.Bounds.IntersectsWith(boss.Bounds) Or blt4.Bounds.IntersectsWith(boss.Bounds) Or blt5.Bounds.IntersectsWith(boss.Bounds) Then
            If bosshp.Value <= 20 Then
                fxship.Enabled = True
                boom = 6
            End If

            bosshp.Value -= 10
            blt1.Visible = False
            blt1.Location = New Point(382, 490)
            blt2.Visible = False
            blt2.Location = New Point(382, 490)
            blt3.Visible = False
            blt3.Location = New Point(382, 490)
            blt4.Visible = False
            blt4.Location = New Point(382, 490)
            blt5.Visible = False
            blt5.Location = New Point(382, 490)
            

            End If

            For i = 0 To Bullets.Length - 1
                Bullets(i).Top -= 20
            Next
    End Sub

    Private Sub en1t_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ten1blt.Tick

        If en1bt.Bounds.IntersectsWith(ship.Bounds) Then
            fxship.Enabled = True
            boom = 0
        End If
        en1bt.Visible = True
        en1bt.Top += 10
        n1 += 1
        If n1 = 50 Then
            en1bt.Location = New Point(en1.Location)
            en1.Image = My.Resources.en5_2
            n1 = 0
        End If
        If en1bt.Location <> en1.Location Then
            en1.Image = My.Resources.en5_1
        End If


    End Sub

    Private Sub en2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles en2.Click



    End Sub

    Private Sub en3t_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ten3blt.Tick
        If en3bt.Bounds.IntersectsWith(ship.Bounds) Then
            fxship.Enabled = True
            boom = 0
        End If
        en3bt.Visible = True
        en3bt.Top += 10
        n3 += 1
        If n3 = 50 Then
            en3bt.Location = New Point(en3.Location)
            en3.Image = My.Resources.en5_2
            n3 = 0
        End If
        If en3bt.Location <> en3.Location Then
            en3.Image = My.Resources.en5_1
        End If
    End Sub

    Private Sub en4t_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ten4blt.Tick
        If en4bt.Bounds.IntersectsWith(ship.Bounds) Then
            fxship.Enabled = True
            boom = 0
        End If
        en4bt.Visible = True
        en4bt.Top += 10
        n4 += 1
        If n4 = 50 Then
            en4bt.Location = New Point(en4.Location)
            en4.Image = My.Resources.en5_2
            n4 = 0
        End If
        If en4bt.Location <> en4.Location Then
            en4.Image = My.Resources.en5_1
        End If
    End Sub

    Private Sub en5t_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ten5blt.Tick
        If en5bt.Bounds.IntersectsWith(ship.Bounds) Then
            fxship.Enabled = True
            boom = 0
        End If

        en5bt.Visible = True
        en5bt.Top += 10
        n5 += 1
        If n5 = 50 Then
            en5bt.Location = New Point(en5.Location)
            en5.Image = My.Resources.en5_2
            n5 = 0
        End If
        If en5bt.Location <> en5.Location Then
            en5.Image = My.Resources.en5_1
        End If
    End Sub

    Private Sub en1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles en1.Click

    End Sub

    Private Sub en2t_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ten2blt.Tick
        If en2bt.Bounds.IntersectsWith(ship.Bounds) Then
            fxship.Enabled = True
            boom = 0
        End If

        en2bt.Visible = True
        en2bt.Top += 10
        n2 += 1
        If n2 = 50 Then
            en2bt.Location = New Point(en2.Location)
            en2.Image = My.Resources.en5_2
            n2 = 0
        End If
        If en2bt.Location <> en2.Location Then
            en2.Image = My.Resources.en5_1
        End If


    End Sub

    Private Sub ensycmv_Tick(sender As Object, e As EventArgs) Handles ensycmv1.Tick

        If en1.Bounds.IntersectsWith(blt1.Bounds) Or en1.Bounds.IntersectsWith(blt2.Bounds) Or en1.Bounds.IntersectsWith(blt3.Bounds) Or en1.Bounds.IntersectsWith(blt4.Bounds) Or en1.Bounds.IntersectsWith(blt5.Bounds) Then
            fxship.Enabled = True
            boom = 1

        ElseIf en2.Bounds.IntersectsWith(blt1.Bounds) Or en2.Bounds.IntersectsWith(blt2.Bounds) Or en2.Bounds.IntersectsWith(blt3.Bounds) Or en2.Bounds.IntersectsWith(blt4.Bounds) Or en2.Bounds.IntersectsWith(blt5.Bounds) Then
            fxship.Enabled = True
            boom = 2

        ElseIf en3.Bounds.IntersectsWith(blt1.Bounds) Or en3.Bounds.IntersectsWith(blt2.Bounds) Or en3.Bounds.IntersectsWith(blt3.Bounds) Or en3.Bounds.IntersectsWith(blt4.Bounds) Or en3.Bounds.IntersectsWith(blt5.Bounds) Then
            fxship.Enabled = True
            boom = 3

        ElseIf en4.Bounds.IntersectsWith(blt1.Bounds) Or en4.Bounds.IntersectsWith(blt2.Bounds) Or en4.Bounds.IntersectsWith(blt3.Bounds) Or en4.Bounds.IntersectsWith(blt4.Bounds) Or en4.Bounds.IntersectsWith(blt5.Bounds) Then
            fxship.Enabled = True
            boom = 4

        ElseIf en5.Bounds.IntersectsWith(blt1.Bounds) Or en5.Bounds.IntersectsWith(blt2.Bounds) Or en5.Bounds.IntersectsWith(blt3.Bounds) Or en5.Bounds.IntersectsWith(blt4.Bounds) Or en5.Bounds.IntersectsWith(blt5.Bounds) Then
            fxship.Enabled = True
            boom = 5

        End If

        en1.Left -= 10
        en2.Left -= 10
        en3.Left -= 10
        en4.Left -= 10
        en5.Left -= 10
        nsync += 1
        If nsync = 20 Then
            ensycmv1.Enabled = False
            ensycmv2.Enabled = True
            nupdwn += 1
            If nupdwn >= 0 And nupdwn < 10 Then
                en1.Top += 20
                en2.Top += 20
                en3.Top += 20
                en4.Top += 20
                en5.Top += 20
            ElseIf nupdwn >= 10 And nupdwn < 20 Then
                en1.Top -= 20
                en2.Top -= 20
                en3.Top -= 20
                en4.Top -= 20
                en5.Top -= 20
            ElseIf nupdwn = 10 Then
                nupdwn = 0
            End If
        End If


    End Sub

    Private Sub ensycm2_Tick(sender As Object, e As EventArgs) Handles ensycmv2.Tick

        If en1.Bounds.IntersectsWith(blt1.Bounds) Or en1.Bounds.IntersectsWith(blt2.Bounds) Or en1.Bounds.IntersectsWith(blt3.Bounds) Or en1.Bounds.IntersectsWith(blt4.Bounds) Or en1.Bounds.IntersectsWith(blt5.Bounds) Then
            fxship.Enabled = True
            boom = 1

        ElseIf en2.Bounds.IntersectsWith(blt1.Bounds) Or en2.Bounds.IntersectsWith(blt2.Bounds) Or en2.Bounds.IntersectsWith(blt3.Bounds) Or en2.Bounds.IntersectsWith(blt4.Bounds) Or en2.Bounds.IntersectsWith(blt5.Bounds) Then
            fxship.Enabled = True
            boom = 2

        ElseIf en3.Bounds.IntersectsWith(blt1.Bounds) Or en3.Bounds.IntersectsWith(blt2.Bounds) Or en3.Bounds.IntersectsWith(blt3.Bounds) Or en3.Bounds.IntersectsWith(blt4.Bounds) Or en3.Bounds.IntersectsWith(blt5.Bounds) Then
            fxship.Enabled = True
            boom = 3

        ElseIf en4.Bounds.IntersectsWith(blt1.Bounds) Or en4.Bounds.IntersectsWith(blt2.Bounds) Or en4.Bounds.IntersectsWith(blt3.Bounds) Or en4.Bounds.IntersectsWith(blt4.Bounds) Or en4.Bounds.IntersectsWith(blt5.Bounds) Then
            fxship.Enabled = True
            boom = 4

        ElseIf en5.Bounds.IntersectsWith(blt1.Bounds) Or en5.Bounds.IntersectsWith(blt2.Bounds) Or en5.Bounds.IntersectsWith(blt3.Bounds) Or en5.Bounds.IntersectsWith(blt4.Bounds) Or en5.Bounds.IntersectsWith(blt5.Bounds) Then
            fxship.Enabled = True
            boom = 5

        End If

        en1.Left += 10
        en2.Left += 10
        en3.Left += 10
        en4.Left += 10
        en5.Left += 10
        nsync -= 1
        If nsync = 0 Then
            ensycmv1.Enabled = True
            ensycmv2.Enabled = False
            nupdwn += 1
            If nupdwn >= 0 And nupdwn < 10 Then
                en1.Top += 20
                en2.Top += 20
                en3.Top += 20
                en4.Top += 20
                en5.Top += 20
            ElseIf nupdwn >= 10 And nupdwn < 20 Then
                en1.Top -= 20
                en2.Top -= 20
                en3.Top -= 20
                en4.Top -= 20
                en5.Top -= 20
            ElseIf nupdwn = 10 Then
                nupdwn = 0
            End If
        End If
    End Sub

    Private Sub fxship_Tick(sender As Object, e As EventArgs) Handles fxship.Tick
        Dim Health() As Image = {My.Resources.life2, My.Resources.life3, My.Resources.life4, My.Resources.life5, My.Resources.life6, My.Resources.life7}
        Dim Deads() As PictureBox = {ship, en1, en2, en3, en4, en5, boss}
        dead += 1
        If dead = 1 Then
            Deads(boom).Image = My.Resources.dead_1
            If boom = 0 Then
                hp.Image = Health(lifect)
                lifect += 1

            'game over
            If lifect = 6 Then
                Me.BackgroundImage = My.Resources.game_over
                tshipblt.Stop()
                ten1blt.Stop()
                ten2blt.Stop()
                ten3blt.Stop()
                ten4blt.Stop()
                ten5blt.Stop()
                fxship.Stop()
                ensycmv1.Stop()
                ensycmv2.Stop()
                    tbossbt.Stop()
                    bossAI.Stop()
                    
                lifect = 0
                win = 0
                    MessageBox.Show(" YOU LOSE! CLICK OK to PLAY AGAIN")
                If Windows.Forms.DialogResult.OK Then
                        Application.Restart()

                End If

            End If
        End If

        ElseIf dead = 1 Then
        Deads(boom).Image = My.Resources.dead_2
        ElseIf dead = 2 Then
        Deads(boom).Image = My.Resources.dead_3
        ElseIf dead = 3 Then
        Deads(boom).Image = My.Resources.dead_4
        ElseIf dead = 4 Then
        Deads(boom).Image = My.Resources.ship1
        dead = 0
        fxship.Enabled = False

        If boom = 0 Then
            en1bt.Location = New Point(en1.Location)
            n1 = 0
            en2bt.Location = New Point(en2.Location)
            n2 = 0
            en3bt.Location = New Point(en3.Location)
            n3 = 0
            en4bt.Location = New Point(en4.Location)
            n4 = 0
            en5bt.Location = New Point(en5.Location)
            n5 = 0

        ElseIf boom = 1 Then
            en1.Visible = False
            en1bt.Visible = False
            en1.Location = New Point(942, 521)
            en1bt.Location = New Point(0, 0)
            ten1blt.Stop()
            win += 1

        ElseIf boom = 2 Then
            en2.Visible = False
            en2bt.Visible = False
            en2.Location = New Point(942, 521)
            en2bt.Location = New Point(0, 0)
            ten2blt.Stop()
            win += 1
        ElseIf boom = 3 Then
            en3.Visible = False
            en3bt.Visible = False
            en3.Location = New Point(942, 521)
            en3bt.Location = New Point(0, 0)
            ten3blt.Stop()
            win += 1
        ElseIf boom = 4 Then
            en4.Visible = False
            en4bt.Visible = False
            en4.Location = New Point(942, 521)
            en4bt.Location = New Point(0, 0)
            ten4blt.Stop()
            win += 1
        ElseIf boom = 5 Then
            en5.Visible = False
            en5bt.Visible = False
            en5.Location = New Point(942, 521)
            en5bt.Location = New Point(0, 0)
            ten5blt.Stop()
            win += 1

        ElseIf boom = 6 Then
            boss.Visible = False
            bossblt.Visible = False
            boss.Location = New Point(908, 537)
            bossblt.Location = New Point(-48, -187)
            tbossbt.Stop()
            win += 1

        End If

        If win = 5 Then
                boss.Location = New Point(393, 22)
                bossblt.Location = New Point(boss.Location)
                boss.Visible = True
                bossblt.Visible = True
            bossAI.Start()

        ElseIf win = 6 Then
            tshipblt.Stop()
            ten1blt.Stop()
            ten2blt.Stop()
            ten3blt.Stop()
            ten4blt.Stop()
            ten5blt.Stop()
            fxship.Stop()
            ensycmv1.Stop()
            ensycmv2.Stop()
                tbossbt.Stop()
                bossAI.Stop()
            MessageBox.Show(" YOU WIN! CLICK OK to PLAY AGAIN")
                If Windows.Forms.DialogResult.OK Then
                    Application.Restart()
                End If
        End If

        End If

    End Sub

    Private Sub en5bt_Click(sender As Object, e As EventArgs) Handles en5bt.Click

    End Sub

    Private Sub bossAI_Tick(sender As Object, e As EventArgs) Handles bossAI.Tick
        
        If boss.Bounds.IntersectsWith(blt1.Bounds) Or boss.Bounds.IntersectsWith(blt2.Bounds) Or boss.Bounds.IntersectsWith(blt3.Bounds) Or boss.Bounds.IntersectsWith(blt4.Bounds) Or boss.Bounds.IntersectsWith(blt5.Bounds) Then

            If bosshp.Value <= 20 Then
                fxship.Enabled = True
                boom = 6

            End If

            bosshp.Value -= 10
            blt1.Visible = False
            blt1.Location = New Point(382, 490)
            blt2.Visible = False
            blt2.Location = New Point(382, 490)
            blt3.Visible = False
            blt3.Location = New Point(382, 490)
            blt4.Visible = False
            blt4.Location = New Point(382, 490)
            blt5.Visible = False
            blt5.Location = New Point(382, 490)



        End If


        slow += 1
        If subslow = 0 Then
            boss.Left += 109
            If boss.Location.X = 611 Then
                subslow = 1
            End If
        ElseIf subslow = 1 Then
            tbossbt.Enabled = True
            If slow >= 0 And slow < 30 Then
                boss.Left -= 25
            ElseIf slow >= 30 And slow < 60 Then
                boss.Left += 25
            ElseIf slow = 60 Then
                slow = 0
                boss.Left -= 25
            End If

        End If

        If bosshp.Value <= 100 And bosshp.Value > 50 Then
            bossAI.Interval = 100
            tbossbt.Interval = 50
        ElseIf bosshp.Value <= 50 And bosshp.Value > 10 Then
            bossAI.Interval = 50
            tbossbt.Interval = 30
        ElseIf bosshp.Value <= 10 And bosshp.Value > 0 Then
            tbossbt.Interval = 10
            bossAI.Interval = 5

        End If


    End Sub

    Private Sub tbossbt_Tick(sender As Object, e As EventArgs) Handles tbossbt.Tick
        If bossblt.Bounds.IntersectsWith(ship.Bounds) Then
            fxship.Enabled = True
            boom = 0
        End If
        bossblt.Visible = True
        bossblt.Top += 10
        nb += 1
        If nb = 50 Then
            bossblt.Location = New Point(boss.Location)
            boss.Image = My.Resources.alien1_2
            nb = 0
        End If
        If bossblt.Location <> boss.Location Then
            boss.Image = My.Resources.alien1_1
        End If

    End Sub
End Class
