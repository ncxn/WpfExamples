﻿Public Class MainApp
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim w As Windows.Window = New MainMenuExample
        w.Show()
    End Sub
End Class
