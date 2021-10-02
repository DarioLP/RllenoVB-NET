Imports System
Imports System.Windows.Forms

Public Class MyVerticalProgessBar
    Inherits ProgressBar
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim bp As CreateParams = MyBase.CreateParams
            bp.Style = bp.Style Or &H4
            Return bp
        End Get
    End Property
End Class
