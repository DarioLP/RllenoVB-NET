Public Class Form1
    Dim F As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        TextBox1.Text = MyVerticalProgessBar1.Value
        TextBox2.Text = MyVerticalProgessBar2.Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim F As Integer
        'Dim guardar As Integer
        'Timer1.Start()
        'MyVerticalProgessBar1.Value = Timer1.Interval

        Dim F As Integer
        F = 0
        If F = 0 Then
            For i As Integer = 0 To 5000
                MyVerticalProgessBar1.Increment(1)
                MyVerticalProgessBar2.Increment(-1)
            Next
            'For i As Integer = 0 To 5000
            'MyVerticalProgessBar2.Increment(-1)
            'Next
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim F As Integer
        F = 0
        If F = 0 Then


            For i As Integer = 0 To 5000
                ProgressBar1.Value = 1
                If (MyVerticalProgessBar1.Value >= 2500) Then
                    MyVerticalProgessBar1.Increment(-1)
                    TextBox1.Text = MyVerticalProgessBar1.Value
                End If
                If (MyVerticalProgessBar1.Value < 3700) Then
                    MyVerticalProgessBar2.Increment(1)
                    TextBox2.Text = MyVerticalProgessBar2.Value
                End If
            Next
            'For i As Integer = 0 To 5000
            'MyVerticalProgessBar2.Increment(1)
            'Next
        End If
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        If HScrollBar1.Left Then
            Timer1.Start()
        Else
            If HScrollBar1.RightToLeft Then
                Timer1.Interval = 1 + 5000
            End If
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        For i As Integer = 0 To 5000
                MyVerticalProgessBar1.Increment(1)
            MyVerticalProgessBar2.Increment(-1)
            TextBox1.Text = MyVerticalProgessBar1.Value
            TextBox2.Text = MyVerticalProgessBar2.Value
        Next
    End Sub
End Class
