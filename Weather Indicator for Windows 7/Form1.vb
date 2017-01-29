Option Explicit On
Public Class Form1
    'Значение активности окна
    Shared actived As Integer = 0
    'Отображение окна
    Private Sub DisplayWindow(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Notify.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If actived = 0 Then
                Show()
                Activate()
                actived = 1
            Else
                Hide()
                actived = 0
            End If
        End If
    End Sub
    'Скрытие окна
    Private Sub HideWindow(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        Me.Hide()
    End Sub

    '    Private Sub SearchClick(ByVal sender As System.Object, ByVal e As System.EventArgs)




    '        Dim xUrl As String =
    '            "http://api.openweathermap.org/data/2.5/find?q=" + CityNameInput.Text + "&type=accurate&units=metric&mode=xml&lang=ru&appid=3e633d3acd62fddbde45a582d13e1a5f"

    '        Dim xInfo = XElement.Load(xUrl)

    '       For Each fcInfo As XElement In xInfo...<item>
    '        Dim text As String = fcInfo...<country>.Value

    '        MessageBox.Show(text)
    '        Next

    '    End Sub

    'Function Search(xUrl As String)
    ' End Function

    Private Sub ExitMenuItem_Click(sender As Object, e As EventArgs) Handles ExitMenuItem.Click
        Notify.Visible = False
        Close()
    End Sub

End Class